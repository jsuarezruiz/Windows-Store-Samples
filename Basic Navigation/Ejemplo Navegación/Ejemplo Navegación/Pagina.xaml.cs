﻿using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Ejemplo_Navegación
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Pagina : Page
    {
        public Pagina()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Se invoca cuando esta página se va a mostrar en un objeto Frame.
        /// </summary>
        /// <param name="e">Datos de evento que describen cómo se llegó a esta página. La propiedad Parameter
        /// se usa normalmente para configurar la página.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var parametro = e.Parameter as string;

            if (parametro != null)
                tbParametro.Text = parametro;
        }
    }
}
