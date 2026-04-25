using System;
using System.Linq;
using System.Windows.Forms;

namespace Banking
{
    public partial class TransferForm : Form
    {
        public TransferForm()
        {
            InitializeComponent();
            LoadDate();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoadDate()
        {
            datelbl.Text = DateTime.UtcNow.ToString("MM/dd/yyyy");
        }

        private void LoadAccountDetails()
        {
            decimal fromAccountNo;

            if (!decimal.TryParse(fromacctxt.Text, out fromAccountNo))
            {
                MessageBox.Show("Please enter a valid source account number.");
                return;
            }

            using (banking_dbEntities dbe = new banking_dbEntities())
            {
                var item = dbe.userAccounts.FirstOrDefault(u => u.Account_No == fromAccountNo);

                if (item == null)
                {
                    MessageBox.Show("Source account not found.");
                    nametxt.Text = "";
                    curentamounttxt.Text = "";
                    amounttxt.Text = "";
                    return;
                }

                nametxt.Text = item.Name;
                curentamounttxt.Text = item.balance.ToString();
                amounttxt.Text = "";
            }
        }

        private void detailsbtn_Click(object sender, EventArgs e)
        {
            LoadAccountDetails();
        }

        private void transferbtn_Click(object sender, EventArgs e)
        {
            decimal fromAccountNo;
            decimal destinationAccountNo;
            decimal transferAmount;

            if (!decimal.TryParse(fromacctxt.Text, out fromAccountNo))
            {
                MessageBox.Show("Please enter a valid source account number.");
                return;
            }

            if (!decimal.TryParse(destinationacctxt.Text, out destinationAccountNo))
            {
                MessageBox.Show("Please enter a valid destination account number.");
                return;
            }

            if (!decimal.TryParse(amounttxt.Text, out transferAmount))
            {
                MessageBox.Show("Please enter a valid transfer amount.");
                return;
            }

            if (transferAmount <= 0)
            {
                MessageBox.Show("Transfer amount must be greater than zero.");
                return;
            }

            if (fromAccountNo == destinationAccountNo)
            {
                MessageBox.Show("Source and destination account cannot be the same.");
                return;
            }

            using (banking_dbEntities dbe = new banking_dbEntities())
            {
                var fromAccount = dbe.userAccounts.FirstOrDefault(u => u.Account_No == fromAccountNo);
                var destinationAccount = dbe.userAccounts.FirstOrDefault(u => u.Account_No == destinationAccountNo);

                if (fromAccount == null)
                {
                    MessageBox.Show("Source account not found.");
                    return;
                }

                if (destinationAccount == null)
                {
                    MessageBox.Show("Destination account not found.");
                    return;
                }

                if (fromAccount.balance < transferAmount)
                {
                    MessageBox.Show("Insufficient balance.");
                    return;
                }

                fromAccount.balance -= transferAmount;
                destinationAccount.balance += transferAmount;

                Transfer transfer = new Transfer();
                transfer.Account_No = fromAccountNo;
                transfer.ToTransfer = destinationAccountNo;
                transfer.Date = DateTime.UtcNow.ToString("MM/dd/yyyy");
                transfer.Name = fromAccount.Name;
                transfer.balance = transferAmount;

                dbe.Transfers.Add(transfer);
                dbe.SaveChanges();

                MessageBox.Show("Transfer successful.");

                LoadAccountDetails();

                destinationacctxt.Text = "";
                amounttxt.Text = "";
            }
        }
    }
}