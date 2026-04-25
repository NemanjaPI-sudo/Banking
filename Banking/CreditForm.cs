using System;
using System.Linq;
using System.Windows.Forms;

namespace Banking
{
    public partial class CreditForm : Form
    {
        public CreditForm()
        {
            InitializeComponent();
            loaddate();
            loadmode();
        }

        private void loaddate()
        {
            datelbl.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        private void loadmode()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Cash");
            comboBox1.Items.Add("Cheque");
            comboBox1.Items.Add("Online");
            comboBox1.SelectedIndex = 0;
        }

        private bool GetAccountNo(out decimal accNo)
        {
            if (!decimal.TryParse(accnotxt.Text, out accNo))
            {
                MessageBox.Show("Unesite validan broj računa");
                return false;
            }

            return true;
        }

        private void LoadAccountDetails()
        {
            using (banking_dbEntities context = new banking_dbEntities())
            {
                userAccount item = null;

                // prvo po Account No
                if (!string.IsNullOrWhiteSpace(accnotxt.Text))
                {
                    if (!decimal.TryParse(accnotxt.Text, out decimal accNo))
                    {
                        MessageBox.Show("Unesite validan broj računa");
                        return;
                    }

                    item = context.userAccounts
                                  .FirstOrDefault(u => u.Account_No == accNo);
                }

                // ako nije našao po accno, traži po imenu
                else if (!string.IsNullOrWhiteSpace(nametxt.Text))
                {
                    string ime = nametxt.Text.Trim();

                    item = context.userAccounts
                                  .FirstOrDefault(u => u.Name == ime);
                }

                // ako ništa nije uneto
                else
                {
                    MessageBox.Show("Unesite Account No ili Name");
                    return;
                }

                // nije pronađen korisnik
                if (item == null)
                {
                    MessageBox.Show("Račun nije pronađen");
                    nametxt.Text = "";
                    oldbalancetxt.Text = "";
                    return;
                }

                // puni formu
                accnotxt.Text = item.Account_No.ToString();
                nametxt.Text = item.Name;
                oldbalancetxt.Text = item.balance.ToString();
            }
        }

        private void DetailsBtn_Click(object sender, EventArgs e)
        {
            LoadAccountDetails();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            if (!GetAccountNo(out decimal accNo))
                return;

            if (string.IsNullOrWhiteSpace(amounttxt.Text))
            {
                MessageBox.Show("Unesite iznos");
                return;
            }

            if (!decimal.TryParse(amounttxt.Text, out decimal amount))
            {
                MessageBox.Show("Unesite validan iznos");
                return;
            }

            if (amount <= 0)
            {
                MessageBox.Show("Iznos mora biti veći od nule");
                return;
            }

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Izaberite način uplate");
                return;
            }

            using (banking_dbEntities context = new banking_dbEntities())
            {
                var item = context.userAccounts.FirstOrDefault(u => u.Account_No == accNo);

                if (item == null)
                {
                    MessageBox.Show("Račun nije pronađen");
                    return;
                }

                Deposit dp = new Deposit();
                dp.Date = datelbl.Text;
                dp.AccountNo = accNo;
                dp.Name = item.Name;
                dp.Mode = comboBox1.SelectedItem.ToString();
                dp.OldBalance = item.balance;
                dp.DipAmount = amount;

                context.Deposits.Add(dp);

                item.balance = item.balance + amount;

                context.SaveChanges();
            }

            MessageBox.Show("Amount Credited Successfully");

            // ponovo učitaj sveže podatke iz baze
            LoadAccountDetails();

            // opcionalno: očisti amount polje
            amounttxt.Clear();
        }
    }
}