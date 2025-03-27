namespace Base64ImageViewer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            splitContainer1 = new SplitContainer();
            inputImage = new TextBox();
            panel1 = new Panel();
            saveButton = new Button();
            viewButton = new Button();
            imageDisplay = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imageDisplay).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(inputImage);
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(imageDisplay);
            splitContainer1.Size = new Size(2046, 1147);
            splitContainer1.SplitterDistance = 682;
            splitContainer1.TabIndex = 0;
            // 
            // inputImage
            // 
            inputImage.Dock = DockStyle.Fill;
            inputImage.Location = new Point(0, 0);
            inputImage.MaxLength = 327670;
            inputImage.Multiline = true;
            inputImage.Name = "inputImage";
            inputImage.ScrollBars = ScrollBars.Vertical;
            inputImage.Size = new Size(682, 1064);
            inputImage.TabIndex = 0;
            inputImage.Text = resources.GetString("inputImage.Text");
            // 
            // panel1
            // 
            panel1.Controls.Add(saveButton);
            panel1.Controls.Add(viewButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 1064);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 83);
            panel1.TabIndex = 2;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(32, 26);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(112, 34);
            saveButton.TabIndex = 2;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // viewButton
            // 
            viewButton.Location = new Point(178, 26);
            viewButton.Name = "viewButton";
            viewButton.Size = new Size(112, 34);
            viewButton.TabIndex = 1;
            viewButton.Text = "View";
            viewButton.UseVisualStyleBackColor = true;
            viewButton.Click += viewButton_Click;
            // 
            // imageDisplay
            // 
            imageDisplay.Dock = DockStyle.Fill;
            imageDisplay.Location = new Point(0, 0);
            imageDisplay.Name = "imageDisplay";
            imageDisplay.Size = new Size(1360, 1147);
            imageDisplay.SizeMode = PictureBoxSizeMode.Zoom;
            imageDisplay.TabIndex = 0;
            imageDisplay.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2046, 1147);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Base64ImageViewer";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imageDisplay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox inputImage;
        private Panel panel1;
        private Button saveButton;
        private Button viewButton;
        private PictureBox imageDisplay;
    }
}
