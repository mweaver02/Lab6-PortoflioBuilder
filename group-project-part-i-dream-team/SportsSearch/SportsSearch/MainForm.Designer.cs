namespace SportsSearch
{
    partial class MainForm
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
            this.selectionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.footballPictureBox = new System.Windows.Forms.PictureBox();
            this.nbaPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nflPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.backLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.footballPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nflPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // selectionLabel
            // 
            this.selectionLabel.AutoSize = true;
            this.selectionLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.selectionLabel.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectionLabel.Location = new System.Drawing.Point(502, 398);
            this.selectionLabel.Name = "selectionLabel";
            this.selectionLabel.Size = new System.Drawing.Size(159, 18);
            this.selectionLabel.TabIndex = 13;
            this.selectionLabel.Text = "SELECT A SPORT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Font = new System.Drawing.Font("Verdana", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(360, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 34);
            this.label1.TabIndex = 14;
            this.label1.Text = "Welcome To Sports Search!";
            // 
            // footballPictureBox
            // 
            this.footballPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.footballPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.footballPictureBox.Image = global::SportsSearch.Properties.Resources.NFL;
            this.footballPictureBox.Location = new System.Drawing.Point(581, 154);
            this.footballPictureBox.Name = "footballPictureBox";
            this.footballPictureBox.Size = new System.Drawing.Size(535, 511);
            this.footballPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.footballPictureBox.TabIndex = 12;
            this.footballPictureBox.TabStop = false;
            this.footballPictureBox.WaitOnLoad = true;
            this.footballPictureBox.Click += new System.EventHandler(this.footballPictureBox_Click);
            // 
            // nbaPictureBox
            // 
            this.nbaPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.nbaPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nbaPictureBox.Image = global::SportsSearch.Properties.Resources.NBA;
            this.nbaPictureBox.Location = new System.Drawing.Point(50, 154);
            this.nbaPictureBox.Name = "nbaPictureBox";
            this.nbaPictureBox.Size = new System.Drawing.Size(525, 511);
            this.nbaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nbaPictureBox.TabIndex = 10;
            this.nbaPictureBox.TabStop = false;
            this.nbaPictureBox.Click += new System.EventHandler(this.nbaPictureBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(520, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(535, 511);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // nflPictureBox
            // 
            this.nflPictureBox.Location = new System.Drawing.Point(520, -1);
            this.nflPictureBox.Name = "nflPictureBox";
            this.nflPictureBox.Size = new System.Drawing.Size(535, 511);
            this.nflPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nflPictureBox.TabIndex = 7;
            this.nflPictureBox.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SportsSearch.Properties.Resources.background2;
            this.pictureBox2.Location = new System.Drawing.Point(0, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1186, 798);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // backLabel
            // 
            this.backLabel.AutoSize = true;
            this.backLabel.BackColor = System.Drawing.Color.DarkRed;
            this.backLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backLabel.Location = new System.Drawing.Point(536, 696);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(102, 25);
            this.backLabel.TabIndex = 16;
            this.backLabel.Text = "Go Back";
            this.backLabel.Click += new System.EventHandler(this.backLabel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1182, 797);
            this.Controls.Add(this.backLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectionLabel);
            this.Controls.Add(this.footballPictureBox);
            this.Controls.Add(this.nbaPictureBox);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SportsSearch";
            ((System.ComponentModel.ISupportInitialize)(this.footballPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nflPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox nbaPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox nflPictureBox;
        private System.Windows.Forms.PictureBox footballPictureBox;
        private System.Windows.Forms.Label selectionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label backLabel;
    }
}