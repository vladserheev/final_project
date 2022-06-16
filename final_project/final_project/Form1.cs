﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project
{
    public partial class Form1 : Form
    {
        Library lib = new Library();
        public Form1()
        {
            InitializeComponent();
            RefreshBooksListBox();
            RefreshReadersListBox();
        }
        private void FormLists_Load(object sender, EventArgs e)
        {
            BooksListBox.DataSource = lib.BooksList.ToList();
            ReadersBoxList.DataSource = lib.ReadersList.ToList();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RefreshBooksListBox()
        { 
            BooksListBox.DataSource = lib.BooksList.ToList();
        }
        private void RefreshReadersListBox()
        {
            ReadersBoxList.DataSource = lib.ReadersList.ToList();
        }
        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            string title = BookTitleInput.Text;
            string author = BookAuthorInput.Text;
            lib.AddNewBook(title, author);
            lib.RefreshBooksJson();
            RefreshBooksListBox();
        }

        private void ChangeUserPassInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChangeUserNameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void BooksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BooksListBox.SelectedItem != null)
            {
                Book book = ((Book)BooksListBox.SelectedItem);
                BookTitleInput.Text = book.Title;
                BookAuthorInput.Text = book.Author;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BooksListBox.SelectedItem != null)
            {
                Book book = ((Book)BooksListBox.SelectedItem);
                Guid id = book._Id;
                lib.RemoveBook(id);
                RefreshBooksListBox();
            }
        }

        private void UpdateBook_Click(object sender, EventArgs e)
        {
            if (BooksListBox.SelectedItem != null)
            {
                Book book = ((Book)BooksListBox.SelectedItem);
                book.Title = BookTitleInput.Text;
                book.Author = BookAuthorInput.Text;
                lib.RefreshBooksJson();
                RefreshBooksListBox();
            }
        }

        private void AddReaderBtn_Click(object sender, EventArgs e)
        {
            string name = UserNameInput.Text;
            string pass = UserPassInput.Text;
            lib.AddNewUser(name, pass, false);
            lib.RefreshReadersJson();
            RefreshReadersListBox();
        }

        private void RemoveReader_Click(object sender, EventArgs e)
        {
            if (ReadersBoxList.SelectedItem != null)
            {
                Reader reader = ((Reader)ReadersBoxList.SelectedItem);
                Guid id = reader._Id;
                lib.RemoveReader(id);
                RefreshReadersListBox();
            }
        }

        private void ChangeUserBtn_Click(object sender, EventArgs e)
        {
            if (ReadersBoxList.SelectedItem != null)
            {
                Reader reader = ((Reader)ReadersBoxList.SelectedItem);
                reader.Name = UserNameInput.Text;
                reader.Pass = UserPassInput.Text;
                lib.RefreshReadersJson();
                RefreshReadersListBox();
            }
        }

        private void ReadersBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ReadersBoxList.SelectedItem != null)
            {
                Reader reader = ((Reader)ReadersBoxList.SelectedItem);
                UserNameInput.Text = reader.Name;
                UserPassInput.Text = reader.Pass;
            }
        }
    }
}