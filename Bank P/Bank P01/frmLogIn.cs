using BankMiddleLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_P01
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }
        private void frmLogIn_Load(object sender, EventArgs e)
        {
            //frmBankMain frm = new frmBankMain();
            //frm.ShowDialog();
            //this.Close();
        }

        private bool _Login()
        {
            string username=tbusername.Text;
            string password=tbpassword.Text;
            clsUser user = clsUser.Find(username, password);
            Global.UserNow = user;
            if (user != null)
            {
                return (user.UserName == username && user.PassWord == password);

            }
            else { return false; }

          

        }



        private void btnlogin_Click(object sender, EventArgs e)
        {

            if (_Login())
            {
               frmBankMain frm = new frmBankMain();
                frm.ShowDialog();
            }
            else
            {
                lblLoginFiiald.Text = "Username or password not right";

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
