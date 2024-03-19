namespace Netflix
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FilmType = new ComboBox();
            Category = new ComboBox();
            AgeRating = new ComboBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // FilmType
            // 
            FilmType.FormattingEnabled = true;
            FilmType.Items.AddRange(new object[] { "Movie", "Cartoon" });
            FilmType.Location = new Point(169, 80);
            FilmType.Name = "FilmType";
            FilmType.Size = new Size(121, 23);
            FilmType.TabIndex = 0;
            // 
            // Category
            // 
            Category.FormattingEnabled = true;
            Category.Items.AddRange(new object[] { "Kids", "Comedy", "Horror", "Action" });
            Category.Location = new Point(321, 80);
            Category.Name = "Category";
            Category.Size = new Size(121, 23);
            Category.TabIndex = 1;
            // 
            // AgeRating
            // 
            AgeRating.FormattingEnabled = true;
            AgeRating.Items.AddRange(new object[] { "6", "12", "18", "" });
            AgeRating.Location = new Point(474, 80);
            AgeRating.Name = "AgeRating";
            AgeRating.Size = new Size(121, 23);
            AgeRating.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(169, 118);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(426, 228);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // button1
            // 
            button1.Location = new Point(344, 363);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(344, 392);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(254, 34);
            label1.Name = "label1";
            label1.Size = new Size(252, 20);
            label1.TabIndex = 6;
            label1.Text = "Double Click a cell to go to booking.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(AgeRating);
            Controls.Add(Category);
            Controls.Add(FilmType);
            Name = "Form1";
            Text = "Netflix";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox FilmType;
        private ComboBox Category;
        private ComboBox AgeRating;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Label label1;
    }
}