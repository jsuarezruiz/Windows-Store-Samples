using Ejemplo_Gráficas.Models;
using System.Collections.Generic;

namespace Ejemplo_Gráficas.ViewModels
{
    public class ChartViewModel
    {
        #region Constructor

        public ChartViewModel()
        {
            var items = new List<ChartItem>
            {
                new ChartItem { Name = "Enero", Value = 766},
                new ChartItem { Name = "Febrero", Value = 231},
                new ChartItem { Name = "Marzo", Value = 544},
                new ChartItem { Name = "Abril", Value = 11},
                new ChartItem { Name = "Mayo", Value = 112},
                new ChartItem { Name = "Junio", Value = 122},
                new ChartItem { Name = "Julio", Value = 332},
                new ChartItem { Name = "Agosto", Value = 662},
                new ChartItem { Name = "Septiembre", Value = 743},
                new ChartItem { Name = "Octubre", Value = 819},
                new ChartItem { Name = "Noviembre", Value = 923},
                new ChartItem { Name = "Diciembre", Value = 1232},
            };

            ChartItems = items;
        }

        #endregion

        #region Properties

        public List<ChartItem> ChartItems { get; set; }

        #endregion
    }
}
