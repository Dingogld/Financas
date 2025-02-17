namespace Financas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        int starP = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            starP += 1;
            MyProgress.Value = starP;
            PercetageLbl.Text = starP + "%";
            if (MyProgress.Value == 100)
            {
                MyProgress.Value = 0;
                timer1.Stop();
                Login obj = new Login();
                this.Hide();
                obj.Show();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
