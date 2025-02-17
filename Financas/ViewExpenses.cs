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
    public partial class ViewExpenses : Form
    {
        public ViewExpenses()
        {
            InitializeComponent();
            ExpenseDGV.AllowUserToAddRows = false;
            ShowExp();
        }

        SqlConnection Con = new SqlConnection("Data Source=W3283439;Initial Catalog=ExpenseOb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        private void ShowExp()
        {
            Con.Open();
            string Query = "Select * from ExpenseTbl where ExpUser='" + Login.User + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ExpenseDGV.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void FilterByCat()
        {
            Con.Open();
            string Query = "Select * from ExpenseTbl where ExpUser='" + Login.User + "' and ExCat= '" + ExpCatTb.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ExpenseDGV.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ExpenseDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ShowExp();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ViewExpenses_Load(object sender, EventArgs e)
        {

        }

        private void ExpCatTb_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterByCat();
        }
    }
}
