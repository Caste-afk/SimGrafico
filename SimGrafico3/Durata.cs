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
    public partial class Durata : Form
    {
        int numero;
        private List<Ctelefonata> _registro;
        public Durata(List<Ctelefonata> registro)
        {
            InitializeComponent();
            _registro = registro;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            numero = int.Parse(tbx_numero.Text);
            ControllaRegistro(numero);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ControllaRegistro(int numero)
        {
            string tot = "numeri trovati: \n";
            bool trovato = false;
            foreach (var telefonata in _registro)
            {
                if (telefonata.numero == numero)
                {
                    trovato = true;
                    tot += $"{numero}, {telefonata.durata}\n";
                }
            }

            if (!trovato)
            {
                tot = "nessuna chiamata trovata!";
            }

            MessageBox.Show(tot);
        }

        private void btn_annulla_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
