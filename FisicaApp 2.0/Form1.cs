namespace FisicaApp_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Henrique Mazeto (16), Enzo Rodrigues (7), Felipe Padson (10)");
        }
        decimal media(decimal s, decimal t)
        {
            return s / t;
        }

        private void btVelo_Click(object sender, EventArgs e)
        {
            decimal espaco, tempo;
            espaco = num1.Value;
            tempo = num2.Value;
            if (espaco == 0 && tempo == 0)
            {
                MessageBox.Show("Coloque uma velocidade maior que 0!");
            }
            else
            {
                decimal velo = media(espaco, tempo);
                lblResult.Text = velo.ToString("0.0");

            }
        }
        decimal Acel(decimal V0, decimal VF, decimal T0, decimal TF)
        {
            return (V0 - VF) / (T0 - TF);
        }
        private void btAce_Click(object sender, EventArgs e)
        {
            decimal V0, VF, T0, TF ;
            V0 = num1.Value;
            VF = num2.Value;
            T0 = num3.Value;
            TF = num4.Value;
            decimal AcelR = Acel(V0, VF, T0, TF);
            lblResult.Text = AcelR.ToString("0.0");
        }
        decimal uni(decimal s0, decimal v, decimal t)
        {
            return (s0 + v * t);
        }

        private void btMovi_Click(object sender, EventArgs e)
        {
            decimal s0, v, t;
            s0 = num1.Value;
            v = num2.Value;
            t = num3.Value;
            decimal mov = uni (s0, v, t);
            lblResult.Text = mov.ToString("0.0");
        }
        decimal celli(decimal v0, decimal a, decimal s)
        {
            return (v0 * v0) + (2 * a * s);
        }

        private void btTorri_Click(object sender, EventArgs e)
        {
            decimal v0, a, s;
            v0 = num1.Value;
            a = num2.Value;
            s = num3.Value;
            decimal torri = celli (v0, a, s);
            lblResult.Text = torri.ToString("0.0");
        }

        private void num1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void num2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void lblInterface_Click(object sender, EventArgs e)
        {

        }
    }
}
