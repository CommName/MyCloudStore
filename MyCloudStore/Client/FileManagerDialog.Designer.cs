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
            this.statusListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // file_list
            // 
            this.file_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.file_list.FormattingEnabled = true;
            this.file_list.Location = new System.Drawing.Point(3, 3);
            this.file_list.Name = "file_list";
            this.file_list.Size = new System.Drawing.Size(269, 264);
            this.file_list.TabIndex = 0;
            // 
            // uploadButton
            // 
            this.uploadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uploadButton.Location = new System.Drawing.Point(3, 285);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(85, 36);
            this.uploadButton.TabIndex = 1;
            this.uploadButton.Text = "Upload file";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // download_button
            // 
            this.download_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.download_button.Location = new System.Drawing.Point(94, 285);
            this.download_button.Name = "download_button";
            this.download_button.Size = new System.Drawing.Size(83, 36);
            this.download_button.TabIndex = 2;
            this.download_button.Text = "Download file";
            this.download_button.UseVisualStyleBackColor = true;
            this.download_button.Click += new System.EventHandler(this.download_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_button.Location = new System.Drawing.Point(183, 285);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(89, 36);
            this.delete_button.TabIndex = 3;
            this.delete_button.Text = "Delete file";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // cryptoBox
            // 
            this.cryptoBox.Location = new System.Drawing.Point(278, 30);
            this.cryptoBox.Name = "cryptoBox";
            this.cryptoBox.Size = new System.Drawing.Size(233, 237);
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
            this.cryptoComboBox.Location = new System.Drawing.Point(278, 6);
            this.cryptoComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.cryptoComboBox.Name = "cryptoComboBox";
            this.cryptoComboBox.Size = new System.Drawing.Size(235, 21);
            this.cryptoComboBox.TabIndex = 0;
            this.cryptoComboBox.SelectedIndexChanged += new System.EventHandler(this.cryptoComboBox_SelectedIndexChanged_1);
            // 
            // statusListBox
            // 
            this.statusListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusListBox.FormattingEnabled = true;
            this.statusListBox.Location = new System.Drawing.Point(278, 278);
            this.statusListBox.Name = "statusListBox";
            this.statusListBox.Size = new System.Drawing.Size(233, 43);
            this.statusListBox.TabIndex = 0;
            // 
            // FileManagerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusListBox);
            this.Controls.Add(this.cryptoComboBox);
            this.Controls.Add(this.cryptoBox);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.download_button);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.file_list);
            this.Name = "FileManagerDialog";
            this.Size = new System.Drawing.Size(514, 326);
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
        private System.Windows.Forms.ListBox statusListBox;
    }
}
