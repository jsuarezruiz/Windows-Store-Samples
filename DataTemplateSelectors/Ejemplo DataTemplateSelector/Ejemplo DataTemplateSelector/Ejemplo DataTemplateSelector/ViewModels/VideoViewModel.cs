using Ejemplo_DataTemplateSelector.Models;
using System.Collections.Generic;
using System.Linq;

namespace Ejemplo_DataTemplateSelector.ViewModels
{
    public class VideoViewModel
    {
        #region Privates

        public List<VideoByType> Items { get; set; }

        #endregion

        #region Constructor

        public VideoViewModel()
        {
            var films = new List<Video>
                             {
                                 new Video {Title = "Cadena perpetua", Image = "http://pics.filmaffinity.com/Cadena_perpetua-576140557-large.jpg", Type = VideoType.Film},
                                 new Video {Title = "El padrino", Image = "http://pics.filmaffinity.com/El_Padrino-485345341-large.jpg", Type = VideoType.Film},
                                 new Video {Title = "El padrino. Parte II", Image = "http://pics.filmaffinity.com/El_Padrino_Parte_II-807355469-large.jpg", Type = VideoType.Film},
                                 new Video {Title = "Pulp Fiction", Image = "http://pics.filmaffinity.com/Pulp_Fiction-586496431-large.jpg", Type = VideoType.Film},
                                 new Video {Title = "El bueno, el feo y el malo", Image = "http://pics.filmaffinity.com/El_bueno_el_feo_y_el_malo-589330734-large.jpg", Type = VideoType.Film},
                                 new Video {Title = "12 hombres sin piedad", Image = "http://pics.filmaffinity.com/12_hombres_sin_piedad_Doce_hombres_sin_piedad-290572645-large.jpg", Type = VideoType.Film},
                                 new Video {Title = "La lista de Schindler", Image = "http://pics.filmaffinity.com/La_lista_de_Schindler-803188900-large.jpg", Type = VideoType.Film},
                                 new Video {Title = "El caballero oscuro", Image = "http://pics.filmaffinity.com/El_caballero_oscuro-102763119-large.jpg", Type = VideoType.Film},
                                 new Video {Title = "El señor de los anillos: El retorno del rey", Image = "http://pics.filmaffinity.com/National_Geographic_Beyond_the_Movie_El_Senor_de_los_Anillos_El_Retorno_del_Rey_TV-916880961-large.jpg", Type = VideoType.Film},
                                 new Video {Title = "Dexter", Image = "http://www.zonadvd.com/imagenes/noticias/2008_10_paramount/dexter_frontal.jpg", Type = VideoType.Serie},
                                 new Video {Title = "Perdidos", Image = "http://www.zonadvd.com/imagenes/noticias/2005_12_bv/perdidos1_dvd.jpg", Type = VideoType.Serie},
                                 new Video {Title = "Prision Break", Image = "http://www.zonadvd.com/imagenes/noticias/2007_01_fox/prisonbreak1_dvd.jpg", Type = VideoType.Serie},
                                 new Video {Title = "Spartacus", Image = "http://www.zonadvd.com/imagenes/noticias/2011_10_fox/spartacus1_dvd.jpg", Type = VideoType.Serie},
                             };

            var videosByType = films.GroupBy(f => f.Type).Select(f => new VideoByType { Type = f.Key, Videos = f.ToList() });

            Items = videosByType.ToList();
        }

        #endregion
    }
}
