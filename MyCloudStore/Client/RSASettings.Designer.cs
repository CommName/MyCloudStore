namespace Client
{
    partial class RSASettings
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.p = new System.Windows.Forms.NumericUpDown();
            this.e = new System.Windows.Forms.NumericUpDown();
            this.q = new System.Windows.Forms.NumericUpDown();
            this.d = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.n = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.p)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // p
            // 
            this.p.Location = new System.Drawing.Point(25, 36);
            this.p.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(87, 20);
            this.p.TabIndex = 2;
            // 
            // e
            // 
            this.e.Enabled = false;
            this.e.Location = new System.Drawing.Point(80, 104);
            this.e.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(139, 20);
            this.e.TabIndex = 3;
            // 
            // q
            // 
            this.q.Location = new System.Drawing.Point(150, 36);
            this.q.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.q.Name = "q";
            this.q.Size = new System.Drawing.Size(77, 20);
            this.q.TabIndex = 4;
            // 
            // d
            // 
            this.d.Enabled = false;
            this.d.Location = new System.Drawing.Point(80, 130);
            this.d.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(139, 20);
            this.d.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "p";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "q";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(25, 70);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "p and q";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(134, 70);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Pub and priv";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // n
            // 
            this.n.Location = new System.Drawing.Point(80, 156);
            this.n.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(139, 20);
            this.n.TabIndex = 10;
            // 
            // RSASettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.n);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.d);
            this.Controls.Add(this.q);
            this.Controls.Add(this.e);
            this.Controls.Add(this.p);
            this.Name = "RSASettings";
            this.Size = new System.Drawing.Size(240, 300);
            ((System.ComponentModel.ISupportInitialize)(this.p)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.NumericUpDown p;
        private System.Windows.Forms.NumericUpDown e;
        private System.Windows.Forms.NumericUpDown q;
        private System.Windows.Forms.NumericUpDown d;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.NumericUpDown n;
    }
}
