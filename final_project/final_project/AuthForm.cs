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
                resLabel.Text = "null";
            }
            else
            {
                UserForm userForm = new UserForm(reader._Id);

                userForm.Show();
            }
        }

    }
}
