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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CTR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "IV";
            // 
            // ckpComboBox
            // 
            this.ckpComboBox.FormattingEnabled = true;
            this.ckpComboBox.Location = new System.Drawing.Point(16, 101);
            this.ckpComboBox.Name = "ckpComboBox";
            this.ckpComboBox.Size = new System.Drawing.Size(313, 28);
            this.ckpComboBox.TabIndex = 2;
            // 
            // ckpBox
            // 
            this.ckpBox.Location = new System.Drawing.Point(3, 135);
            this.ckpBox.Name = "ckpBox";
            this.ckpBox.Size = new System.Drawing.Size(344, 310);
            this.ckpBox.TabIndex = 3;
            this.ckpBox.TabStop = false;
            this.ckpBox.Text = "Cypher crypto box";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 26);
            this.textBox1.TabIndex = 4;
            // 
            // CTRSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ckpBox);
            this.Controls.Add(this.ckpComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CTRSettings";
            this.Size = new System.Drawing.Size(350, 448);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ckpComboBox;
        private System.Windows.Forms.GroupBox ckpBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
