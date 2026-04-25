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
    public partial class FDForm : Form
    {
        public FDForm()
        {
            InitializeComponent();
            loaddate();
            loadmode();
        }

        private void loadmode()
        {
            modecmbox.Items.Add("Cash");
            modecmbox.Items.Add("Check");
        }

        private void loaddate()
        {
            datetxt.Text = DateTime.UtcNow.ToString("MM/dd/yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            banking_dbEntities dbe = new banking_dbEntities();
            decimal accno = Convert.ToDecimal(accnotxt.Text);
            var accounts = dbe.userAccounts.Where(x => x.Account_No == accno).SingleOrDefault();
            FD fdform = new FD();
            fdform.Mode = modecmbox.SelectedItem.ToString();
            fdform.Rupees = amounttxt.Text;
            fdform.Period = Convert.ToInt32(periodtxt.Text);
            fdform.Interes_rate = Convert.ToDecimal(interesttxt.Text);
            fdform.Start_Date = DateTime.UtcNow.ToString("MM/dd/yyyy");
            fdform.Maturity_Date = (DateTime.UtcNow.AddDays(Convert.ToInt32(periodtxt.Text))).ToString("MM/dd/yyyy");
            fdform.Maturity_Amount = ((Convert.ToDecimal(amounttxt.Text)) * 
                Convert.ToInt32(periodtxt.Text) * Convert.ToDecimal(interesttxt.Text))
                /(100*12*30)+(Convert.ToDecimal(amounttxt.Text));

            dbe.FDs.Add(fdform);
            decimal amount = Math.Round(Convert.ToDecimal(amounttxt.Text),2);
            decimal totalamount = Math.Round(Convert.ToDecimal(accounts.balance),2);
            decimal fdamount = Math.Round((totalamount - amount),2);
            accounts.balance = fdamount;
            dbe.SaveChanges();
            MessageBox.Show("FD Started Now");


        }
    }
}
