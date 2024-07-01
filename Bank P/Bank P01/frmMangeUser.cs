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
    public partial class frmMangeUser : Form
    {
        public frmMangeUser()
        {
            InitializeComponent();
        }

        private void _RefrashUsers()
        {
            DGVusers.DataSource=clsUser.GetAllUsers();
        }
        private void frmMangeUser_Load(object sender, EventArgs e)
        {
            _RefrashUsers();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddUpdateUsercs frm = new frmAddUpdateUsercs(-1);
            frm.ShowDialog();
            _RefrashUsers();

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsUser.DeleteUser((int)DGVusers.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("delete done", "done", MessageBoxButtons.OK);
                _RefrashUsers();
            }
            else
            {
                MessageBox.Show("Fiald", "noTdone", MessageBoxButtons.OK);

            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateUsercs frm = new frmAddUpdateUsercs((int)DGVusers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefrashUsers();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateUsercs frm = new frmAddUpdateUsercs(-1);
            frm.ShowDialog();
            _RefrashUsers();
        }
    }
}
