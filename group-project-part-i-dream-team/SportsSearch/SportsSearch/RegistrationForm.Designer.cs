namespace SportsSearch
{
    partial class RegistrationForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.regPassLabel = new System.Windows.Forms.Label();
            this.regUserLabel = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.textNewPassword = new System.Windows.Forms.TextBox();
            this.textNewUsername = new System.Windows.Forms.TextBox();
            this.registerLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // regPassLabel
            // 
            this.regPassLabel.AutoSize = true;
            this.regPassLabel.BackColor = System.Drawing.Color.Transparent;
            this.regPassLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regPassLabel.ForeColor = System.Drawing.Color.Transparent;
            this.regPassLabel.Location = new System.Drawing.Point(229, 284);
            this.regPassLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.regPassLabel.Name = "regPassLabel";
            this.regPassLabel.Size = new System.Drawing.Size(198, 18);
            this.regPassLabel.TabIndex = 17;
            this.regPassLabel.Text = "Enter a new password:";
            // 
            // regUserLabel
            // 
            this.regUserLabel.AutoSize = true;
            this.regUserLabel.BackColor = System.Drawing.Color.Transparent;
            this.regUserLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regUserLabel.ForeColor = System.Drawing.Color.Transparent;
            this.regUserLabel.Location = new System.Drawing.Point(229, 175);
            this.regUserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.regUserLabel.Name = "regUserLabel";
            this.regUserLabel.Size = new System.Drawing.Size(200, 18);
            this.regUserLabel.TabIndex = 16;
            this.regUserLabel.Text = "Enter a new username:";
            // 
            // registerBtn
            // 
            this.registerBtn.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.Location = new System.Drawing.Point(256, 398);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(152, 45);
            this.registerBtn.TabIndex = 15;
            this.registerBtn.Text = "REGISTER";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // textNewPassword
            // 
            this.textNewPassword.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNewPassword.Location = new System.Drawing.Point(229, 307);
            this.textNewPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textNewPassword.Name = "textNewPassword";
            this.textNewPassword.PasswordChar = '*';
            this.textNewPassword.Size = new System.Drawing.Size(414, 27);
            this.textNewPassword.TabIndex = 14;
            this.textNewPassword.UseSystemPasswordChar = true;
            // 
            // textNewUsername
            // 
            this.textNewUsername.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNewUsername.Location = new System.Drawing.Point(229, 198);
            this.textNewUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textNewUsername.Name = "textNewUsername";
            this.textNewUsername.Size = new System.Drawing.Size(414, 27);
            this.textNewUsername.TabIndex = 13;
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.BackColor = System.Drawing.Color.Transparent;
            this.registerLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registerLabel.Location = new System.Drawing.Point(328, 104);
            this.registerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(172, 22);
            this.registerLabel.TabIndex = 12;
            this.registerLabel.Text = "USER REGISTER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SportsSearch.Properties.Resources.background2;
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(811, 570);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(461, 398);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(155, 45);
            this.backBtn.TabIndex = 19;
            this.backBtn.Text = "BACK";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(338, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Sports Search";
            // 
            // RegistrationForm
            // 
            this.AcceptButton = this.registerBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelButton = this.backBtn;
            this.ClientSize = new System.Drawing.Size(815, 572);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.regPassLabel);
            this.Controls.Add(this.regUserLabel);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.textNewPassword);
            this.Controls.Add(this.textNewUsername);
            this.Controls.Add(this.registerLabel);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label regPassLabel;
        private System.Windows.Forms.Label regUserLabel;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.TextBox textNewPassword;
        private System.Windows.Forms.TextBox textNewUsername;
        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label1;
    }
}