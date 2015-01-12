using Ejemplo_Snap_View.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Snap_View.ViewModels
{
    class SnapViewModel
    {
        public List<Film> Items { get; set; }

        public SnapViewModel()
        {
            var films = new List<Film>
                             {
                                 new Film {Title = "Cadena perpetua", Image = "http://pics.filmaffinity.com/Cadena_perpetua-576140557-large.jpg"},
                                 new Film {Title = "El padrino", Image = "http://pics.filmaffinity.com/El_Padrino-485345341-large.jpg"},
                                 new Film {Title = "El padrino. Parte II", Image = "http://pics.filmaffinity.com/El_Padrino_Parte_II-807355469-large.jpg"},
                                 new Film {Title = "Pulp Fiction", Image = "http://pics.filmaffinity.com/Pulp_Fiction-586496431-large.jpg"},
                                 new Film {Title = "El bueno, el feo y el malo",Image = "http://pics.filmaffinity.com/El_bueno_el_feo_y_el_malo-589330734-large.jpg"},
                                 new Film {Title = "12 hombres sin piedad", Image = "http://pics.filmaffinity.com/12_hombres_sin_piedad_Doce_hombres_sin_piedad-290572645-large.jpg"},
                                 new Film {Title = "La lista de Schindler", Image = "http://pics.filmaffinity.com/La_lista_de_Schindler-803188900-large.jpg"},
                                 new Film {Title = "El caballero oscuro", Image = "http://pics.filmaffinity.com/El_caballero_oscuro-102763119-large.jpg"},
                                 new Film {Title = "El señor de los anillos: El retorno del rey", Image = "http://pics.filmaffinity.com/National_Geographic_Beyond_the_Movie_El_Senor_de_los_Anillos_El_Retorno_del_Rey_TV-916880961-large.jpg"},
                             };

            Items = films;
        }
    }
}
