using BankMiddleLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_System_1
{
    public partial class frmAddUpdateClient : Form
    {
        enum enMode { AddNew,Update}
        enMode _Mode;

        int _ID;
        clsClient _Client;
        public frmAddUpdateClient(int ClientID)
        {
            InitializeComponent();
            _ID = ClientID;
            if (_ID == -1) 
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
                lblMode.Text = "Add New Client";
                _Client = new clsClient();
                return;
            }

            _Client = clsClient.Find(_ID);

            tbFirstName.Text = _Client.FirstName;
            tbLastName.Text = _Client.LastName;
            tbEmail.Text = _Client.Email;
            tbPhone.Text = _Client.Phone;
            tbAccountNumber.Text = _Client.AccountNumber;
            tbPinCode.Text=_Client.PinCode.ToString();
            tbAccountBalance.Text = _Client.AccountBalance.ToString();

            lblMode.Text = "Update Client  " + _Client.ClientID.ToString();

            lblClientID.Text = _Client.ClientID.ToString();
        }
        private void frmAddUpdateClient_Load(object sender, EventArgs e)
        {
            _LoadData();

        }
        private void btnClose_Click_1(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            

            _Client.FirstName=tbFirstName.Text;
            _Client.LastName=tbLastName.Text;
            _Client.Email=tbEmail.Text;
            _Client.Phone=tbPhone.Text;
            _Client.AccountNumber = tbAccountNumber.Text;
            int PinCode = int.Parse(tbPinCode.Text);
            _Client.PinCode = PinCode;

            int A_Balance = int.Parse(tbAccountBalance.Text);
            _Client.AccountBalance = A_Balance;

            _Client.ClientID = _Client.ClientID;
            if (_Client.Save())
            {
                MessageBox.Show("Save Done ","Done",MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Save Not Done ", "NotDone", MessageBoxButtons.OK);

            }


            _Mode = enMode.Update;
            lblMode.Text = "Edit Client ID = " + _Client.ClientID;
            lblClientID.Text = _Client.ClientID.ToString();

        }
    }
}
