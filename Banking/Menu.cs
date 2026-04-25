using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Normal;
            this.TopMost = true;
        }

        private void newAccountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewAccount newacc = new NewAccount();
            newacc.MdiParent = this;
            newacc.Show();
        }

        private void updateSearchAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdationForm up = new UpdationForm();
            up.MdiParent = this;
            up.Show();
        }

        private void allCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allCustomers all = new allCustomers();
            all.MdiParent = this;
            all.Show();
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            depositForm dep = new depositForm();
            dep.MdiParent = this;
            dep.Show();
        }

        private void wiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WidthdrawForm wid = new WidthdrawForm();
            wid.MdiParent = this;
            wid.Show();
        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransferForm tr = new TransferForm();
            tr.MdiParent = this;
            tr.Show();

        }

        private void fDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FDForm fd = new FDForm();
            fd.MdiParent = this;
            fd.Show();
        }

        private void balanceSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            balanceForm bal = new balanceForm();
            bal.MdiParent = this;
            bal.Show();
        }

        private void viewFDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WiewFD fd = new WiewFD();
            fd.MdiParent = this;
            fd.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.ShowDialog();
            this.Close();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword();
            cp.MdiParent = this;
            cp.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void creditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreditForm cr = new CreditForm();
            cr.MdiParent = this;
            cr.Show();
        }
    }
}
