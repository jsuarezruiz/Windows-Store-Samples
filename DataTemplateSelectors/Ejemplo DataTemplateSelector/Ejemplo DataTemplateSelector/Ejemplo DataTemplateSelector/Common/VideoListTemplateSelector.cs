using Ejemplo_DataTemplateSelector.Models;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Ejemplo_DataTemplateSelector
{
    public class VideoListTemplateSelector : DataTemplateSelector
    {
        protected override Windows.UI.Xaml.DataTemplate SelectTemplateCore(object item, Windows.UI.Xaml.DependencyObject container)
        {
            if (item != null)
            {
                var video = item as Video;

                if (video != null)
                {
                    var currentFrame = Window.Current.Content as Frame;
                    var currentPage = currentFrame.Content as Page;

                    if (video.Type.Equals(VideoType.Film))
                        return currentPage.Resources["FilmItemTemplate"] as DataTemplate;
                    else
                        return currentPage.Resources["SerieItemTemplate"] as DataTemplate;
                }
            }

            return base.SelectTemplateCore(item, container);
        }
    }
}
