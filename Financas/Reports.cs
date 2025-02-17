using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financas
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
            getMaxExp();
            getMinExp();
            getTotExp();
            getAvgExp();
            getBestCat();
            getMinCat();
        }

        SqlConnection Con = new SqlConnection("Data Source=W3283439;Initial Catalog=ExpenseOb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        private void getMaxExp()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Max(ExpAmt) from ExpenseTbl where ExpUser= '" + Login.User + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Maxlbl.Text = "Rs" + dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void getMinExp()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Min(ExpAmt) from ExpenseTbl where ExpUser= '" + Login.User + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Minlbl.Text = "Rs" + dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void getTotExp()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Sum(ExpAmt) from ExpenseTbl where ExpUser= '" + Login.User + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Totlbl.Text = "Rs" + dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void getTotExpByCat()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Sum(ExpAmt) from ExpenseTbl where ExpUser= '" + Login.User + "' and ExCat='" + Catcb.SelectedItem.ToString() + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            TotByCatLbl.Text = "Rs" + dt.Rows[0][0].ToString();
            TotByCatLbl.Visible = true;
            Con.Close();
        }

        private void getBestCat()
        {
            Con.Open();
            string InnerQuery = "select Max(ExpAmt) from ExpenseTbl";
            DataTable dt1 = new DataTable();
            SqlDataAdapter sda1 = new SqlDataAdapter(InnerQuery, Con);
            sda1.Fill(dt1);
            string Query = "select ExCat from ExpenseTbl where ExpAmt = '" + dt1.Rows[0][0].ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            HighCatlbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void getMinCat()
        {
            Con.Open();
            string InnerQuery = "select Min(ExpAmt) from ExpenseTbl";
            DataTable dt1 = new DataTable();
            SqlDataAdapter sda1 = new SqlDataAdapter(InnerQuery, Con);
            sda1.Fill(dt1);
            string Query = "select ExCat from ExpenseTbl where ExpAmt = '" + dt1.Rows[0][0].ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            LowCatlbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void getAvgExp()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Sum(ExpAmt) from ExpenseTbl where ExpUser= '" + Login.User + "'", Con);
            SqlDataAdapter sda1 = new SqlDataAdapter("select Count(*) from ExpenseTbl where ExpUser= '" + Login.User + "'", Con);


            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            sda.Fill(dt);
            sda1.Fill(dt1);
            Double Avg = Convert.ToDouble(dt.Rows[0][0].ToString()) / Convert.ToDouble(dt1.Rows[0][0].ToString());
            Avglbl.Text = "Rs" + Avg;
            CountLbl.Text = dt1.Rows[0][0].ToString() + "Expenses";
            Con.Close();
        }



        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minlbl_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Catcb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getTotExpByCat();
        }
    }
}
