namespace MaxWeaver_Lab_1
{
    partial class ProductForm
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
            this.SearchProductByProductNumber = new System.Windows.Forms.GroupBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.ProductNumber = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.UnitsOnHand = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.SearchProductsByDescription = new System.Windows.Forms.GroupBox();
            this.searchTextBox2 = new System.Windows.Forms.TextBox();
            this.searchButton2 = new System.Windows.Forms.Button();
            this.ProductListBox = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listViewUOH = new System.Windows.Forms.ListView();
            this.searchTextBox3 = new System.Windows.Forms.TextBox();
            this.searchButtonUOH = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.searchButton4 = new System.Windows.Forms.Button();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SearchProductByProductNumber.SuspendLayout();
            this.SearchProductsByDescription.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchProductByProductNumber
            // 
            this.SearchProductByProductNumber.Controls.Add(this.label3);
            this.SearchProductByProductNumber.Controls.Add(this.Price);
            this.SearchProductByProductNumber.Controls.Add(this.UnitsOnHand);
            this.SearchProductByProductNumber.Controls.Add(this.DescriptionLabel);
            this.SearchProductByProductNumber.Controls.Add(this.ProductNumber);
            this.SearchProductByProductNumber.Controls.Add(this.searchTextBox);
            this.SearchProductByProductNumber.Controls.Add(this.searchButton);
            this.SearchProductByProductNumber.Location = new System.Drawing.Point(53, 50);
            this.SearchProductByProductNumber.Name = "SearchProductByProductNumber";
            this.SearchProductByProductNumber.Size = new System.Drawing.Size(374, 310);
            this.SearchProductByProductNumber.TabIndex = 5;
            this.SearchProductByProductNumber.TabStop = false;
            this.SearchProductByProductNumber.Text = "Search For A Product By Product Number";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(21, 93);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 26);
            this.searchTextBox.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(18, 148);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(103, 37);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // ProductNumber
            // 
            this.ProductNumber.AutoSize = true;
            this.ProductNumber.Location = new System.Drawing.Point(182, 70);
            this.ProductNumber.Name = "ProductNumber";
            this.ProductNumber.Size = new System.Drawing.Size(124, 20);
            this.ProductNumber.TabIndex = 4;
            this.ProductNumber.Text = "Product Number";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(182, 127);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(89, 20);
            this.DescriptionLabel.TabIndex = 5;
            this.DescriptionLabel.Text = "Description";
            // 
            // UnitsOnHand
            // 
            this.UnitsOnHand.AutoSize = true;
            this.UnitsOnHand.Location = new System.Drawing.Point(182, 185);
            this.UnitsOnHand.Name = "UnitsOnHand";
            this.UnitsOnHand.Size = new System.Drawing.Size(111, 20);
            this.UnitsOnHand.TabIndex = 6;
            this.UnitsOnHand.Text = "Units on Hand";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(182, 237);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(44, 20);
            this.Price.TabIndex = 7;
            this.Price.Text = "Price";
            // 
            // SearchProductsByDescription
            // 
            this.SearchProductsByDescription.Controls.Add(this.label4);
            this.SearchProductsByDescription.Controls.Add(this.ProductListBox);
            this.SearchProductsByDescription.Controls.Add(this.searchTextBox2);
            this.SearchProductsByDescription.Controls.Add(this.searchButton2);
            this.SearchProductsByDescription.Location = new System.Drawing.Point(462, 59);
            this.SearchProductsByDescription.Name = "SearchProductsByDescription";
            this.SearchProductsByDescription.Size = new System.Drawing.Size(500, 309);
            this.SearchProductsByDescription.TabIndex = 6;
            this.SearchProductsByDescription.TabStop = false;
            this.SearchProductsByDescription.Text = "Search For Products By Description";
            // 
            // searchTextBox2
            // 
            this.searchTextBox2.Location = new System.Drawing.Point(30, 84);
            this.searchTextBox2.Name = "searchTextBox2";
            this.searchTextBox2.Size = new System.Drawing.Size(100, 26);
            this.searchTextBox2.TabIndex = 2;
            // 
            // searchButton2
            // 
            this.searchButton2.Location = new System.Drawing.Point(27, 139);
            this.searchButton2.Name = "searchButton2";
            this.searchButton2.Size = new System.Drawing.Size(103, 43);
            this.searchButton2.TabIndex = 1;
            this.searchButton2.Text = "Search";
            this.searchButton2.UseVisualStyleBackColor = true;
            this.searchButton2.Click += new System.EventHandler(this.searchButton2_Click);
            // 
            // ProductListBox
            // 
            this.ProductListBox.HideSelection = false;
            this.ProductListBox.Location = new System.Drawing.Point(225, 38);
            this.ProductListBox.Name = "ProductListBox";
            this.ProductListBox.Size = new System.Drawing.Size(262, 263);
            this.ProductListBox.TabIndex = 3;
            this.ProductListBox.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.listViewUOH);
            this.groupBox1.Controls.Add(this.searchTextBox3);
            this.groupBox1.Controls.Add(this.searchButtonUOH);
            this.groupBox1.Location = new System.Drawing.Point(53, 423);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 334);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search For Products By Units On Hand";
            // 
            // listViewUOH
            // 
            this.listViewUOH.HideSelection = false;
            this.listViewUOH.Location = new System.Drawing.Point(225, 38);
            this.listViewUOH.Name = "listViewUOH";
            this.listViewUOH.Size = new System.Drawing.Size(262, 263);
            this.listViewUOH.TabIndex = 3;
            this.listViewUOH.UseCompatibleStateImageBehavior = false;
            // 
            // searchTextBox3
            // 
            this.searchTextBox3.Location = new System.Drawing.Point(28, 188);
            this.searchTextBox3.Name = "searchTextBox3";
            this.searchTextBox3.Size = new System.Drawing.Size(100, 26);
            this.searchTextBox3.TabIndex = 2;
            // 
            // searchButtonUOH
            // 
            this.searchButtonUOH.Location = new System.Drawing.Point(28, 271);
            this.searchButtonUOH.Name = "searchButtonUOH";
            this.searchButtonUOH.Size = new System.Drawing.Size(103, 43);
            this.searchButtonUOH.TabIndex = 1;
            this.searchButtonUOH.Text = "Search";
            this.searchButtonUOH.UseVisualStyleBackColor = true;
            this.searchButtonUOH.Click += new System.EventHandler(this.searchButtonUOH_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Higher",
            "Lower"});
            this.comboBox1.Location = new System.Drawing.Point(28, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 28);
            this.comboBox1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.minTextBox);
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Controls.Add(this.maxTextBox);
            this.groupBox2.Controls.Add(this.searchButton4);
            this.groupBox2.Location = new System.Drawing.Point(601, 423);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(779, 334);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search For Products by Price";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(314, 38);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(422, 263);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(167, 98);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(109, 26);
            this.maxTextBox.TabIndex = 2;
            // 
            // searchButton4
            // 
            this.searchButton4.Location = new System.Drawing.Point(71, 155);
            this.searchButton4.Name = "searchButton4";
            this.searchButton4.Size = new System.Drawing.Size(143, 59);
            this.searchButton4.TabIndex = 1;
            this.searchButton4.Text = "Find Prices In Between";
            this.searchButton4.UseVisualStyleBackColor = true;
            this.searchButton4.Click += new System.EventHandler(this.searchButton4_Click);
            // 
            // minTextBox
            // 
            this.minTextBox.Location = new System.Drawing.Point(31, 98);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(100, 26);
            this.minTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Min \r\nPrice:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 40);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Max \r\nPrice:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 40);
            this.label3.TabIndex = 8;
            this.label3.Text = "Enter Product\r\nNumber Below:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 40);
            this.label4.TabIndex = 4;
            this.label4.Text = "Enter Product \r\nDescription Below:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 60);
            this.label5.TabIndex = 5;
            this.label5.Text = "Choose higher\r\nor lower and enter \r\nnumber to display:";
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(1017, 334);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(132, 56);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(1509, 838);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SearchProductsByDescription);
            this.Controls.Add(this.SearchProductByProductNumber);
            this.Name = "ProductForm";
            this.Text = "MaxWeaver-Lab-1";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.SearchProductByProductNumber.ResumeLayout(false);
            this.SearchProductByProductNumber.PerformLayout();
            this.SearchProductsByDescription.ResumeLayout(false);
            this.SearchProductsByDescription.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SearchProductByProductNumber;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label ProductNumber;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label UnitsOnHand;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.GroupBox SearchProductsByDescription;
        private System.Windows.Forms.TextBox searchTextBox2;
        private System.Windows.Forms.Button searchButton2;
        private System.Windows.Forms.ListView ProductListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listViewUOH;
        private System.Windows.Forms.TextBox searchTextBox3;
        private System.Windows.Forms.Button searchButtonUOH;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.Button searchButton4;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button closeButton;
    }
}

