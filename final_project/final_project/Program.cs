using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthForm());
            //Application.Run(new Form1());

            //Guid guid = Guid.Parse("ebd5876c-fd45-40f7-818a-c166b53af2a4");
            //Application.Run(new UserForm(guid));

        }
    }
}
