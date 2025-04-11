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
            lbl_credito.Text = $"Credito della sim: {sim.credito.ToString()}";
        }

        private void btn_agg_Click(object sender, EventArgs e)
        {
        }
    }
}
