using System.Drawing.Imaging;

namespace Base64ImageViewer;

public partial class MainForm : Form
{
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
        imageDisplay.Image = Base64ToImage(inputImage.Text);
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
        if (string.IsNullOrWhiteSpace(inputImage.Text))
        {
            MessageBox.Show($"Input string is not valid base64 image", "Base64ImageViewer Error");
            return;
        }

        try
        {
            Image image = Base64ToImage(inputImage.Text);
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
}
