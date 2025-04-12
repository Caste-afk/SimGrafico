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
    public partial class ChiamateTotali : Form
    {
        public ChiamateTotali(List <Ctelefonata> registro)
        {
            InitializeComponent();
            AggiungiGdv(registro);
        }

        private void AggiungiGdv(List <Ctelefonata> registro)
        {
            foreach(var telefonata in registro)
            {
                gdv_chiamate.Rows.Add(telefonata.numero, telefonata.durata);
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
