namespace oopProject2016
{
    partial class user_search_display
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
            this.search_btn = new System.Windows.Forms.Button();
            this.show_data_btn = new System.Windows.Forms.Button();
            this.show_user_data_grd = new System.Windows.Forms.DataGridView();
            this.user_search_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.show_user_data_grd)).BeginInit();
            this.SuspendLayout();
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(293, 71);
            this.search_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(100, 28);
            this.search_btn.TabIndex = 0;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // show_data_btn
            // 
            this.show_data_btn.Location = new System.Drawing.Point(293, 118);
            this.show_data_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.show_data_btn.Name = "show_data_btn";
            this.show_data_btn.Size = new System.Drawing.Size(100, 28);
            this.show_data_btn.TabIndex = 1;
            this.show_data_btn.Text = "Show Data";
            this.show_data_btn.UseVisualStyleBackColor = true;
            this.show_data_btn.Click += new System.EventHandler(this.show_data_btn_Click);
            // 
            // show_user_data_grd
            // 
            this.show_user_data_grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.show_user_data_grd.Location = new System.Drawing.Point(39, 167);
            this.show_user_data_grd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.show_user_data_grd.Name = "show_user_data_grd";
            this.show_user_data_grd.Size = new System.Drawing.Size(635, 167);
            this.show_user_data_grd.TabIndex = 2;
            // 
            // user_search_txt
            // 
            this.user_search_txt.Location = new System.Drawing.Point(277, 28);
            this.user_search_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.user_search_txt.Name = "user_search_txt";
            this.user_search_txt.Size = new System.Drawing.Size(132, 22);
            this.user_search_txt.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // user_search_display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 375);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.user_search_txt);
            this.Controls.Add(this.show_user_data_grd);
            this.Controls.Add(this.show_data_btn);
            this.Controls.Add(this.search_btn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "user_search_display";
            this.Text = "user_search_display";
            ((System.ComponentModel.ISupportInitialize)(this.show_user_data_grd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button show_data_btn;
        private System.Windows.Forms.DataGridView show_user_data_grd;
        private System.Windows.Forms.TextBox user_search_txt;
        private System.Windows.Forms.Button button1;
    }
}