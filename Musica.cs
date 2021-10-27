
namespace ListaReproduccion_G3_2022_I
{
    public class Musica
    {
        #region Atributos
        private string cancion;
        private string artista;
        private string album;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor que asigna los datos de la canción
        /// </summary>
        /// <param name="cancion">Nombre de la canción</param>
        /// <param name="artista">Nombre del artísta</param>
        /// <param name="album">Nombre del álbum</param>
        public Musica(string cancion, string artista, string album)
        {
            Cancion = cancion;
            Artista = artista;
            Album = album;
        }
        #endregion

        #region  Propiedades
        public string Cancion { get => cancion; set => cancion = value; }
        public string Artista { get => artista; set => artista = value; }
        public string Album { get => album; set => album = value; }
        #endregion
    }
}
