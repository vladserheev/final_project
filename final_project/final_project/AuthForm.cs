using System;
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
    public partial class AuthForm : Form
    {
        Library lib = new Library();
        public AuthForm()
        {
            InitializeComponent();
        }
        
        private void SignInBtn_Click(object sender, EventArgs e)
        {
            string userName = UserNameInput.Text;
            string userPass = UserPassInput.Text;

            Reader reader = lib.SignIn(userName, userPass);
            if (reader == null)
            {
                resLabel.Text = "Невдалося ввійти";
            }
            else if(reader.IsAdmin == true) // Перевірка чи коримстувач адмін
            {
                OpenAdminForm();
            }
            else
            {
                OpenUserForm(reader._Id);
            }
        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            
        }
        private void RegBtn_Click_1(object sender, EventArgs e)
        {
            string userName = UserNameInput.Text;
            string userPass = UserPassInput.Text;
            Guid id = lib.AddNewUser(userName, userPass, false);
            OpenUserForm(id);
        }

        private void OpenUserForm(Guid id)
        {
            UserForm userForm = new UserForm(id);
            userForm.Show();
        }

        private void OpenAdminForm()
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }
    }
}
