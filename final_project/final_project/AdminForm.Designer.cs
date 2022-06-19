namespace final_project
{
    partial class AdminForm
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
            this.UsresListBoxStatus = new System.Windows.Forms.Label();
            this.BooksListBoxStatusL = new System.Windows.Forms.Label();
            this.ShowAllUsers = new System.Windows.Forms.Button();
            this.ShowAllbooks = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IsAdminCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BookAuthorInput
            // 
            this.BookAuthorInput.Location = new System.Drawing.Point(25, 345);
            this.BookAuthorInput.Name = "BookAuthorInput";
            this.BookAuthorInput.Size = new System.Drawing.Size(138, 22);
            this.BookAuthorInput.TabIndex = 2;
            this.BookAuthorInput.Text = "Автор";
            // 
            // AddBookBtn
            // 
            this.AddBookBtn.Location = new System.Drawing.Point(25, 389);
            this.AddBookBtn.Name = "AddBookBtn";
            this.AddBookBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBookBtn.TabIndex = 3;
            this.AddBookBtn.Text = "Додати";
            this.AddBookBtn.UseVisualStyleBackColor = true;
            this.AddBookBtn.Click += new System.EventHandler(this.AddBookBtn_Click);
            // 
            // BookTitleInput
            // 
            this.BookTitleInput.Location = new System.Drawing.Point(25, 305);
            this.BookTitleInput.Name = "BookTitleInput";
            this.BookTitleInput.Size = new System.Drawing.Size(138, 22);
            this.BookTitleInput.TabIndex = 4;
            this.BookTitleInput.Text = "Назва";
            // 
            // BooksListBox
            // 
            this.BooksListBox.FormattingEnabled = true;
            this.BooksListBox.ItemHeight = 16;
            this.BooksListBox.Location = new System.Drawing.Point(25, 138);
            this.BooksListBox.Name = "BooksListBox";
            this.BooksListBox.Size = new System.Drawing.Size(292, 132);
            this.BooksListBox.TabIndex = 7;
            this.BooksListBox.SelectedIndexChanged += new System.EventHandler(this.BooksListBox_SelectedIndexChanged);
            // 
            // ReadersBoxList
            // 
            this.ReadersBoxList.FormattingEnabled = true;
            this.ReadersBoxList.ItemHeight = 16;
            this.ReadersBoxList.Location = new System.Drawing.Point(395, 138);
            this.ReadersBoxList.Name = "ReadersBoxList";
            this.ReadersBoxList.Size = new System.Drawing.Size(283, 132);
            this.ReadersBoxList.TabIndex = 8;
            // 
            // UserNameInput
            // 
            this.UserNameInput.Location = new System.Drawing.Point(395, 305);
            this.UserNameInput.Name = "UserNameInput";
            this.UserNameInput.Size = new System.Drawing.Size(100, 22);
            this.UserNameInput.TabIndex = 9;
            this.UserNameInput.Text = "Ім\'я";
            // 
            // UserPassInput
            // 
            this.UserPassInput.Location = new System.Drawing.Point(395, 346);
            this.UserPassInput.Name = "UserPassInput";
            this.UserPassInput.Size = new System.Drawing.Size(100, 22);
            this.UserPassInput.TabIndex = 10;
            this.UserPassInput.Text = "Пароль";
            // 
            // ChangeUserBtn
            // 
            this.ChangeUserBtn.Location = new System.Drawing.Point(525, 345);
            this.ChangeUserBtn.Name = "ChangeUserBtn";
            this.ChangeUserBtn.Size = new System.Drawing.Size(100, 23);
            this.ChangeUserBtn.TabIndex = 11;
            this.ChangeUserBtn.Text = "Змінити";
            this.ChangeUserBtn.UseVisualStyleBackColor = true;
            this.ChangeUserBtn.Click += new System.EventHandler(this.ChangeUserBtn_Click);
            // 
            // RemoveBook
            // 
            this.RemoveBook.Location = new System.Drawing.Point(193, 304);
            this.RemoveBook.Name = "RemoveBook";
            this.RemoveBook.Size = new System.Drawing.Size(96, 23);
            this.RemoveBook.TabIndex = 12;
            this.RemoveBook.Text = "Видалити";
            this.RemoveBook.UseVisualStyleBackColor = true;
            this.RemoveBook.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateBook
            // 
            this.UpdateBook.Location = new System.Drawing.Point(193, 344);
            this.UpdateBook.Name = "UpdateBook";
            this.UpdateBook.Size = new System.Drawing.Size(96, 23);
            this.UpdateBook.TabIndex = 13;
            this.UpdateBook.Text = "Змінити";
            this.UpdateBook.UseVisualStyleBackColor = true;
            this.UpdateBook.Click += new System.EventHandler(this.UpdateBook_Click);
            // 
            // RemoveReader
            // 
            this.RemoveReader.Location = new System.Drawing.Point(525, 304);
            this.RemoveReader.Name = "RemoveReader";
            this.RemoveReader.Size = new System.Drawing.Size(100, 23);
            this.RemoveReader.TabIndex = 14;
            this.RemoveReader.Text = "Видалити";
            this.RemoveReader.UseVisualStyleBackColor = true;
            this.RemoveReader.Click += new System.EventHandler(this.RemoveReader_Click);
            // 
            // AddReaderBtn
            // 
            this.AddReaderBtn.Location = new System.Drawing.Point(395, 425);
            this.AddReaderBtn.Name = "AddReaderBtn";
            this.AddReaderBtn.Size = new System.Drawing.Size(75, 23);
            this.AddReaderBtn.TabIndex = 15;
            this.AddReaderBtn.Text = "Додати";
            this.AddReaderBtn.UseVisualStyleBackColor = true;
            this.AddReaderBtn.Click += new System.EventHandler(this.AddReaderBtn_Click);
            // 
            // UsresListBoxStatus
            // 
            this.UsresListBoxStatus.AutoSize = true;
            this.UsresListBoxStatus.Location = new System.Drawing.Point(392, 119);
            this.UsresListBoxStatus.Name = "UsresListBoxStatus";
            this.UsresListBoxStatus.Size = new System.Drawing.Size(109, 16);
            this.UsresListBoxStatus.TabIndex = 16;
            this.UsresListBoxStatus.Text = "Всі користувачі";
            // 
            // BooksListBoxStatusL
            // 
            this.BooksListBoxStatusL.AutoSize = true;
            this.BooksListBoxStatusL.Location = new System.Drawing.Point(22, 119);
            this.BooksListBoxStatusL.Name = "BooksListBoxStatusL";
            this.BooksListBoxStatusL.Size = new System.Drawing.Size(66, 16);
            this.BooksListBoxStatusL.TabIndex = 17;
            this.BooksListBoxStatusL.Text = "Всі книги";
            // 
            // ShowAllUsers
            // 
            this.ShowAllUsers.Location = new System.Drawing.Point(395, 82);
            this.ShowAllUsers.Name = "ShowAllUsers";
            this.ShowAllUsers.Size = new System.Drawing.Size(75, 23);
            this.ShowAllUsers.TabIndex = 18;
            this.ShowAllUsers.Text = "Всі";
            this.ShowAllUsers.UseVisualStyleBackColor = true;
            // 
            // ShowAllbooks
            // 
            this.ShowAllbooks.Location = new System.Drawing.Point(25, 82);
            this.ShowAllbooks.Name = "ShowAllbooks";
            this.ShowAllbooks.Size = new System.Drawing.Size(75, 23);
            this.ShowAllbooks.TabIndex = 19;
            this.ShowAllbooks.Text = "Всі";
            this.ShowAllbooks.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(392, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Користувачі";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(22, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Книги";
            // 
            // IsAdminCheckBox
            // 
            this.IsAdminCheckBox.AutoSize = true;
            this.IsAdminCheckBox.Location = new System.Drawing.Point(395, 374);
            this.IsAdminCheckBox.Name = "IsAdminCheckBox";
            this.IsAdminCheckBox.Size = new System.Drawing.Size(66, 20);
            this.IsAdminCheckBox.TabIndex = 22;
            this.IsAdminCheckBox.Text = "Адмін";
            this.IsAdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Сторінка адміна";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IsAdminCheckBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ShowAllbooks);
            this.Controls.Add(this.ShowAllUsers);
            this.Controls.Add(this.BooksListBoxStatusL);
            this.Controls.Add(this.UsresListBoxStatus);
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
            this.Name = "AdminForm";
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
        private System.Windows.Forms.Label UsresListBoxStatus;
        private System.Windows.Forms.Label BooksListBoxStatusL;
        private System.Windows.Forms.Button ShowAllUsers;
        private System.Windows.Forms.Button ShowAllbooks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox IsAdminCheckBox;
        private System.Windows.Forms.Label label1;
    }
}

