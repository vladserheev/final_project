﻿namespace final_project
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BookAuthorInput = new System.Windows.Forms.TextBox();
            this.AddBookBtn = new System.Windows.Forms.Button();
            this.BookTitleInput = new System.Windows.Forms.TextBox();
            this.BooksListBox = new System.Windows.Forms.ListBox();
            this.ReadersBoxList = new System.Windows.Forms.ListBox();
            this.UserNameInput = new System.Windows.Forms.TextBox();
            this.UserPassInput = new System.Windows.Forms.TextBox();
            this.ChangeUserBtn = new System.Windows.Forms.Button();
            this.RemoveBook = new System.Windows.Forms.Button();
            this.UpdateBook = new System.Windows.Forms.Button();
            this.RemoveReader = new System.Windows.Forms.Button();
            this.AddReaderBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BookAuthorInput
            // 
            this.BookAuthorInput.Location = new System.Drawing.Point(27, 242);
            this.BookAuthorInput.Name = "BookAuthorInput";
            this.BookAuthorInput.Size = new System.Drawing.Size(138, 22);
            this.BookAuthorInput.TabIndex = 2;
            // 
            // AddBookBtn
            // 
            this.AddBookBtn.Location = new System.Drawing.Point(27, 286);
            this.AddBookBtn.Name = "AddBookBtn";
            this.AddBookBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBookBtn.TabIndex = 3;
            this.AddBookBtn.Text = "Додати";
            this.AddBookBtn.UseVisualStyleBackColor = true;
            this.AddBookBtn.Click += new System.EventHandler(this.AddBookBtn_Click);
            // 
            // BookTitleInput
            // 
            this.BookTitleInput.Location = new System.Drawing.Point(27, 202);
            this.BookTitleInput.Name = "BookTitleInput";
            this.BookTitleInput.Size = new System.Drawing.Size(138, 22);
            this.BookTitleInput.TabIndex = 4;
            // 
            // BooksListBox
            // 
            this.BooksListBox.FormattingEnabled = true;
            this.BooksListBox.ItemHeight = 16;
            this.BooksListBox.Location = new System.Drawing.Point(27, 35);
            this.BooksListBox.Name = "BooksListBox";
            this.BooksListBox.Size = new System.Drawing.Size(292, 132);
            this.BooksListBox.TabIndex = 7;
            this.BooksListBox.SelectedIndexChanged += new System.EventHandler(this.BooksListBox_SelectedIndexChanged);
            // 
            // ReadersBoxList
            // 
            this.ReadersBoxList.FormattingEnabled = true;
            this.ReadersBoxList.ItemHeight = 16;
            this.ReadersBoxList.Location = new System.Drawing.Point(396, 35);
            this.ReadersBoxList.Name = "ReadersBoxList";
            this.ReadersBoxList.Size = new System.Drawing.Size(283, 132);
            this.ReadersBoxList.TabIndex = 8;
            // 
            // UserNameInput
            // 
            this.UserNameInput.Location = new System.Drawing.Point(396, 202);
            this.UserNameInput.Name = "UserNameInput";
            this.UserNameInput.Size = new System.Drawing.Size(100, 22);
            this.UserNameInput.TabIndex = 9;
            this.UserNameInput.TextChanged += new System.EventHandler(this.ChangeUserNameInput_TextChanged);
            // 
            // UserPassInput
            // 
            this.UserPassInput.Location = new System.Drawing.Point(396, 243);
            this.UserPassInput.Name = "UserPassInput";
            this.UserPassInput.Size = new System.Drawing.Size(100, 22);
            this.UserPassInput.TabIndex = 10;
            this.UserPassInput.TextChanged += new System.EventHandler(this.ChangeUserPassInput_TextChanged);
            // 
            // ChangeUserBtn
            // 
            this.ChangeUserBtn.Location = new System.Drawing.Point(526, 242);
            this.ChangeUserBtn.Name = "ChangeUserBtn";
            this.ChangeUserBtn.Size = new System.Drawing.Size(100, 23);
            this.ChangeUserBtn.TabIndex = 11;
            this.ChangeUserBtn.Text = "Змінити";
            this.ChangeUserBtn.UseVisualStyleBackColor = true;
            this.ChangeUserBtn.Click += new System.EventHandler(this.ChangeUserBtn_Click);
            // 
            // RemoveBook
            // 
            this.RemoveBook.Location = new System.Drawing.Point(195, 201);
            this.RemoveBook.Name = "RemoveBook";
            this.RemoveBook.Size = new System.Drawing.Size(96, 23);
            this.RemoveBook.TabIndex = 12;
            this.RemoveBook.Text = "Видалити";
            this.RemoveBook.UseVisualStyleBackColor = true;
            this.RemoveBook.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateBook
            // 
            this.UpdateBook.Location = new System.Drawing.Point(195, 241);
            this.UpdateBook.Name = "UpdateBook";
            this.UpdateBook.Size = new System.Drawing.Size(96, 23);
            this.UpdateBook.TabIndex = 13;
            this.UpdateBook.Text = "Змінити";
            this.UpdateBook.UseVisualStyleBackColor = true;
            this.UpdateBook.Click += new System.EventHandler(this.UpdateBook_Click);
            // 
            // RemoveReader
            // 
            this.RemoveReader.Location = new System.Drawing.Point(526, 201);
            this.RemoveReader.Name = "RemoveReader";
            this.RemoveReader.Size = new System.Drawing.Size(100, 23);
            this.RemoveReader.TabIndex = 14;
            this.RemoveReader.Text = "Видалити";
            this.RemoveReader.UseVisualStyleBackColor = true;
            this.RemoveReader.Click += new System.EventHandler(this.RemoveReader_Click);
            // 
            // AddReaderBtn
            // 
            this.AddReaderBtn.Location = new System.Drawing.Point(396, 286);
            this.AddReaderBtn.Name = "AddReaderBtn";
            this.AddReaderBtn.Size = new System.Drawing.Size(75, 23);
            this.AddReaderBtn.TabIndex = 15;
            this.AddReaderBtn.Text = "Додати";
            this.AddReaderBtn.UseVisualStyleBackColor = true;
            this.AddReaderBtn.Click += new System.EventHandler(this.AddReaderBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.AddReaderBtn);
            this.Controls.Add(this.RemoveReader);
            this.Controls.Add(this.UpdateBook);
            this.Controls.Add(this.RemoveBook);
            this.Controls.Add(this.ChangeUserBtn);
            this.Controls.Add(this.UserPassInput);
            this.Controls.Add(this.UserNameInput);
            this.Controls.Add(this.ReadersBoxList);
            this.Controls.Add(this.BooksListBox);
            this.Controls.Add(this.BookTitleInput);
            this.Controls.Add(this.AddBookBtn);
            this.Controls.Add(this.BookAuthorInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox BookAuthorInput;
        private System.Windows.Forms.Button AddBookBtn;
        private System.Windows.Forms.TextBox BookTitleInput;
        private System.Windows.Forms.ListBox BooksListBox;
        private System.Windows.Forms.ListBox ReadersBoxList;
        private System.Windows.Forms.TextBox UserNameInput;
        private System.Windows.Forms.TextBox UserPassInput;
        private System.Windows.Forms.Button ChangeUserBtn;
        private System.Windows.Forms.Button RemoveBook;
        private System.Windows.Forms.Button UpdateBook;
        private System.Windows.Forms.Button RemoveReader;
        private System.Windows.Forms.Button AddReaderBtn;
    }
}
