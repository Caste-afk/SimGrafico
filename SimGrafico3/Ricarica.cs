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
    public partial class Ricarica : Form
    {
        public double credito { get; set; }
        public Ricarica()
        {
            InitializeComponent();
        }

        private void btn_aggiungi_Click(object sender, EventArgs e)
        {
            credito = (double)nud_credito.Value;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_annulla_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
