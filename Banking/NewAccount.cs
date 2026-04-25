using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking
{
    public partial class NewAccount : Form
    {
        string gender = string.Empty;
        string m_status = string.Empty;
        decimal no;
        banking_dbEntities BSE;
        MemoryStream ms;
      
        public NewAccount()
        {
            InitializeComponent();
            loaddate();
            loadaccount();
            loadstate();
        }

        private void loaddate()
        {
            datelbl.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        private void loadstate()
        {
            //throw new NotImplementedException();
            
        }

        private void loadaccount()
        {
            BSE = new banking_dbEntities();
            var item = BSE.userAccounts.ToArray();
            no = item.LastOrDefault().Account_No + 1;
            accnotxt.Text = Convert.ToString(no);

        }

        private void accnotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (marriedRadio.Checked)
            {
                gender = "male";

            }
            else if (femaleRadio.Checked)
            {
                gender = "female";
            }
            else if (otherRadio.Checked)
            {
                gender = "other";
            }
            if (marriedRadio.Checked)
            {
                m_status = "Married";
            }
            else if (unMariedRadio.Checked)
            {
                m_status = "Un-Married";
            }


            BSE = new banking_dbEntities();
            userAccount acc = new userAccount();
            acc.Account_No = Convert.ToInt32(accnotxt.Text);
            acc.Name = nametxt.Text;
            acc.DOB = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            acc.PhoneNo = phonetxt.Text;
            acc.Address = addresstxt.Text;
            acc.Distict = disctxt.Text;
            acc.Gender = gender;
            acc.maritial_status = m_status;
            acc.Mother_Name = motherstxt.Text;
            acc.Fathers_Name = fatherstxt.Text;
            acc.State = statecbox.SelectedItem.ToString();
            acc.balance = Convert.ToDecimal(balancetxt.Text);
            acc.Date = datelbl.Text;
            acc.Picture = ms.ToArray();
            BSE.userAccounts.Add(acc);
            BSE.SaveChanges();
            this.Close();
            MessageBox.Show("Account Created Successfully");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            }
        }
    }
}
