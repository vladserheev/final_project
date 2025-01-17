﻿namespace final_project
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
            this.SearchInput = new System.Windows.Forms.TextBox();
            this.SerchBtn = new System.Windows.Forms.Button();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ShowAllAvailableBooks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowAllAvailableBooks
            // 
            ShowAllAvailableBooks.Location = new System.Drawing.Point(45, 112);
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
            this.BooksListBox.Location = new System.Drawing.Point(45, 207);
            this.BooksListBox.Name = "BooksListBox";
            this.BooksListBox.Size = new System.Drawing.Size(308, 116);
            this.BooksListBox.TabIndex = 0;
            // 
            // ShowMyBooks
            // 
            this.ShowMyBooks.Location = new System.Drawing.Point(182, 112);
            this.ShowMyBooks.Name = "ShowMyBooks";
            this.ShowMyBooks.Size = new System.Drawing.Size(98, 23);
            this.ShowMyBooks.TabIndex = 2;
            this.ShowMyBooks.Text = "Мої книги";
            this.ShowMyBooks.UseVisualStyleBackColor = true;
            this.ShowMyBooks.Click += new System.EventHandler(this.ShowMyBooks_Click);
            // 
            // ReturnBook
            // 
            this.ReturnBook.Location = new System.Drawing.Point(182, 351);
            this.ReturnBook.Name = "ReturnBook";
            this.ReturnBook.Size = new System.Drawing.Size(98, 23);
            this.ReturnBook.TabIndex = 3;
            this.ReturnBook.Text = "Повернути ";
            this.ReturnBook.UseVisualStyleBackColor = true;
            this.ReturnBook.Click += new System.EventHandler(this.ReturnBook_Click);
            // 
            // BorrowBook
            // 
            this.BorrowBook.Location = new System.Drawing.Point(45, 351);
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
            this.UserPassL.Location = new System.Drawing.Point(42, 149);
            this.UserPassL.Name = "UserPassL";
            this.UserPassL.Size = new System.Drawing.Size(66, 16);
            this.UserPassL.TabIndex = 5;
            this.UserPassL.Text = "Всі книги";
            // 
            // UserNameL
            // 
            this.UserNameL.AutoSize = true;
            this.UserNameL.Location = new System.Drawing.Point(136, 71);
            this.UserNameL.Name = "UserNameL";
            this.UserNameL.Size = new System.Drawing.Size(44, 16);
            this.UserNameL.TabIndex = 6;
            this.UserNameL.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Користувач:";
            // 
            // SearchInput
            // 
            this.SearchInput.Location = new System.Drawing.Point(45, 179);
            this.SearchInput.Name = "SearchInput";
            this.SearchInput.Size = new System.Drawing.Size(100, 22);
            this.SearchInput.TabIndex = 8;
            // 
            // SerchBtn
            // 
            this.SerchBtn.Location = new System.Drawing.Point(161, 178);
            this.SerchBtn.Name = "SerchBtn";
            this.SerchBtn.Size = new System.Drawing.Size(75, 23);
            this.SerchBtn.TabIndex = 9;
            this.SerchBtn.Text = "Пошук";
            this.SerchBtn.UseVisualStyleBackColor = true;
            this.SerchBtn.Click += new System.EventHandler(this.SerchBtn_Click);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Location = new System.Drawing.Point(242, 24);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(75, 31);
            this.LogOutBtn.TabIndex = 10;
            this.LogOutBtn.Text = "Вийти";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(42, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Сторінка користувача";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.SerchBtn);
            this.Controls.Add(this.SearchInput);
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
        private System.Windows.Forms.TextBox SearchInput;
        private System.Windows.Forms.Button SerchBtn;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Label label2;
    }
}