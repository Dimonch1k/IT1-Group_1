namespace Team_1_Library_Create
{
    partial class Library
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.author_textBox = new System.Windows.Forms.TextBox();
            this.name_textBox = new System.Windows.Forms.MaskedTextBox();
            this.year_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(147, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Library";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(451, 480);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(451, 348);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 38);
            this.button3.TabIndex = 4;
            this.button3.Text = "Search by name";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(451, 236);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 38);
            this.button4.TabIndex = 5;
            this.button4.Text = "Sort by name";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Author,
            this.Year});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(49, 213);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(296, 287);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 98;
            // 
            // Author
            // 
            this.Author.Text = "Author";
            this.Author.Width = 93;
            // 
            // Year
            // 
            this.Year.Text = "Year";
            this.Year.Width = 118;
            // 
            // author_textBox
            // 
            this.author_textBox.Location = new System.Drawing.Point(451, 65);
            this.author_textBox.Name = "author_textBox";
            this.author_textBox.Size = new System.Drawing.Size(159, 20);
            this.author_textBox.TabIndex = 7;
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(451, 27);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(159, 20);
            this.name_textBox.TabIndex = 8;
            // 
            // year_textBox
            // 
            this.year_textBox.Location = new System.Drawing.Point(451, 104);
            this.year_textBox.Name = "year_textBox";
            this.year_textBox.Size = new System.Drawing.Size(159, 20);
            this.year_textBox.TabIndex = 9;
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 665);
            this.Controls.Add(this.year_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.author_textBox);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Library";
            this.Text = "Library";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader Year;
        private System.Windows.Forms.TextBox author_textBox;
        private System.Windows.Forms.MaskedTextBox name_textBox;
        private System.Windows.Forms.TextBox year_textBox;
    }
}