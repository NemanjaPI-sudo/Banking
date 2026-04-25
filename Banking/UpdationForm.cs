using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Banking
{
    public partial class UpdationForm : Form
    {
        banking_dbEntities dbe;
        MemoryStream ms;
        BindingList<userAccount> bi;

        public UpdationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bi = new BindingList<userAccount>();
            dbe = new banking_dbEntities();

            if (!decimal.TryParse(acctxt.Text, out decimal accno))
            {
                MessageBox.Show("Required input for Acc No");
                return;
            }

            var item = dbe.userAccounts.Where(a => a.Account_No == accno).ToList();

            foreach (var item1 in item)
            {
                bi.Add(item1);
            }

            dataGridView1.DataSource = bi;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bi = new BindingList<userAccount>();
            dbe = new banking_dbEntities();

            if (string.IsNullOrWhiteSpace(nametxt.Text))
            {
                MessageBox.Show("Required input for Name");
                return;
            }

            var item = dbe.userAccounts.Where(a => a.Name == nametxt.Text).ToList();

            foreach (var item1 in item)
            {
                bi.Add(item1);
            }

            dataGridView1.DataSource = bi;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            dbe = new banking_dbEntities();

            decimal accno = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            var item = dbe.userAccounts.FirstOrDefault(a => a.Account_No == accno);

            if (item == null)
            {
                MessageBox.Show("Record not found");
                return;
            }

            acctxt.Text = item.Account_No.ToString();
            nametxt.Text = item.Name;

            // Fix for CS0029: Parse the string 'DOB' to DateTime before assigning
            if (DateTime.TryParse(item.DOB, out DateTime parsedDOB))
            {
                dateTimePicker1.Value = parsedDOB;
            }
            else
            {
                dateTimePicker1.Value = DateTime.Now; // Default value if parsing fails
            }

            mothertxt.Text = item.Mother_Name;
            fathertxt.Text = item.Fathers_Name;
            phonetxt.Text = item.PhoneNo;
            addreestxt.Text = item.Address;
            distictxt.Text = item.Distict;
            statetxtx.Text = item.State;

            if (item.Picture != null)
            {
                byte[] img = item.Picture;
                MemoryStream imgStream = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(imgStream);
            }
            else
            {
                pictureBox1.Image = null;
            }

            maleradiobtn.Checked = false;
            femaleradiobtn.Checked = false;
            otherradiobtn.Checked = false;

            if (item.Gender == "male")
            {
                maleradiobtn.Checked = true;
            }
            else if (item.Gender == "female")
            {
                femaleradiobtn.Checked = true;
            }
            else
            {
                otherradiobtn.Checked = true;
            }

            marriedradiobtn.Checked = false;
            unmarriedradiobtn.Checked = false;

            if (item.maritial_status == "married")
            {
                marriedradiobtn.Checked = true;
            }
            else if (item.maritial_status == "unmarried")
            {
                unmarriedradiobtn.Checked = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(ofd.FileName);
                pictureBox1.Image = img;

                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(acctxt.Text, out decimal accno))
            {
                MessageBox.Show("Select a valid record first");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this record?",
                "Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No)
                return;

            dbe = new banking_dbEntities();

            userAccount acc = dbe.userAccounts.FirstOrDefault(x => x.Account_No == accno);

            if (acc == null)
            {
                MessageBox.Show("Record not found");
                return;
            }

            dbe.userAccounts.Remove(acc);
            dbe.SaveChanges();

            MessageBox.Show("Record deleted successfully");
            ClearFields();
            LoadAllData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dbe = new banking_dbEntities();

            if (!decimal.TryParse(acctxt.Text, out decimal accno))
            {
                MessageBox.Show("Required input for Acc No");
                return;
            }

            var item = dbe.userAccounts.FirstOrDefault(a => a.Account_No == accno);

            if (item == null)
            {
                MessageBox.Show("Record not found");
                return;
            }

            item.Name = nametxt.Text;
            item.DOB = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            item.Mother_Name = mothertxt.Text;
            item.Fathers_Name = fathertxt.Text;
            item.PhoneNo = phonetxt.Text;
            item.Address = addreestxt.Text;
            item.Distict = distictxt.Text;
            item.State = statetxtx.Text;

            if (maleradiobtn.Checked)
            {
                item.Gender = "male";
            }
            else if (femaleradiobtn.Checked)
            {
                item.Gender = "female";
            }
            else if (otherradiobtn.Checked)
            {
                item.Gender = "other";
            }

            if (marriedradiobtn.Checked)
            {
                item.maritial_status = "married";
            }
            else if (unmarriedradiobtn.Checked)
            {
                item.maritial_status = "unmarried";
            }

            if (ms != null)
            {
                item.Picture = ms.ToArray();
            }

            dbe.SaveChanges();

            MessageBox.Show("Record updated successfully");
            RefreshSelectedRecord(accno);
        }

        private void RefreshSelectedRecord(decimal accno)
        {
            bi = new BindingList<userAccount>();
            dbe = new banking_dbEntities();

            var item = dbe.userAccounts.Where(a => a.Account_No == accno).ToList();

            foreach (var item1 in item)
            {
                bi.Add(item1);
            }

            dataGridView1.DataSource = bi;
        }

        private void LoadAllData()
        {
            bi = new BindingList<userAccount>();
            dbe = new banking_dbEntities();

            var items = dbe.userAccounts.ToList();

            foreach (var item in items)
            {
                bi.Add(item);
            }

            dataGridView1.DataSource = bi;
        }

        private void ClearFields()
        {
            acctxt.Clear();
            nametxt.Clear();
            mothertxt.Clear();
            fathertxt.Clear();
            phonetxt.Clear();
            addreestxt.Clear();
            distictxt.Clear();
            statetxtx.Clear();

            dateTimePicker1.Value = DateTime.Now;
            pictureBox1.Image = null;
            ms = null;

            maleradiobtn.Checked = false;
            femaleradiobtn.Checked = false;
            otherradiobtn.Checked = false;

            marriedradiobtn.Checked = false;
            unmarriedradiobtn.Checked = false;
        }
    }
}