namespace Client
{
    partial class CTRSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ckpComboBox = new System.Windows.Forms.ComboBox();
            this.ckpBox = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.IVtextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CTR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "IV";
            // 
            // ckpComboBox
            // 
            this.ckpComboBox.FormattingEnabled = true;
            this.ckpComboBox.Location = new System.Drawing.Point(11, 66);
            this.ckpComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckpComboBox.Name = "ckpComboBox";
            this.ckpComboBox.Size = new System.Drawing.Size(210, 21);
            this.ckpComboBox.TabIndex = 2;
            this.ckpComboBox.SelectedIndexChanged += new System.EventHandler(this.ckpComboBox_SelectedIndexChanged);
            // 
            // ckpBox
            // 
            this.ckpBox.Location = new System.Drawing.Point(2, 88);
            this.ckpBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckpBox.Name = "ckpBox";
            this.ckpBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckpBox.Size = new System.Drawing.Size(229, 201);
            this.ckpBox.TabIndex = 3;
            this.ckpBox.TabStop = false;
            this.ckpBox.Text = "Cypher crypto box";
            // 
            // IVtextBox
            // 
            this.IVtextBox.Location = new System.Drawing.Point(29, 44);
            this.IVtextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IVtextBox.Name = "IVtextBox";
            this.IVtextBox.Size = new System.Drawing.Size(191, 20);
            this.IVtextBox.TabIndex = 4;
            // 
            // CTRSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IVtextBox);
            this.Controls.Add(this.ckpBox);
            this.Controls.Add(this.ckpComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CTRSettings";
            this.Size = new System.Drawing.Size(233, 291);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ckpComboBox;
        private System.Windows.Forms.GroupBox ckpBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox IVtextBox;
    }
}
