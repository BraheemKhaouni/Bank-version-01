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
    public partial class frmAddUpdateUsercs : Form
    {
       
        enum enMode {AddNew,Update }
        enMode _Mode;
        int _UserID;
        clsUser _User;
        public frmAddUpdateUsercs(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            if (_UserID == -1)
            {
                _Mode = enMode.AddNew;
            }
            else
            {
                _Mode =enMode.Update;
            }
        }

        private void _LoadData()
        {
            if (_Mode == enMode.AddNew) 
            {
                lblUserMode.Text = "Add New User";
                _User = new clsUser();
                return;
            }

            lblUserMode.Text = "Update User ";


            _User = clsUser.Find(_UserID);

           
            tbusername.Text = _User.UserName;
            tbpassword.Text = _User.PassWord;
            tbPermiossion.Text= _User.Permissions.ToString();

            lblUserID.Text = _User.UserID.ToString();


        }

        private void frmAddUpdateUsercs_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            _User.UserName = tbusername.Text;
            _User.PassWord = tbpassword.Text;

            _User.Permissions = _MakePermaino();

            if (_User.Save())
            {
                MessageBox.Show("sv Done", "done", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("sorry","no",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _Mode = enMode.Update;  
            lblUserID.Text = _User.UserID.ToString();
            lblUserMode.Text = "Update User "+ _User.UserID.ToString(); 
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblUserMode_Click(object sender, EventArgs e)
        {

        }

        private void tbPermiossion_TextChanged(object sender, EventArgs e)
        {

        }

        private int _MakePermaino()
        {
            int per = 0;
            if (rbAll.Checked)
            {
                return -1;
            }
            if (chbAddClient.Checked)
            {
                per += Convert.ToInt32(chbAddClient.Tag);
            }
            if (chbDeleteClient.Checked)
            {
                per += Convert.ToInt32(chbDeleteClient.Tag);
            }
            if (chbUpdateClient.Checked)
            {
                per += Convert.ToInt32(chbUpdateClient.Tag);
            }

            if (chbTrancations.Checked)
            {
                per += Convert.ToInt32(chbTrancations.Tag);
            }
            if (chbMangeUser.Checked)
            {
                per += Convert.ToInt32(chbMangeUser.Tag);
            }
            return per; 


            
        }

        private void rbSelect_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;

        }
    }
}
