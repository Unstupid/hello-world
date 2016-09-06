using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class LogOnScreen : Form
    {
        public LogOnScreen()
        {
            InitializeComponent();
            LogOnSuccessShow.Text = ("Welcome to the Allotment System");
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void LogOnButton_Click(object sender, EventArgs e)
        {
            string UserName;
            UserName = UsernameBox.Text;
            string Password;
            Password = PasswordBox.Text;
            if (UserName == "Username" && Password == "Password")
            {
                MessageBox.Show("Logging On...", "LogOnSuccessful", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
                Application.Run(new Form2())
            }
            else
            {
                MessageBox.Show("Incorrect User/Password Combination", "LogOnFailure", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                LogOnSuccessShow.Text = ("Try to log on again - check the case of your password and username.");
            }
        }
    }
}
