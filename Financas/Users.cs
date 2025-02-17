using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace Financas
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            UserDGV.AllowUserToAddRows = false;
            ShowUser();
        }

        SqlConnection Con = new SqlConnection("Data Source=W3283439;Initial Catalog=ExpenseOb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        private void ShowUser()
        {
            Con.Open();
            string Query = "Select * from UserTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UserDGV.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void Clear()
        {
            UnameTb.Text = "";
            UPasswordTb.Text = "";
            UPhoneTb.Text = "";
            AddressTb.Text = "";
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || UPhoneTb.Text == "" || UPasswordTb.Text == "" || AddressTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into UserTbl (Uname,UDOB,UPhone,UPass,UAddress) values(@UN,@UD,@UP,@UPA,@UA)", Con);
                cmd.Parameters.AddWithValue("@UN", UnameTb.Text);
                cmd.Parameters.AddWithValue("@UD", UDOB.Value.Date);
                cmd.Parameters.AddWithValue("@UP", UPhoneTb.Text);
                cmd.Parameters.AddWithValue("@UPA", UPasswordTb.Text);
                cmd.Parameters.AddWithValue("@UA", AddressTb.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Add");
                Con.Close();
                ShowUser();
                Clear();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            AdminExpenses obj = new AdminExpenses();
            obj.Show();
            this.Hide();
        }
    }

}
