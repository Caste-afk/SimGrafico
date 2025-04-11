using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimGrafico
{
    public partial class AggiungiSim : Form
    {
        public int numero { get; set; }
        public double credito { get; set; }
        public AggiungiSim()
        {
            InitializeComponent();
        }

        private void btn_aggiungi_Click(object sender, EventArgs e)
        {
            numero = int.Parse(tbx_numero.Text);
            credito = double.Parse(tbx_credito.Text);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_annulla_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbx_numero_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbx_credito_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                if (e.KeyChar == ',' && !tbx_credito.Text.Contains(","))
                {
                    return;
                }
                e.Handled = true;
            }
        }

        private void AggiungiSim_Load(object sender, EventArgs e)
        {

        }
    }
}
