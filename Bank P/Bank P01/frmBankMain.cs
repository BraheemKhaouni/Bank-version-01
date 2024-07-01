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
    public partial class frmBankMain : Form
    {
        public frmBankMain()
        {
            InitializeComponent();
        }
        private void _RefrashClients()
        {

            DGVclients.DataSource=clsClient.GetAllClients();    
        }
        private void frmBankMain_Load(object sender, EventArgs e)
        {
            _RefrashClients();
        }

        private void btnAddNew_Click(object sender, EventArgs e)


        {

            if (!CheckPermiossion(clsUser.enPermiosion.pAddNewClient))
            {
                message();
                return;
            }
            frmAddUpdateClient frmAddUpdateClient = new frmAddUpdateClient(-1);
            frmAddUpdateClient.ShowDialog();
            _RefrashClients();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateClient frmAddUpdateClient = new frmAddUpdateClient(-1);
            frmAddUpdateClient.ShowDialog();
            _RefrashClients();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateClient frmAddUpdateClient = new frmAddUpdateClient((int)DGVclients.CurrentRow.Cells[0].Value);
            frmAddUpdateClient.ShowDialog();
            _RefrashClients();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsClient.DeleteClient((int)DGVclients.CurrentRow.Cells[0].Value)) 
            {
                MessageBox.Show("delete Done", "done", MessageBoxButtons.OK);
                _RefrashClients();
            }
            else
            {
                MessageBox.Show("fiald Done", "notdone", MessageBoxButtons.OK);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!CheckPermiossion(clsUser.enPermiosion.pTtancations))
            {
                message();
                return;
            }
            frmTrancationcs frm = new frmTrancationcs();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!CheckPermiossion(clsUser.enPermiosion.pMangeUser))
            {
                message();
                return;
            }
            frmMangeUser frm = new frmMangeUser();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmSettings frm = new frmSettings();
            frm.ShowDialog();
        }
        public void message()
        {
            MessageBox.Show("you can t log in","no",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        public bool CheckPermiossion(clsUser.enPermiosion Permissions)
        {
            if (Global.UserNow.Permissions == -1)
            {
                return true;
            }
            else if ((Global.UserNow.Permissions & (int)Permissions) == (int)Permissions) 
            {

                return true;
            }
            else
            {
                return false;
                    
            }

        }








    }
}
