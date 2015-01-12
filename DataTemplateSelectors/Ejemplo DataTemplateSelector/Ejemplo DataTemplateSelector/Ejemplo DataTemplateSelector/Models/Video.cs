
namespace Ejemplo_DataTemplateSelector.Models
{
    public enum VideoType
    {
        Film,
        Serie
    }

    public class Video
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public VideoType Type { get; set; }
    }
}
