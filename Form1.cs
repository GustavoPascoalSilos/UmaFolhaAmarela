namespace MeuPrimeiroForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btn1.BackColor = Color.White;
            btn1.Text = "Branco";
            if (btn1.BackColor == Color.White)
            {
                btn1.BackColor = Color.DarkCyan;
                btn1.Text = "Ciano";
            }

            if (btn1.BackColor == Color.White)
            {
                btn1_MouseLeave(sender, e);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn1.BackColor = Color.Pink;
            btn1.Text = "Rosinha";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btn2.BackColor = Color.White;
            btn2.Text = "Branco";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            btn3.BackColor = Color.Brown;
            btn3.Text = "Marrom";

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }



        private void btn1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Turquoise;
        }

        private void btn2_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            this.BackColor = btn.BackColor;
        }

        private void mudaFundo(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            this.BackColor = btn.BackColor;
        }

        private void btn3_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void btn4_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }
    }
}