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

namespace Bank_System_1
{
    public partial class frmAddEditUser : Form
    {
        enum enMode
        {
            AddNew,Update
        };
        enMode _Mode;
        int _UserID;
        clsUser _User;
        public frmAddEditUser(int User_ID)
        {
            InitializeComponent();
            _UserID = User_ID;
            if (_UserID == -1) 
            {
                _Mode = enMode.AddNew;
            }
            else
            {
                _Mode = enMode.Update;
            }
        }

        private void _LoadData()
        {
            if (_Mode==enMode.AddNew)
            {
                lblUserMode.Text = "Add New User";
                _User = new clsUser();
                return;
            }
            _User = clsUser.Find(_UserID);
            if (_User != null) 
            {
                tbUserName.Text = _User.UserName;
                tbPassWord.Text = _User.PassWord;
               tbPermissions.Text=_User.Permissions.ToString();
                lblUserMode.Text = "Update User " + _User.UserID.ToString();
                lblUserID.Text = _UserID.ToString();

            }


        }
        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            _LoadData();

        }

       

        private void btnSave_Click(object sender, EventArgs e)
        {
            _User.UserName = tbUserName.Text;
            _User.PassWord = tbPassWord.Text;
            _User.Permissions = int.Parse(tbPermissions.Text);
            if (_User.Save())
            {
                MessageBox.Show("Save Done", "Done", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Save Fiald", "NotDone", MessageBoxButtons.OK);

            }

            _Mode = enMode.Update;
            lblUserMode.Text = "Edit User ID = " + _User.UserID;
            lblUserID.Text = _User.UserID.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
