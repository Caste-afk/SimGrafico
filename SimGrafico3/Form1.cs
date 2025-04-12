namespace SimGrafico
{
    public partial class Form1 : Form
    {
        public CSim sim;
        public Form1()
        {
            InitializeComponent();
            CreaSim();
            lbl_numero.Text += sim.numero;
            lbl_credito.Text += sim.credito;
        }

        private void CreaSim()
        {
            int numero = 0;
            double credito = 0;
            using (AggiungiSim agg = new AggiungiSim())
            {
                if (agg.ShowDialog() == DialogResult.OK)
                {
                    numero = agg.numero;
                    credito = agg.credito;
                    sim = new CSim(numero, credito);
                }
            }
        }

        private void btn_ricarica_Click(object sender, EventArgs e)
        {
            using (Ricarica ricarica = new Ricarica())
            {
                if (ricarica.ShowDialog() == DialogResult.OK)
                {
                    sim.credito += ricarica.credito;
                }
            }
            lbl_credito.Text = $"Credito della sim: {Math.Round(sim.credito, 2):0.00}";
        }

        private void btn_agg_Click(object sender, EventArgs e)
        {
            using (AggiungiTelefonata agg = new AggiungiTelefonata())
            {
                if (agg.ShowDialog() == DialogResult.OK)
                {
                    sim.AggiungiChiamata(agg.numero, agg.durata);
                }
            }
            lbl_credito.Text = $"Credito della sim: {sim.credito}";
        }

        private void btn_durata_Click(object sender, EventArgs e)
        {
            using (Durata form = new Durata(sim.registrochiamate))
            {
                if (form.ShowDialog() == DialogResult.OK)
                { }
            }
        }

        private void btn_chiamate_Click(object sender, EventArgs e)
        {
            using (ChiamateTotali form = new ChiamateTotali(sim.registrochiamate))
            {
                if (form.ShowDialog() == DialogResult.OK)
                { }
            }
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sim.Info());
        }
    }
}
