using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class Form1 : Form
    {
        #region Variable UC_LOGIN & SIGN_UP
        Form1_UC.Login uc_Login = new Form1_UC.Login();
        Form1_UC.Sign_Up uc_SignUp = new Form1_UC.Sign_Up();
        #endregion
        public Form1()
        {
            InitializeComponent();
            uc_Login.turnToSignUp += Login_ToSignUp;
            uc_Login._closeForm += Click_ToClose;
            uc_SignUp._closeForm += Click_ToClose;
            uc_SignUp.turnToLogin += SignUp_ToLogin;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelRight.Controls.Clear();
            panelRight.Controls.Add(uc_Login);
        }

        private void Login_ToSignUp(object sender, EventArgs e)
        {
            panelRight.Controls.Clear();
            panelRight.Controls.Add(uc_SignUp);
        }

        private void SignUp_ToLogin(object sender, EventArgs e)
        {
            panelRight.Controls.Clear();
            panelRight.Controls.Add(uc_Login);
        }

        private void Click_ToClose(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
