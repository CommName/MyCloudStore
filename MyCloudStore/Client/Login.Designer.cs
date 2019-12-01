namespace Client
{
    partial class Login
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
            this.password_text_box = new System.Windows.Forms.TextBox();
            this.username_text_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.herderLabel = new System.Windows.Forms.Label();
            this.Login_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // password_text_box
            // 
            this.password_text_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password_text_box.Location = new System.Drawing.Point(76, 65);
            this.password_text_box.Name = "password_text_box";
            this.password_text_box.PasswordChar = '*';
            this.password_text_box.Size = new System.Drawing.Size(143, 20);
            this.password_text_box.TabIndex = 0;
            this.password_text_box.UseSystemPasswordChar = true;
            // 
            // username_text_box
            // 
            this.username_text_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.username_text_box.Location = new System.Drawing.Point(76, 39);
            this.username_text_box.Name = "username_text_box";
            this.username_text_box.Size = new System.Drawing.Size(143, 20);
            this.username_text_box.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // herderLabel
            // 
            this.herderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.herderLabel.AutoSize = true;
            this.herderLabel.BackColor = System.Drawing.Color.Transparent;
            this.herderLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.herderLabel.Location = new System.Drawing.Point(84, 0);
            this.herderLabel.Name = "herderLabel";
            this.herderLabel.Size = new System.Drawing.Size(56, 25);
            this.herderLabel.TabIndex = 4;
            this.herderLabel.Text = "Login";
            this.herderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login_button
            // 
            this.Login_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_button.Location = new System.Drawing.Point(7, 95);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(212, 24);
            this.Login_button.TabIndex = 5;
            this.Login_button.Text = "Login";
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.password_text_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.username_text_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.herderLabel);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(235, 125);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password_text_box;
        private System.Windows.Forms.TextBox username_text_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label herderLabel;
        private System.Windows.Forms.Button Login_button;
    }
}
