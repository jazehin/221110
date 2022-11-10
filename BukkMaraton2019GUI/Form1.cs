namespace BukkMaraton2019GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSzamol_Click(object sender, EventArgs e)
        {
            int m = int.Parse(cbTav.Text.Substring(cbTav.Text.Length - 4, 2)) * 1000;

            string[] t = tbIdo.Text.Split(":");
            TimeOnly time = new TimeOnly(Convert.ToInt32(t[0]), Convert.ToInt32(t[1]), Convert.ToInt32(t[2]));

            int s = time.Hour * 3600 + time.Minute * 60 + time.Second;

            double meterpersec = (double)m / s;
            double kilometerperora = meterpersec * 3.6;

            lblKmh.Text = String.Format("{0:0.00}", kilometerperora);
            lblMs.Text  = String.Format("{0:0.00}", meterpersec);
        }
    }
}