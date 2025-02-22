using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financas
{
    public partial class Expenses : Form
    {
        public Expenses()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        SqlConnection Con = new SqlConnection("Data Source=W3283439;Initial Catalog=ExpenseOb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        private void Clear()
        {
            ExpenseNameTb.Text = "";
            ExpDescTb.Text = "";
            ExpAmtTb.Text = "";
            ExpCatTb.SelectedIndex = 0;
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (ExpenseNameTb.Text == "" || ExpAmtTb.Text == "" || ExpDescTb.Text == "" || ExpCatTb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into ExpenseTbl (ExpName,ExpAmt,ExCat,ExpDate,ExpComment,ExpUser) values(@EN,@EA,@EC,@ED,@ECo,@EU)", Con);
                cmd.Parameters.AddWithValue("@EN", ExpenseNameTb.Text);
                cmd.Parameters.AddWithValue("@EA", ExpAmtTb.Text);
                cmd.Parameters.AddWithValue("@EC", ExpCatTb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@ED", ExpDate.Value.Date);
                cmd.Parameters.AddWithValue("@ECo", ExpDescTb.Text);
                cmd.Parameters.AddWithValue("@EU", Login.User);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Expense Added");
                Con.Close();

                Clear();
            }
        }

        private void ExpCatTb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
