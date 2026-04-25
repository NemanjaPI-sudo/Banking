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
    public partial class allCustomers : Form
    {
        public allCustomers()
        {
            InitializeComponent();
            bindgrid();
        }

        private void bindgrid()
        {
            banking_dbEntities BSE = new banking_dbEntities();

            var item = BSE.userAccounts
                .Select(x => new
                {
                    x.Account_No,
                    x.Name,
                    x.DOB,
                    x.PhoneNo,
                    x.Address,
                    x.Distict,
                    x.State,
                    x.Gender,
                    x.maritial_status,
                    HasImage = x.Picture != null 
                })
                .ToList();

            dataGridView1.DataSource = item;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 40;
        }
    }
}