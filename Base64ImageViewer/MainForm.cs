using System.Drawing.Imaging;

namespace Base64ImageViewer;

public partial class MainForm : Form
{
    private const int MaxDisplayLength = 100000;
    private string? _fullBase64String;
    private bool _isSettingText;

    private string CurrentBase64 => _fullBase64String ?? inputImage.Text;

    public MainForm()
    {
        InitializeComponent();
        DisplayImage();
    }

    private void viewButton_Click(object sender, EventArgs e)
    {
        if (inputImage is null)
        {
            return;
        }

        DisplayImage();
    }

    private void DisplayImage()
    {
        imageDisplay.Image = Base64ToImage(CurrentBase64);
    }

    private Image Base64ToImage(string base64String)
    {
        try
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (var ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Base64ImageViewer Error");
            return null;
        }
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(CurrentBase64))
        {
            MessageBox.Show($"Input string is not valid base64 image", "Base64ImageViewer Error");
            return;
        }

        try
        {
            Image image = Base64ToImage(CurrentBase64);
            if(image is null)
            {
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG Image|*.png|Bitmap Image|*.bmp|JPEG Image|*.jpg";
                saveFileDialog.Title = "Save an Image File";
                saveFileDialog.FileName = "image";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ImageFormat format = ImageFormat.Png;
                    switch (Path.GetExtension(saveFileDialog.FileName).ToLower())
                    {
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                        case ".jpg":
                        case ".jpeg":
                            format = ImageFormat.Jpeg;
                            break;
                    }

                    image.Save(saveFileDialog.FileName, format);
                    MessageBox.Show("Image saved successfully.", "Base64ImageViewer");
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to save image: {ex}", "Base64ImageViewer Error");
        }
    }

    private void loadButton_Click(object sender, EventArgs e)
    {
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp;*.gif;*.tiff;*.tif;*.ico|PNG Image|*.png|JPEG Image|*.jpg;*.jpeg|Bitmap Image|*.bmp|GIF Image|*.gif|TIFF Image|*.tiff;*.tif|Icon|*.ico|All Files|*.*";
            openFileDialog.Title = "Select an Image File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    byte[] imageBytes = File.ReadAllBytes(openFileDialog.FileName);
                    string base64String = Convert.ToBase64String(imageBytes);

                    SetBase64Content(base64String);
                    DisplayImage();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load image: {ex.Message}", "Base64ImageViewer Error");
                }
            }
        }
    }

    private void SetBase64Content(string base64String)
    {
        _isSettingText = true;
        try
        {
            if (base64String.Length > MaxDisplayLength)
            {
                _fullBase64String = base64String;
                inputImage.Text = base64String.Substring(0, MaxDisplayLength) +
                    $"\r\n\r\n[... TRUNCATED - Total length: {base64String.Length:N0} characters. Use 'Copy' button for full content ...]";
            }
            else
            {
                _fullBase64String = null;
                inputImage.Text = base64String;
            }
        }
        finally
        {
            _isSettingText = false;
        }
    }

    private void inputImage_TextChanged(object sender, EventArgs e)
    {
        if (!_isSettingText)
        {
            _fullBase64String = null;
        }
    }

    private void inputImage_KeyDown(object sender, KeyEventArgs e)
    {
        bool isPaste = (e.Control && e.KeyCode == Keys.V) || (e.Shift && e.KeyCode == Keys.Insert);
        if (isPaste && Clipboard.ContainsText())
        {
            e.Handled = true;
            e.SuppressKeyPress = true;

            string clipboardText = Clipboard.GetText();
            SetBase64Content(clipboardText);
        }
    }

    private void copyButton_Click(object sender, EventArgs e)
    {
        string content = CurrentBase64;
        if (string.IsNullOrWhiteSpace(content))
        {
            MessageBox.Show("No content to copy.", "Base64ImageViewer");
            return;
        }

        Clipboard.SetText(content);
        MessageBox.Show($"Copied {content.Length:N0} characters to clipboard.", "Base64ImageViewer");
    }
}
