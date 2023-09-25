using System;
using System.Drawing;
using System.Windows.Forms;

namespace Reproductor
{
    public partial class frmPrincipal : Form
    {
        frmCancion Cancion;
        frmReproductor Reproductor;

        public frmPrincipal()
        {
            InitializeComponent();

            Cancion = new frmCancion()
            {
                TopLevel = false,
                Parent = this,
                FormBorderStyle = FormBorderStyle.None,
                Location = new Point(0, msPrincipal.Height),
            };

            Reproductor = new frmReproductor()
            {
                TopLevel = false,
                Parent = this,
                FormBorderStyle = FormBorderStyle.None,
                Location = new Point(0, msPrincipal.Height),
            };

            Cancion.Show();

        }

        private void listaDeCancionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cancion.Show();
            Reproductor.Hide();
        }

        private void reproductorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reproductor.Show();
            Cancion.Hide();
        }
    }
}
