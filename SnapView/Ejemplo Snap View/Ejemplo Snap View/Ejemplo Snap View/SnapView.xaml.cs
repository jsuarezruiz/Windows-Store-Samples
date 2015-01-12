using Ejemplo_Snap_View.ViewModels;
using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

// La plantilla de elemento Página de elementos está documentada en http://go.microsoft.com/fwlink/?LinkId=234233

namespace Ejemplo_Snap_View
{
    /// <summary>
    /// Página en la que se muestra una colección de vistas previas de elementos. En la aplicación dividida, esta página
    /// se usa para mostrar y seleccionar uno de los grupos disponibles.
    /// </summary>
    public sealed partial class SnapView : Ejemplo_Snap_View.Common.LayoutAwarePage
    {
        public SnapView()
        {
            this.InitializeComponent();

            DataContext = new SnapViewModel();
        }

        /// <summary>
        /// Rellena la página con el contenido pasado durante la navegación. Cualquier estado guardado se
        /// proporciona también al crear de nuevo una página a partir de una sesión anterior.
        /// </summary>
        /// <param name="navigationParameter">Valor de parámetro pasado a
        /// <see cref="Frame.Navigate(Type, Object)"/> cuando se solicitó inicialmente esta página.
        /// </param>
        /// <param name="pageState">Diccionario del estado mantenido por esta página durante una sesión
        /// anterior. Será null la primera vez que se visite una página.</param>
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
            // TODO: Asignar una colección de elementos enlazable a this.DefaultViewModel["Items"]
        }
    }
}
