namespace oopProject2016
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.add_book_btn = new System.Windows.Forms.Button();
            this.remove_book_btn = new System.Windows.Forms.Button();
            this.add_user_btn = new System.Windows.Forms.Button();
            this.remove_user_btn = new System.Windows.Forms.Button();
            this.search_book_btn = new System.Windows.Forms.Button();
            this.search_user_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.display_users_btn = new System.Windows.Forms.Button();
            this.display_books_btn = new System.Windows.Forms.Button();
            this.show_grd = new System.Windows.Forms.DataGridView();
            this.book_return_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.show_grd)).BeginInit();
            this.SuspendLayout();
            // 
            // add_book_btn
            // 
            this.add_book_btn.Location = new System.Drawing.Point(15, 66);
            this.add_book_btn.Margin = new System.Windows.Forms.Padding(4);
            this.add_book_btn.Name = "add_book_btn";
            this.add_book_btn.Size = new System.Drawing.Size(145, 28);
            this.add_book_btn.TabIndex = 0;
            this.add_book_btn.Text = "Add Book";
            this.add_book_btn.UseVisualStyleBackColor = true;
            this.add_book_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // remove_book_btn
            // 
            this.remove_book_btn.Location = new System.Drawing.Point(15, 121);
            this.remove_book_btn.Margin = new System.Windows.Forms.Padding(4);
            this.remove_book_btn.Name = "remove_book_btn";
            this.remove_book_btn.Size = new System.Drawing.Size(145, 28);
            this.remove_book_btn.TabIndex = 1;
            this.remove_book_btn.Text = "Remove Book";
            this.remove_book_btn.UseVisualStyleBackColor = true;
            this.remove_book_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // add_user_btn
            // 
            this.add_user_btn.Location = new System.Drawing.Point(15, 176);
            this.add_user_btn.Margin = new System.Windows.Forms.Padding(4);
            this.add_user_btn.Name = "add_user_btn";
            this.add_user_btn.Size = new System.Drawing.Size(145, 28);
            this.add_user_btn.TabIndex = 2;
            this.add_user_btn.Text = "Add User";
            this.add_user_btn.UseVisualStyleBackColor = true;
            this.add_user_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // remove_user_btn
            // 
            this.remove_user_btn.Location = new System.Drawing.Point(188, 176);
            this.remove_user_btn.Margin = new System.Windows.Forms.Padding(4);
            this.remove_user_btn.Name = "remove_user_btn";
            this.remove_user_btn.Size = new System.Drawing.Size(145, 28);
            this.remove_user_btn.TabIndex = 3;
            this.remove_user_btn.Text = "Remove User";
            this.remove_user_btn.UseVisualStyleBackColor = true;
            this.remove_user_btn.Click += new System.EventHandler(this.button4_Click);
            // 
            // search_book_btn
            // 
            this.search_book_btn.Location = new System.Drawing.Point(188, 66);
            this.search_book_btn.Margin = new System.Windows.Forms.Padding(4);
            this.search_book_btn.Name = "search_book_btn";
            this.search_book_btn.Size = new System.Drawing.Size(145, 28);
            this.search_book_btn.TabIndex = 4;
            this.search_book_btn.Text = "search_user";
            this.search_book_btn.UseVisualStyleBackColor = true;
            this.search_book_btn.Click += new System.EventHandler(this.button5_Click);
            // 
            // search_user_btn
            // 
            this.search_user_btn.Location = new System.Drawing.Point(188, 121);
            this.search_user_btn.Margin = new System.Windows.Forms.Padding(4);
            this.search_user_btn.Name = "search_user_btn";
            this.search_user_btn.Size = new System.Drawing.Size(145, 28);
            this.search_user_btn.TabIndex = 5;
            this.search_user_btn.Text = "Search Book";
            this.search_user_btn.UseVisualStyleBackColor = true;
            this.search_user_btn.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(65, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "Adminstrator";
            // 
            // display_users_btn
            // 
            this.display_users_btn.Location = new System.Drawing.Point(13, 231);
            this.display_users_btn.Margin = new System.Windows.Forms.Padding(4);
            this.display_users_btn.Name = "display_users_btn";
            this.display_users_btn.Size = new System.Drawing.Size(148, 28);
            this.display_users_btn.TabIndex = 8;
            this.display_users_btn.Text = "Display All Users";
            this.display_users_btn.UseVisualStyleBackColor = true;
            this.display_users_btn.Click += new System.EventHandler(this.display_users_btn_Click);
            // 
            // display_books_btn
            // 
            this.display_books_btn.Location = new System.Drawing.Point(188, 231);
            this.display_books_btn.Margin = new System.Windows.Forms.Padding(4);
            this.display_books_btn.Name = "display_books_btn";
            this.display_books_btn.Size = new System.Drawing.Size(145, 28);
            this.display_books_btn.TabIndex = 9;
            this.display_books_btn.Text = "Display All Books";
            this.display_books_btn.UseVisualStyleBackColor = true;
            this.display_books_btn.Click += new System.EventHandler(this.display_books_btn_Click);
            // 
            // show_grd
            // 
            this.show_grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.show_grd.Location = new System.Drawing.Point(341, 13);
            this.show_grd.Margin = new System.Windows.Forms.Padding(4);
            this.show_grd.Name = "show_grd";
            this.show_grd.Size = new System.Drawing.Size(634, 339);
            this.show_grd.TabIndex = 10;
            this.show_grd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.show_grd_CellContentClick);
            // 
            // book_return_btn
            // 
            this.book_return_btn.Location = new System.Drawing.Point(13, 286);
            this.book_return_btn.Margin = new System.Windows.Forms.Padding(4);
            this.book_return_btn.Name = "book_return_btn";
            this.book_return_btn.Size = new System.Drawing.Size(148, 27);
            this.book_return_btn.TabIndex = 12;
            this.book_return_btn.Text = "Book Return";
            this.book_return_btn.UseVisualStyleBackColor = true;
            this.book_return_btn.Click += new System.EventHandler(this.book_return_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 320);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "Due Date";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(188, 286);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 27);
            this.button3.TabIndex = 16;
            this.button3.Text = "Show Requests";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(988, 370);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.book_return_btn);
            this.Controls.Add(this.show_grd);
            this.Controls.Add(this.display_books_btn);
            this.Controls.Add(this.display_users_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_user_btn);
            this.Controls.Add(this.search_book_btn);
            this.Controls.Add(this.remove_user_btn);
            this.Controls.Add(this.add_user_btn);
            this.Controls.Add(this.remove_book_btn);
            this.Controls.Add(this.add_book_btn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.show_grd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_book_btn;
        private System.Windows.Forms.Button remove_book_btn;
        private System.Windows.Forms.Button add_user_btn;
        private System.Windows.Forms.Button remove_user_btn;
        private System.Windows.Forms.Button search_book_btn;
        private System.Windows.Forms.Button search_user_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button display_users_btn;
        private System.Windows.Forms.Button display_books_btn;
        private System.Windows.Forms.DataGridView show_grd;
        private System.Windows.Forms.Button book_return_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}