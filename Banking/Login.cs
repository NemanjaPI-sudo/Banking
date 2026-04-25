using System;
using System.Linq;
using System.Windows.Forms;

namespace Banking
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ControlBox = false;
            this.WindowState = FormWindowState.Normal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                using (banking_dbEntities db = new banking_dbEntities())
                {
                    // probaj da otvori konekciju
                    db.Database.Connection.Open();

                    if (string.IsNullOrWhiteSpace(usrtxt.Text) || string.IsNullOrWhiteSpace(passtxt.Text))
                    {
                        MessageBox.Show("Please enter username and password");
                        return;
                    }

                    var user1 = db.Admin_Table.FirstOrDefault(a => a.Username == usrtxt.Text);

                    if (user1 != null && user1.Password == passtxt.Text)
                    {
                        Menu m1 = new Menu();
                        this.Hide();
                        m1.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection failed!\n\n" + ex.Message,
                    "Connection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                button1.Enabled = true;
                Cursor.Current = Cursors.Default;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}