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
    public partial class frmAddUpdateClient : Form
    {
        enum enMode {AddNew,Update }
        enMode _Mode;
        int _ID;
        clsClient _client;
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

        private void _LoadDate()
        {
            if (_Mode == enMode.AddNew)
            {
                lblMode.Text = "Add New Client";
                _client = new clsClient();  
                return;
            }
          _client = clsClient.Find(_ID);

            if (_client!=null)
            {
                tbfirstname.Text = _client.FirstName;
                tblastname.Text = _client.LastName;
                tbemail.Text = _client.Email;
                tbphone.Text = _client.Phone;
                tbaccuntnumber.Text = _client.AccountNumber;
                tbpincode.Text = _client.PinCode.ToString();
                tbaccountbalance.Text = _client.AccountBalance.ToString();
                lblClientID.Text = _client.ClientID.ToString();
                lblMode.Text = "Update Client";
            }

            else
            {
                MessageBox.Show("null object", "object", MessageBoxButtons.OK);

            }

        }
        private void frmAddUpdateClient_Load(object sender, EventArgs e)
        {
            _LoadDate();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            _client.FirstName = tbfirstname.Text;
            _client.LastName = tblastname.Text;
            _client.Email = tbemail.Text;
            _client.Phone = tbphone.Text;
            _client.AccountNumber = tbaccuntnumber.Text;
            _client.PinCode = int.Parse(tbpincode.Text);
            _client.AccountBalance = int.Parse(tbaccountbalance.Text);

            lblMode.Text="Update Client "+_client.ClientID.ToString();
            lblClientID.Text = _client.ClientID.ToString();

            if (_client.Save())
            {
                MessageBox.Show("save done", "save", MessageBoxButtons.OK);
                
            }
            else
            {
                MessageBox.Show("save Foald", "not", MessageBoxButtons.OK);

            }
            _Mode = enMode.Update;
            lblMode.Text = "Update Client " + _client.ClientID.ToString();
            lblClientID.Text = _client.ClientID.ToString();
        }
    }
}
