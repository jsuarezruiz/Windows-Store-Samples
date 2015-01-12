using Ejemplo_Zoom_Semantico.ViewModels;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Ejemplo_Zoom_Semantico
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class FilmView : Page
    {
        private FilmViewModel _viewModel;
        public FilmView()
        {
            this.InitializeComponent();

            _viewModel = new FilmViewModel();
            this.DataContext = _viewModel;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var collectionGroups = groupedFilmsViewSource.View.CollectionGroups;
            ((ListViewBase)this.ZoomSemantico.ZoomedOutView).ItemsSource = collectionGroups;
        }
    }
}
