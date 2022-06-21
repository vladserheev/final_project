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
            this.ReadersListBox = new System.Windows.Forms.ListBox();
            this.UserNameInput = new System.Windows.Forms.TextBox();
            this.UserPassInput = new System.Windows.Forms.TextBox();
            this.ChangeUserBtn = new System.Windows.Forms.Button();
            this.RemoveBookBtn = new System.Windows.Forms.Button();
            this.ChangeBookBtn = new System.Windows.Forms.Button();
            this.RemoveReaderBtn = new System.Windows.Forms.Button();
            this.AddReaderBtn = new System.Windows.Forms.Button();
            this.UsresListBoxStatus = new System.Windows.Forms.Label();
            this.BooksListBoxStatusL = new System.Windows.Forms.Label();
            this.ShowAllUsers = new System.Windows.Forms.Button();
            this.ShowAllbooks = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IsAdminCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UserBooksLiistBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BookReaderListBox = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BookAuthorInput
            // 
            this.BookAuthorInput.Location = new System.Drawing.Point(25, 355);
            this.BookAuthorInput.Name = "BookAuthorInput";
            this.BookAuthorInput.Size = new System.Drawing.Size(138, 22);
            this.BookAuthorInput.TabIndex = 2;
            this.BookAuthorInput.Text = "Автор";
            // 
            // AddBookBtn
            // 
            this.AddBookBtn.Location = new System.Drawing.Point(25, 399);
            this.AddBookBtn.Name = "AddBookBtn";
            this.AddBookBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBookBtn.TabIndex = 3;
            this.AddBookBtn.Text = "Додати";
            this.AddBookBtn.UseVisualStyleBackColor = true;
            this.AddBookBtn.Click += new System.EventHandler(this.AddBookBtn_Click);
            // 
            // BookTitleInput
            // 
            this.BookTitleInput.Location = new System.Drawing.Point(25, 304);
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
            // ReadersListBox
            // 
            this.ReadersListBox.FormattingEnabled = true;
            this.ReadersListBox.ItemHeight = 16;
            this.ReadersListBox.Location = new System.Drawing.Point(675, 138);
            this.ReadersListBox.Name = "ReadersListBox";
            this.ReadersListBox.Size = new System.Drawing.Size(283, 132);
            this.ReadersListBox.TabIndex = 8;
            this.ReadersListBox.SelectedIndexChanged += new System.EventHandler(this.ReadersListBox_SelectedIndexChanged);
            // 
            // UserNameInput
            // 
            this.UserNameInput.Location = new System.Drawing.Point(675, 305);
            this.UserNameInput.Name = "UserNameInput";
            this.UserNameInput.Size = new System.Drawing.Size(100, 22);
            this.UserNameInput.TabIndex = 9;
            this.UserNameInput.Text = "Ім\'я";
            // 
            // UserPassInput
            // 
            this.UserPassInput.Location = new System.Drawing.Point(675, 355);
            this.UserPassInput.Name = "UserPassInput";
            this.UserPassInput.Size = new System.Drawing.Size(100, 22);
            this.UserPassInput.TabIndex = 10;
            this.UserPassInput.Text = "Пароль";
            // 
            // ChangeUserBtn
            // 
            this.ChangeUserBtn.Location = new System.Drawing.Point(805, 354);
            this.ChangeUserBtn.Name = "ChangeUserBtn";
            this.ChangeUserBtn.Size = new System.Drawing.Size(100, 23);
            this.ChangeUserBtn.TabIndex = 11;
            this.ChangeUserBtn.Text = "Змінити";
            this.ChangeUserBtn.UseVisualStyleBackColor = true;
            this.ChangeUserBtn.Click += new System.EventHandler(this.EditUserBtn_Click);
            // 
            // RemoveBookBtn
            // 
            this.RemoveBookBtn.Location = new System.Drawing.Point(193, 303);
            this.RemoveBookBtn.Name = "RemoveBookBtn";
            this.RemoveBookBtn.Size = new System.Drawing.Size(96, 23);
            this.RemoveBookBtn.TabIndex = 12;
            this.RemoveBookBtn.Text = "Видалити";
            this.RemoveBookBtn.UseVisualStyleBackColor = true;
            this.RemoveBookBtn.Click += new System.EventHandler(this.RemoveBookBtn_Click);
            // 
            // EditBookBtn
            // 
            this.ChangeBookBtn.Location = new System.Drawing.Point(193, 354);
            this.ChangeBookBtn.Name = "EditBookBtn";
            this.ChangeBookBtn.Size = new System.Drawing.Size(96, 23);
            this.ChangeBookBtn.TabIndex = 13;
            this.ChangeBookBtn.Text = "Змінити";
            this.ChangeBookBtn.UseVisualStyleBackColor = true;
            this.ChangeBookBtn.Click += new System.EventHandler(this.EditBookBtn_Click);
            // 
            // RemoveReaderBtn
            // 
            this.RemoveReaderBtn.Location = new System.Drawing.Point(805, 304);
            this.RemoveReaderBtn.Name = "RemoveReaderBtn";
            this.RemoveReaderBtn.Size = new System.Drawing.Size(100, 23);
            this.RemoveReaderBtn.TabIndex = 14;
            this.RemoveReaderBtn.Text = "Видалити";
            this.RemoveReaderBtn.UseVisualStyleBackColor = true;
            this.RemoveReaderBtn.Click += new System.EventHandler(this.RemoveReaderBtn_Click);
            // 
            // AddReaderBtn
            // 
            this.AddReaderBtn.Location = new System.Drawing.Point(675, 419);
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
            this.UsresListBoxStatus.Location = new System.Drawing.Point(672, 119);
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
            this.ShowAllUsers.Location = new System.Drawing.Point(675, 82);
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
            this.label3.Location = new System.Drawing.Point(672, 51);
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
            this.IsAdminCheckBox.Location = new System.Drawing.Point(675, 383);
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
            // 
            // UserBooksLiistBox
            // 
            this.UserBooksLiistBox.FormattingEnabled = true;
            this.UserBooksLiistBox.ItemHeight = 16;
            this.UserBooksLiistBox.Items.AddRange(new object[] {
            "54545"});
            this.UserBooksLiistBox.Location = new System.Drawing.Point(1004, 138);
            this.UserBooksLiistBox.Name = "UserBooksLiistBox";
            this.UserBooksLiistBox.Size = new System.Drawing.Size(254, 132);
            this.UserBooksLiistBox.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1001, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Книги користувача";
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Location = new System.Drawing.Point(190, 9);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(84, 30);
            this.LogOutBtn.TabIndex = 26;
            this.LogOutBtn.Text = "Вийти";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Автор";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Назва:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(673, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Ім\'я";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(673, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "Пароль";
            // 
            // BookReaderListBox
            // 
            this.BookReaderListBox.FormattingEnabled = true;
            this.BookReaderListBox.ItemHeight = 16;
            this.BookReaderListBox.Location = new System.Drawing.Point(363, 138);
            this.BookReaderListBox.Name = "BookReaderListBox";
            this.BookReaderListBox.Size = new System.Drawing.Size(250, 132);
            this.BookReaderListBox.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(360, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "Читають книгу:";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 661);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BookReaderListBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserBooksLiistBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IsAdminCheckBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ShowAllbooks);
            this.Controls.Add(this.ShowAllUsers);
            this.Controls.Add(this.BooksListBoxStatusL);
            this.Controls.Add(this.UsresListBoxStatus);
            this.Controls.Add(this.AddReaderBtn);
            this.Controls.Add(this.RemoveReaderBtn);
            this.Controls.Add(this.ChangeBookBtn);
            this.Controls.Add(this.RemoveBookBtn);
            this.Controls.Add(this.ChangeUserBtn);
            this.Controls.Add(this.UserPassInput);
            this.Controls.Add(this.UserNameInput);
            this.Controls.Add(this.ReadersListBox);
            this.Controls.Add(this.BooksListBox);
            this.Controls.Add(this.BookTitleInput);
            this.Controls.Add(this.AddBookBtn);
            this.Controls.Add(this.BookAuthorInput);
            this.Name = "AdminForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox BookAuthorInput;
        private System.Windows.Forms.Button AddBookBtn;
        private System.Windows.Forms.TextBox BookTitleInput;
        private System.Windows.Forms.ListBox BooksListBox;
        private System.Windows.Forms.ListBox ReadersListBox;
        private System.Windows.Forms.TextBox UserNameInput;
        private System.Windows.Forms.TextBox UserPassInput;
        private System.Windows.Forms.Button ChangeUserBtn;
        private System.Windows.Forms.Button RemoveBookBtn;
        private System.Windows.Forms.Button ChangeBookBtn;
        private System.Windows.Forms.Button RemoveReaderBtn;
        private System.Windows.Forms.Button AddReaderBtn;
        private System.Windows.Forms.Label UsresListBoxStatus;
        private System.Windows.Forms.Label BooksListBoxStatusL;
        private System.Windows.Forms.Button ShowAllUsers;
        private System.Windows.Forms.Button ShowAllbooks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox IsAdminCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox UserBooksLiistBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox BookReaderListBox;
        private System.Windows.Forms.Label label9;
    }
}

