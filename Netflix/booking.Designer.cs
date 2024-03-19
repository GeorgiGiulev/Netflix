namespace Netflix
{
    partial class booking
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
            name = new TextBox();
            cvv = new TextBox();
            cardNumber = new TextBox();
            expiryDate = new TextBox();
            button1 = new Button();
            categoryBox = new TextBox();
            filmTypeBox = new TextBox();
            ageRatingBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // name
            // 
            name.AccessibleName = "name";
            name.Location = new Point(102, 109);
            name.Name = "name";
            name.PlaceholderText = "Name";
            name.Size = new Size(100, 23);
            name.TabIndex = 0;
            // 
            // cvv
            // 
            cvv.AccessibleName = "cvv";
            cvv.Location = new Point(595, 109);
            cvv.Name = "cvv";
            cvv.PlaceholderText = "CVV";
            cvv.Size = new Size(100, 23);
            cvv.TabIndex = 1;
            // 
            // cardNumber
            // 
            cardNumber.AccessibleName = "cardNumber";
            cardNumber.Location = new Point(285, 109);
            cardNumber.Name = "cardNumber";
            cardNumber.PlaceholderText = "Card Number";
            cardNumber.Size = new Size(100, 23);
            cardNumber.TabIndex = 2;
            // 
            // expiryDate
            // 
            expiryDate.AccessibleName = "expiryDate";
            expiryDate.Location = new Point(444, 109);
            expiryDate.Name = "expiryDate";
            expiryDate.PlaceholderText = "Expiry Date";
            expiryDate.Size = new Size(100, 23);
            expiryDate.TabIndex = 3;
            // 
            // button1
            // 
            button1.AccessibleName = "buyButton";
            button1.Location = new Point(349, 290);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "BUY";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // categoryBox
            // 
            categoryBox.AccessibleName = "name";
            categoryBox.Location = new Point(349, 40);
            categoryBox.Name = "categoryBox";
            categoryBox.PlaceholderText = "Category";
            categoryBox.Size = new Size(100, 23);
            categoryBox.TabIndex = 5;
            categoryBox.TextChanged += categoryBox_TextChanged;
            // 
            // filmTypeBox
            // 
            filmTypeBox.AccessibleName = "name";
            filmTypeBox.Location = new Point(165, 40);
            filmTypeBox.Name = "filmTypeBox";
            filmTypeBox.PlaceholderText = "Film Type";
            filmTypeBox.Size = new Size(100, 23);
            filmTypeBox.TabIndex = 6;
            filmTypeBox.TextChanged += filmTypeBox_TextChanged;
            // 
            // ageRatingBox
            // 
            ageRatingBox.AccessibleName = "name";
            ageRatingBox.Location = new Point(505, 40);
            ageRatingBox.Name = "ageRatingBox";
            ageRatingBox.PlaceholderText = "Age Rating";
            ageRatingBox.Size = new Size(100, 23);
            ageRatingBox.TabIndex = 7;
            ageRatingBox.TextChanged += ageRatingBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(182, 20);
            label1.Name = "label1";
            label1.Size = new Size(58, 17);
            label1.TabIndex = 8;
            label1.Text = "FilmType";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(363, 20);
            label2.Name = "label2";
            label2.Size = new Size(61, 17);
            label2.TabIndex = 9;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(519, 20);
            label3.Name = "label3";
            label3.Size = new Size(68, 17);
            label3.TabIndex = 10;
            label3.Text = "AgeRating";
            // 
            // booking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ageRatingBox);
            Controls.Add(filmTypeBox);
            Controls.Add(categoryBox);
            Controls.Add(button1);
            Controls.Add(expiryDate);
            Controls.Add(cardNumber);
            Controls.Add(cvv);
            Controls.Add(name);
            Name = "booking";
            Text = "booking";
            Load += booking_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox name;
        private TextBox cvv;
        private TextBox cardNumber;
        private TextBox expiryDate;
        private Button button1;
        private TextBox categoryBox;
        private TextBox filmTypeBox;
        private TextBox ageRatingBox;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}