using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaReproduccion_G3_2022_I
{
    public partial class FormAgregar : Form
    {
        public delegate void DelegadoMusica(Musica musica);
        public event DelegadoMusica EnviarMusica;
        public FormAgregar()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EnviarMusica(new Musica(txtbCancion.Text,txtbArtista.Text,txtbAlbum.Text));
            txtbCancion.Clear();
            txtbAlbum.Clear();
            txtbArtista.Clear();
        }
    }
}
