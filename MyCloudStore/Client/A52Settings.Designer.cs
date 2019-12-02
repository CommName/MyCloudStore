namespace Client
{
    partial class A52Settings
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
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.fTextBox = new System.Windows.Forms.TextBox();
            this.KcTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.manSet = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(66, 34);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(266, 26);
            this.keyTextBox.TabIndex = 0;
            // 
            // fTextBox
            // 
            this.fTextBox.Location = new System.Drawing.Point(66, 187);
            this.fTextBox.Name = "fTextBox";
            this.fTextBox.Size = new System.Drawing.Size(266, 26);
            this.fTextBox.TabIndex = 1;
            // 
            // KcTextBox
            // 
            this.KcTextBox.Location = new System.Drawing.Point(66, 138);
            this.KcTextBox.Name = "KcTextBox";
            this.KcTextBox.Size = new System.Drawing.Size(266, 26);
            this.KcTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "f";
            // 
            // manSet
            // 
            this.manSet.AutoSize = true;
            this.manSet.Location = new System.Drawing.Point(66, 96);
            this.manSet.Name = "manSet";
            this.manSet.Size = new System.Drawing.Size(120, 24);
            this.manSet.TabIndex = 6;
            this.manSet.Text = "Manulay set";
            this.manSet.UseVisualStyleBackColor = true;
            // 
            // A52Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.manSet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KcTextBox);
            this.Controls.Add(this.fTextBox);
            this.Controls.Add(this.keyTextBox);
            this.Name = "A52Settings";
            this.Size = new System.Drawing.Size(350, 448);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.TextBox fTextBox;
        private System.Windows.Forms.TextBox KcTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox manSet;
    }
}
