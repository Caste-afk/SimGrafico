using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimGrafico
{
    public partial class AggiungiTelefonata : Form
    {
        public int numero { set; get; }
        public TimeSpan durata { get; set; }
        public AggiungiTelefonata()
        {
            InitializeComponent();
        }

        private void tbx_numero_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numero = int.Parse(tbx_numero.Text);
            durata = dtp_durata.Value.TimeOfDay;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_annulla_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
