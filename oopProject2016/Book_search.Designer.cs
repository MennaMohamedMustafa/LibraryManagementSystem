namespace oopProject2016
{
    partial class Book_search
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.show_data_btn = new System.Windows.Forms.Button();
            this.show_data_book_grd = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.show_data_book_grd)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(377, 37);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 87);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // show_data_btn
            // 
            this.show_data_btn.Location = new System.Drawing.Point(377, 137);
            this.show_data_btn.Margin = new System.Windows.Forms.Padding(4);
            this.show_data_btn.Name = "show_data_btn";
            this.show_data_btn.Size = new System.Drawing.Size(215, 27);
            this.show_data_btn.TabIndex = 2;
            this.show_data_btn.Text = "Show Data";
            this.show_data_btn.UseVisualStyleBackColor = true;
            this.show_data_btn.Click += new System.EventHandler(this.show_data_btn_Click);
            // 
            // show_data_book_grd
            // 
            this.show_data_book_grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.show_data_book_grd.Location = new System.Drawing.Point(13, 206);
            this.show_data_book_grd.Margin = new System.Windows.Forms.Padding(4);
            this.show_data_book_grd.Name = "show_data_book_grd";
            this.show_data_book_grd.Size = new System.Drawing.Size(943, 185);
            this.show_data_book_grd.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 47);
            this.button2.TabIndex = 4;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Book_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 404);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.show_data_book_grd);
            this.Controls.Add(this.show_data_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Book_search";
            this.Text = "Book_search";
            this.Load += new System.EventHandler(this.Book_search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.show_data_book_grd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button show_data_btn;
        private System.Windows.Forms.DataGridView show_data_book_grd;
        private System.Windows.Forms.Button button2;
    }
}