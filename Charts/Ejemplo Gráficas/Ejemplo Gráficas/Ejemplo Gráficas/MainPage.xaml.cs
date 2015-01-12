using Ejemplo_Gráficas.ViewModels;
using Windows.UI.Xaml.Controls;

namespace Ejemplo_Gráficas
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            DataContext = new ChartViewModel();
        }
    }
}
