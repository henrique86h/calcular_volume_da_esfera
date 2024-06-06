using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcular_volume_da_esfera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxVolume_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Raio = Convert.ToInt32(textBoxRaio.Text);

            double Volume = (4 * 3.141592653 * Raio * Raio * Raio) / 3;

            lblVolume.Text = ("≅ " + Volume);
        }
    }
}
