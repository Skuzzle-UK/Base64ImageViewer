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
            copyButton = new Button();
            panel2 = new Panel();
            imageDisplay = new PictureBox();
            loadButton = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imageDisplay).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(inputImage);
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Panel2.Controls.Add(imageDisplay);
            splitContainer1.Size = new Size(1432, 688);
            splitContainer1.SplitterDistance = 477;
            splitContainer1.SplitterWidth = 3;
            splitContainer1.TabIndex = 0;
            // 
            // inputImage
            // 
            inputImage.Dock = DockStyle.Fill;
            inputImage.Location = new Point(0, 0);
            inputImage.Margin = new Padding(2);
            inputImage.MaxLength = 327670;
            inputImage.Multiline = true;
            inputImage.Name = "inputImage";
            inputImage.ScrollBars = ScrollBars.Vertical;
            inputImage.Size = new Size(477, 638);
            inputImage.TabIndex = 0;
            inputImage.Text = resources.GetString("inputImage.Text");
            inputImage.TextChanged += inputImage_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(copyButton);
            panel1.Controls.Add(saveButton);
            panel1.Controls.Add(viewButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 638);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(477, 50);
            panel1.TabIndex = 2;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(22, 16);
            saveButton.Margin = new Padding(2);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(78, 20);
            saveButton.TabIndex = 2;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // viewButton
            // 
            viewButton.Location = new Point(125, 16);
            viewButton.Margin = new Padding(2);
            viewButton.Name = "viewButton";
            viewButton.Size = new Size(78, 20);
            viewButton.TabIndex = 1;
            viewButton.Text = "View";
            viewButton.UseVisualStyleBackColor = true;
            viewButton.Click += viewButton_Click;
            //
            // copyButton
            //
            copyButton.Location = new Point(228, 16);
            copyButton.Margin = new Padding(2);
            copyButton.Name = "copyButton";
            copyButton.Size = new Size(78, 20);
            copyButton.TabIndex = 3;
            copyButton.Text = "Copy";
            copyButton.UseVisualStyleBackColor = true;
            copyButton.Click += copyButton_Click;
            //
            // panel2
            // 
            panel2.Controls.Add(loadButton);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 638);
            panel2.Name = "panel2";
            panel2.Size = new Size(952, 50);
            panel2.TabIndex = 1;
            // 
            // imageDisplay
            // 
            imageDisplay.Dock = DockStyle.Fill;
            imageDisplay.Location = new Point(0, 0);
            imageDisplay.Margin = new Padding(2);
            imageDisplay.Name = "imageDisplay";
            imageDisplay.Size = new Size(952, 688);
            imageDisplay.SizeMode = PictureBoxSizeMode.Zoom;
            imageDisplay.TabIndex = 0;
            imageDisplay.TabStop = false;
            //
            // loadButton
            //
            loadButton.Location = new Point(845, 13);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(75, 23);
            loadButton.TabIndex = 0;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1432, 688);
            Controls.Add(splitContainer1);
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "Base64ImageViewer";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imageDisplay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox inputImage;
        private Panel panel1;
        private Button saveButton;
        private Button viewButton;
        private Button copyButton;
        private PictureBox imageDisplay;
        private Panel panel2;
        private Button loadButton;
    }
}
