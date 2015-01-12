using Ejemplo_Zoom_Semantico.Models;
using System.Collections.Generic;
using System.Linq;

namespace Ejemplo_Zoom_Semantico.ViewModels
{
    public class FilmViewModel
    {
        #region Constructor

        public FilmViewModel()
        {
            var films = new List<Film>
                             {
                                 new Film {FilmID = 1, Title = "El caballero oscuro: La leyenda renace", Year = 2012, Image = "http://ia.media-imdb.com/images/M/MV5BMTk4ODQzNDY3Ml5BMl5BanBnXkFtZTcwODA0NTM4Nw@@._V1._SY317_.jpg"},
                                 new Film {FilmID = 2, Title = "Cisne Negro", Year = 2011, Image = "http://ia.media-imdb.com/images/M/MV5BNzY2NzI4OTE5MF5BMl5BanBnXkFtZTcwMjMyNDY4Mw@@._V1._SY317_.jpg"},
                                 new Film {FilmID = 3, Title = "Drive", Year = 2011, Image = "http://ia.media-imdb.com/images/M/MV5BOTM1ODQ0Nzc4NF5BMl5BanBnXkFtZTcwMTM0MjQyNg@@._V1._SY317_.jpg"},
                                 new Film {FilmID = 4, Title = "Toy Story 3", Year = 2010, Image = "http://ia.media-imdb.com/images/M/MV5BMTgxOTY4Mjc0MF5BMl5BanBnXkFtZTcwNTA4MDQyMw@@._V1._SY317_CR5,0,214,317_.jpg"},
                                 new Film {FilmID = 5, Title = "El discurso del rey", Year = 2010, Image = "http://ia.media-imdb.com/images/M/MV5BMzU5MjEwMTg2Nl5BMl5BanBnXkFtZTcwNzM3MTYxNA@@._V1._SY317_CR1,0,214,317_.jpg"},
                                 new Film {FilmID = 6, Title = "Origen", Year = 2010, Image = "http://ia.media-imdb.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1._SY317_.jpg"},
                             };


            var filmsByYear = films.GroupBy(f => f.Year).Select(f => new FilmYear { Year = f.Key, Films = f.ToList() });

            Films = filmsByYear.ToList();
        }

        #endregion

        #region Properties

        public List<FilmYear> Films { get; set; }

        #endregion
    }
}
