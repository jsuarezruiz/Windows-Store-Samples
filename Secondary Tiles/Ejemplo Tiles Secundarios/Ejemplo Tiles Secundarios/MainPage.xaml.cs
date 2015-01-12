using System;
using System.Linq;
using Windows.Foundation;
using Windows.UI.Popups;
using Windows.UI.StartScreen;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Ejemplo_Tiles_Secundarios
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private static Rect GetElementRect(FrameworkElement element)
        {
            GeneralTransform buttonTransform = element.TransformToVisual(null);
            Point point = buttonTransform.TransformPoint(new Point());
            return new Rect(point, new Size(element.ActualWidth, element.ActualHeight));
        }

        private async void BtnCreateClick(object sender, RoutedEventArgs e)
        {
            var tileID = "TileSecundario.1";
            var shortName = "Tile Secundario";
            var displayName = "Prueba de TileSecundario";
            var secondaryTileArg = "test";
            var squareLogo = new System.Uri("ms-appx:///Assets/Logo.png");
            var tileOptions = TileOptions.ShowNameOnLogo;

            var secondarytile = new SecondaryTile(tileID, shortName, displayName, secondaryTileArg, tileOptions, squareLogo);

            bool isPinned = await secondarytile.RequestCreateForSelectionAsync(GetElementRect((FrameworkElement)sender), Placement.Below);

            if (isPinned)
            {
                MessageDialog infoSecondaryTile = new MessageDialog("Tile Secundario creado con éxito!");
                await infoSecondaryTile.ShowAsync();
            }
        }

        private async void BtnDeleteClick(object sender, RoutedEventArgs e)
        {
            if (SecondaryTile.Exists("TileSecundario.1"))
            {
                var tiles = await SecondaryTile.FindAllAsync();
                SecondaryTile tile = tiles.FirstOrDefault(d => d.TileId == "TileSecundario.1");

                bool isUnpinned = await tile.RequestDeleteForSelectionAsync(GetElementRect((FrameworkElement)sender), Windows.UI.Popups.Placement.Below);

                //Otra forma de hacerlo:
                //bool isUnpinned = await tile.RequestDeleteAsync();

                if (isUnpinned)
                {
                    MessageDialog infoSecondaryTile = new MessageDialog("Tile Secundario eliminado con éxito!");
                    await infoSecondaryTile.ShowAsync();
                }
            }
        }
    }
}
