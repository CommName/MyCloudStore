namespace Client
{
    partial class FileManagerDialog
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.file_list = new System.Windows.Forms.ListBox();
            this.uploadButton = new System.Windows.Forms.Button();
            this.download_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.cryptoBox = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.cryptoComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // file_list
            // 
            this.file_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.file_list.FormattingEnabled = true;
            this.file_list.ItemHeight = 20;
            this.file_list.Location = new System.Drawing.Point(4, 5);
            this.file_list.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.file_list.Name = "file_list";
            this.file_list.Size = new System.Drawing.Size(402, 404);
            this.file_list.TabIndex = 0;
            // 
            // uploadButton
            // 
            this.uploadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uploadButton.Location = new System.Drawing.Point(4, 438);
            this.uploadButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(128, 55);
            this.uploadButton.TabIndex = 1;
            this.uploadButton.Text = "Upload file";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // download_button
            // 
            this.download_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.download_button.Location = new System.Drawing.Point(141, 438);
            this.download_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.download_button.Name = "download_button";
            this.download_button.Size = new System.Drawing.Size(124, 55);
            this.download_button.TabIndex = 2;
            this.download_button.Text = "Download file";
            this.download_button.UseVisualStyleBackColor = true;
            this.download_button.Click += new System.EventHandler(this.download_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_button.Location = new System.Drawing.Point(274, 438);
            this.delete_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(134, 55);
            this.delete_button.TabIndex = 3;
            this.delete_button.Text = "Delete file";
            this.delete_button.UseVisualStyleBackColor = true;
            // 
            // cryptoBox
            // 
            this.cryptoBox.Location = new System.Drawing.Point(417, 46);
            this.cryptoBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cryptoBox.Name = "cryptoBox";
            this.cryptoBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cryptoBox.Size = new System.Drawing.Size(350, 448);
            this.cryptoBox.TabIndex = 4;
            this.cryptoBox.TabStop = false;
            this.cryptoBox.Text = "Crypto settings";
            // 
            // OFD
            // 
            this.OFD.FileName = "openFileDialog1";
            // 
            // cryptoComboBox
            // 
            this.cryptoComboBox.FormattingEnabled = true;
            this.cryptoComboBox.Location = new System.Drawing.Point(417, 10);
            this.cryptoComboBox.Name = "cryptoComboBox";
            this.cryptoComboBox.Size = new System.Drawing.Size(350, 28);
            this.cryptoComboBox.TabIndex = 0;
            this.cryptoComboBox.SelectedIndexChanged += new System.EventHandler(this.cryptoComboBox_SelectedIndexChanged_1);
            // 
            // FileManagerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cryptoComboBox);
            this.Controls.Add(this.cryptoBox);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.download_button);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.file_list);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FileManagerDialog";
            this.Size = new System.Drawing.Size(771, 502);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox file_list;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Button download_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.GroupBox cryptoBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.ComboBox cryptoComboBox;
    }
}
