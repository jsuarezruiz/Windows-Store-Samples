using System.Collections.Generic;

namespace Ejemplo_DataTemplateSelector.Models
{
    public class VideoByType
    {
        public VideoType Type { get; set; }
        public List<Video> Videos { get; set; }
    }
}
