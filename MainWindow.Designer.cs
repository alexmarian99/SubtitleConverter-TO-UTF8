namespace SubtitleFixer
{
    partial class MainWindow
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
            transformButton = new Button();
            folderPathLabelInfo = new Label();
            folderPathTextBox = new TextBox();
            folderBrowserDialog = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // transformButton
            // 
            transformButton.Location = new Point(553, 12);
            transformButton.Name = "transformButton";
            transformButton.Size = new Size(99, 36);
            transformButton.TabIndex = 0;
            transformButton.Text = "Transform";
            transformButton.UseVisualStyleBackColor = true;
            transformButton.Click += TransformSubtitles;
            // 
            // folderPathLabelInfo
            // 
            folderPathLabelInfo.AutoSize = true;
            folderPathLabelInfo.Location = new Point(12, 20);
            folderPathLabelInfo.Name = "folderPathLabelInfo";
            folderPathLabelInfo.Size = new Size(94, 20);
            folderPathLabelInfo.TabIndex = 1;
            folderPathLabelInfo.Text = "Folder path:";
            // 
            // folderPathTextBox
            // 
            folderPathTextBox.Location = new Point(112, 17);
            folderPathTextBox.Name = "folderPathTextBox";
            folderPathTextBox.PlaceholderText = "Click there to select a folder";
            folderPathTextBox.ReadOnly = true;
            folderPathTextBox.Size = new Size(435, 26);
            folderPathTextBox.TabIndex = 2;
            folderPathTextBox.Click += SelectPath;
            // 
            // folderBrowserDialog
            // 
            folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 59);
            Controls.Add(folderPathTextBox);
            Controls.Add(folderPathLabelInfo);
            Controls.Add(transformButton);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Subtitle Fixer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button transformButton;
        private Label folderPathLabelInfo;
        private TextBox folderPathTextBox;
        private FolderBrowserDialog folderBrowserDialog;
    }
}