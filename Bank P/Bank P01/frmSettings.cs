using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankMiddleLayer;

namespace Bank_P01
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblUserNameNow_Click(object sender, EventArgs e)
        {
            
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            lblUserNameNow.Text = Global.UserNow.UserName;


        }
    }
}
