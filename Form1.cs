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
    public partial class Form1 : Form
    {

        List<Musica> canciones;
        public Form1()
        {
            InitializeComponent();

            canciones = new List<Musica>();
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cargarCanciones();
            foreach(Musica cancion in canciones )
            {
                lstbCanciones.Items.Add(cancion.Cancion);
            }
        }

        public void cargarCanciones()
        {

            canciones.Add(new Musica("Para siempre","Silvano Estrada"," Para Siempre-Single" ));
            canciones.Add(new Musica("If you were Gone", "Alexander Rybak", "Fairytales"));

        }

        private void lstbCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbCancion.Text = canciones[lstbCanciones.SelectedIndex].Cancion;
            lbArtista.Text = canciones[lstbCanciones.SelectedIndex].Artista;
            lbAlbum.Text = canciones[lstbCanciones.SelectedIndex].Album;

        }
    }
}
