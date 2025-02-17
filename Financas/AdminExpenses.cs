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
    public partial class AdminExpenses : Form
    {
        public AdminExpenses()
        {
            InitializeComponent();
            ShowExpenses();
            
        }

        SqlConnection Con = new SqlConnection("Data Source=W3283439;Initial Catalog=ExpenseOb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        private void ShowExpenses()
        {
            Con.Open();
            string Query = "Select * from ExpenseTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ExpensesDGV.DataSource = ds.Tables[0];
            Con.Close();

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExpensesDGVFake2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
