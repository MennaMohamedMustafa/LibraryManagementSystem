namespace oopProject2016
{
    partial class Return_Book
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
            this.label2 = new System.Windows.Forms.Label();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.isbn_txt = new System.Windows.Forms.TextBox();
            this.return_book_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kozuka Mincho Pr6N H", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kozuka Mincho Pr6N H", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "ISBN";
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(189, 55);
            this.id_txt.Margin = new System.Windows.Forms.Padding(4);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(132, 22);
            this.id_txt.TabIndex = 2;
            // 
            // isbn_txt
            // 
            this.isbn_txt.Location = new System.Drawing.Point(189, 112);
            this.isbn_txt.Margin = new System.Windows.Forms.Padding(4);
            this.isbn_txt.Name = "isbn_txt";
            this.isbn_txt.Size = new System.Drawing.Size(132, 22);
            this.isbn_txt.TabIndex = 3;
            // 
            // return_book_btn
            // 
            this.return_book_btn.Location = new System.Drawing.Point(64, 178);
            this.return_book_btn.Margin = new System.Windows.Forms.Padding(4);
            this.return_book_btn.Name = "return_book_btn";
            this.return_book_btn.Size = new System.Drawing.Size(123, 47);
            this.return_book_btn.TabIndex = 4;
            this.return_book_btn.Text = "Return Book";
            this.return_book_btn.UseVisualStyleBackColor = true;
            this.return_book_btn.Click += new System.EventHandler(this.return_book_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Return_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 267);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.return_book_btn);
            this.Controls.Add(this.isbn_txt);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Return_Book";
            this.Text = "Return_Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.TextBox isbn_txt;
        private System.Windows.Forms.Button return_book_btn;
        private System.Windows.Forms.Button button1;
    }
}