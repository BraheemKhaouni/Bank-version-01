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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void _RefrashClient()
        {
            DGVclients.DataSource = clsClient.GetAllClients();
        }
        private void _RefrashUsers()
        {
            DGVusers.DataSource = clsUser.GetAllUsers();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {

            
                _RefrashClient();

            
        }

        private void btnddNew_Click(object sender, EventArgs e)
        {
            frmAddUpdateClient frm = new frmAddUpdateClient(-1);
            frm.ShowDialog();
            _RefrashClient();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateClient frm = new frmAddUpdateClient((int)DGVclients.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefrashClient();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Answer;
            Answer = MessageBox.Show("Are You Sure You Want To Delete ? ", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Answer==DialogResult.OK)
            {
                clsClient.DeleteClient((int)DGVclients.CurrentRow.Cells[0].Value);
                Answer = MessageBox.Show("Done Deleted ? ", "Delete", MessageBoxButtons.OK);
                _RefrashClient();
            }
            else
            {
                Answer = MessageBox.Show("Done Note Deleted ? ", "NotDelete", MessageBoxButtons.OK);

            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateClient frm = new frmAddUpdateClient(-1);
            frm.ShowDialog();
            _RefrashClient();
        }

        private void _ShowTrancationBtns()
        {
            btnWithDraw.Visible = true;
            btnTotal.Visible = true;
            btnDiposte.Visible = true;
        }
        private void _VisibleTrancationBtns()
        {
            btnWithDraw.Visible = false;
            btnTotal.Visible = false;
            btnDiposte.Visible =false;
        }
        private void _ShowDGVclientsAndAdd()
        {
            DGVclients.Visible = true;
            btnddNew.Visible = true;
        }
        private void _VisibleDGVclientsAndAdd()
        {
            DGVclients.Visible = false;
            btnddNew.Visible = false;
        }
        private void btnTrancation_Click(object sender, EventArgs e)
        {
            DGVusers.Visible = false;
            _ShowTrancationBtns();
            _VisibleDGVclientsAndAdd();
           
            
        }
        private void btnMangeClient_Click(object sender, EventArgs e)
        {
            DGVusers.Visible = false;
            btnddNew.Visible = false;

            _RefrashClient();
            _ShowDGVclientsAndAdd();
            _VisibleTrancationBtns();
            gbDeposte.Visible = false;
            gbWithDraw.Visible = false;
            gbTotalBalance.Visible = false;
        }
        private void btnDiposte_Click(object sender, EventArgs e)
        {
            gbTotalBalance.Visible = false;
            btnDiposte.BackColor = Color.Red;
            btnWithDraw.BackColor = Color.LightSkyBlue;
            btnTotal.BackColor = Color.LightSkyBlue;

           
            gbWithDraw.Visible = false;
            gbDeposte.Visible = true;

        }
        private void btnWithDraw_Click(object sender, EventArgs e)
        {
            gbTotalBalance.Visible = false;

            btnDiposte.BackColor = Color.LightSkyBlue;
            btnWithDraw.BackColor = Color.Red;
            btnTotal.BackColor = Color.LightSkyBlue;


            gbDeposte.Visible = false;
            gbWithDraw.Visible = true;
        }
        private void btnTotal_Click(object sender, EventArgs e)
        {
            gbDeposte.Visible = false;
            gbWithDraw.Visible = false;

            gbTotalBalance.Visible = true;

            btnDiposte.BackColor = Color.LightSkyBlue;
            btnWithDraw.BackColor = Color.LightSkyBlue;
            btnTotal.BackColor = Color.Red;


            int Total = clsClient.GetTotalBalances();
            lblTotalBalance.Text = Total.ToString();



        }
        private int _ReadClientID()
        {
            int ID = 0;
            ID = int.Parse(tbClientID.Text);
            return ID;
        }
        private int _ReadAmount()
        {
            int Amount = 0;
            Amount = int.Parse(tbAmount.Text);
            return Amount;
        }
        private int _ReadSubAmount()
        {
            int Amount = 0;
            Amount = int.Parse(tb2Amount.Text);
            return Amount;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int ID = _ReadClientID();
            int Amount = _ReadAmount();

            clsClient client = clsClient.Find(ID);
            if (client != null)
            {
                    if (client.Deposite(ID, Amount))
                    {
                        MessageBox.Show("The Trancation Is Done", "Done", MessageBoxButtons.OK);
                        lblAccountB.Text = client.AccountBalance.ToString();
                        client.AccountBalance += Amount;
                        lblNewAccountB.Text = client.AccountBalance.ToString();
                    }
                    else
                    {
                        MessageBox.Show("The Trancation Is Faild", "NotDone", MessageBoxButtons.OK);
                    }
                
                
            }

        }

        private void _Clear()
        {
            // Clear Diposte Fiald 
            lblAccountB.Text = string.Empty;
            lblNewAccountB.Text = string.Empty;
            tbAmount.Text = string.Empty;
            tbClientID.Text = string.Empty;

            // Clear WithDraw Fiald 
            lbl2AccountB.Text = string.Empty;
            lbl2NewAccountB.Text = string.Empty;
            tb2Amount.Text = string.Empty;
            tb2ClientID.Text = string.Empty;
        }

        private void btnOKWithDraw_Click(object sender, EventArgs e)
        {
            int ID = _ReadClientID();
            int Amount = _ReadSubAmount();

            clsClient client = clsClient.Find(ID);
            if (client != null)
            {
                if (client.WithDraw(ID, Amount))
                {
                    MessageBox.Show("The Trancation Is Done", "Done", MessageBoxButtons.OK);
                    lbl2AccountB.Text = client.AccountBalance.ToString();
                    client.AccountBalance -= Amount;
                    lbl2NewAccountB.Text = client.AccountBalance.ToString();
                }
                else
                {
                    MessageBox.Show("The Trancation Is Faild", "NotDone", MessageBoxButtons.OK);
                }


            }
        }

        private void lblTotalBalance_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnMangeUser_Click(object sender, EventArgs e)
        {
            DGVclients.Visible = false;
            btnddNew.Visible = false;
            DGVusers.Visible = true;
            _VisibleTrancationBtns();
            _RefrashUsers();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser(-1);
            frm.ShowDialog();
            _RefrashUsers();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (DGVusers.CurrentRow.Cells[1].Value.ToString() == "User4")
            {
                MessageBox.Show("You Can Not Delete Admin  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (clsUser.DeleteUser((int)DGVusers.CurrentRow.Cells[0].Value))
            {
                
                MessageBox.Show("Done Deleted  ", "Delete", MessageBoxButtons.OK);
                _RefrashUsers(); 
            }
            else
            {
                 MessageBox.Show("User Note Deleted ? ", "NotDelete", MessageBoxButtons.OK);

            }
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser((int)DGVusers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefrashUsers();
        }
    }
}
