namespace final_project
{
    partial class UserForm
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
            System.Windows.Forms.Button ShowAllAvailableBooks;
            this.BooksListBox = new System.Windows.Forms.ListBox();
            this.ShowMyBooks = new System.Windows.Forms.Button();
            this.ReturnBook = new System.Windows.Forms.Button();
            this.BorrowBook = new System.Windows.Forms.Button();
            this.UserPassL = new System.Windows.Forms.Label();
            this.UserNameL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ShowAllAvailableBooks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowAllAvailableBooks
            // 
            ShowAllAvailableBooks.Location = new System.Drawing.Point(41, 60);
            ShowAllAvailableBooks.Name = "ShowAllAvailableBooks";
            ShowAllAvailableBooks.Size = new System.Drawing.Size(109, 23);
            ShowAllAvailableBooks.TabIndex = 1;
            ShowAllAvailableBooks.Text = "Всі книги";
            ShowAllAvailableBooks.UseVisualStyleBackColor = true;
            ShowAllAvailableBooks.Click += new System.EventHandler(this.ShowAllAvailableBooks_Click);
            // 
            // BooksListBox
            // 
            this.BooksListBox.FormattingEnabled = true;
            this.BooksListBox.ItemHeight = 16;
            this.BooksListBox.Location = new System.Drawing.Point(41, 118);
            this.BooksListBox.Name = "BooksListBox";
            this.BooksListBox.Size = new System.Drawing.Size(308, 116);
            this.BooksListBox.TabIndex = 0;
            // 
            // ShowMyBooks
            // 
            this.ShowMyBooks.Location = new System.Drawing.Point(178, 60);
            this.ShowMyBooks.Name = "ShowMyBooks";
            this.ShowMyBooks.Size = new System.Drawing.Size(98, 23);
            this.ShowMyBooks.TabIndex = 2;
            this.ShowMyBooks.Text = "Мої книги";
            this.ShowMyBooks.UseVisualStyleBackColor = true;
            this.ShowMyBooks.Click += new System.EventHandler(this.ShowMyBooks_Click);
            // 
            // ReturnBook
            // 
            this.ReturnBook.Location = new System.Drawing.Point(178, 262);
            this.ReturnBook.Name = "ReturnBook";
            this.ReturnBook.Size = new System.Drawing.Size(98, 23);
            this.ReturnBook.TabIndex = 3;
            this.ReturnBook.Text = "Повернути ";
            this.ReturnBook.UseVisualStyleBackColor = true;
            this.ReturnBook.Click += new System.EventHandler(this.ReturnBook_Click);
            // 
            // BorrowBook
            // 
            this.BorrowBook.Location = new System.Drawing.Point(41, 262);
            this.BorrowBook.Name = "BorrowBook";
            this.BorrowBook.Size = new System.Drawing.Size(109, 23);
            this.BorrowBook.TabIndex = 4;
            this.BorrowBook.Text = "Взяти";
            this.BorrowBook.UseVisualStyleBackColor = true;
            this.BorrowBook.Click += new System.EventHandler(this.BorrowBook_Click);
            // 
            // UserPassL
            // 
            this.UserPassL.AutoSize = true;
            this.UserPassL.Location = new System.Drawing.Point(38, 99);
            this.UserPassL.Name = "UserPassL";
            this.UserPassL.Size = new System.Drawing.Size(66, 16);
            this.UserPassL.TabIndex = 5;
            this.UserPassL.Text = "Всі книги";
            // 
            // UserNameL
            // 
            this.UserNameL.AutoSize = true;
            this.UserNameL.Location = new System.Drawing.Point(135, 18);
            this.UserNameL.Name = "UserNameL";
            this.UserNameL.Size = new System.Drawing.Size(44, 16);
            this.UserNameL.TabIndex = 6;
            this.UserNameL.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Користувач:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserNameL);
            this.Controls.Add(this.UserPassL);
            this.Controls.Add(this.BorrowBook);
            this.Controls.Add(this.ReturnBook);
            this.Controls.Add(this.ShowMyBooks);
            this.Controls.Add(ShowAllAvailableBooks);
            this.Controls.Add(this.BooksListBox);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox BooksListBox;
        private System.Windows.Forms.Button ShowMyBooks;
        private System.Windows.Forms.Button ReturnBook;
        private System.Windows.Forms.Button BorrowBook;
        private System.Windows.Forms.Label UserPassL;
        private System.Windows.Forms.Label UserNameL;
        private System.Windows.Forms.Label label1;
    }
}