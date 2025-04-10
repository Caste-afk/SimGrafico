namespace SimGrafico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_CreaSim_Click(object sender, EventArgs e)
        {
            int numero =0;
            double credito=0;
            using (AggiungiSim agg = new AggiungiSim())
            {
                if (agg.ShowDialog() == DialogResult.OK)
                {
                    numero = agg.numero;
                    credito = agg.credito;
                    CSim sim = new CSim(numero, credito);
                }
            }
        }
    }
}
