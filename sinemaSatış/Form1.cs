namespace sinemaSatış
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kasaTutar = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            int misir, su, cay, bilet, toplam;
            misir = Convert.ToInt16(TxtMisir.Text);
            su = Convert.ToInt16(TxtSu.Text);
            cay = Convert.ToInt16(TxtCay.Text);
            bilet = Convert.ToInt16(TxtBilet.Text);
            toplam = misir * 10 + su * 3 + cay * 5 + bilet * 20;

            LblToplam.Text = toplam.ToString();

            kasaTutar += toplam;

            LblKasa.Text = kasaTutar.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtMisir.Text = "";
            TxtSu.Text = "";
            TxtCay.Text = "";
            TxtBilet.Text = "";
            TxtMisir.Focus();



        }
    }
}
