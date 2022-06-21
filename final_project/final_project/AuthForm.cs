using System;
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
                resLabel.Text = "Невірний логін або пароль";
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
