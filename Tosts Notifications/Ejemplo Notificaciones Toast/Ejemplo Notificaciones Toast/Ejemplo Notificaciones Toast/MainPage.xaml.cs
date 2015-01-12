using Windows.Data.Xml.Dom;
using Windows.UI.Notifications; //Notificaciones
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Ejemplo_Notificaciones_Toast
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

        private void btnSimpleToastNotification_Click(object sender, RoutedEventArgs e)
        {
            ToastTemplateType toastType = ToastTemplateType.ToastImageAndText02;
            XmlDocument toastXML = ToastNotificationManager.GetTemplateContent(toastType);
            XmlNodeList toastText = toastXML.GetElementsByTagName("text");
            XmlNodeList toastImages = toastXML.GetElementsByTagName("image");
            toastText[0].InnerText = "Título de la Notificación Toast";
            toastText[1].InnerText = "Texto de la Notificación Toast.";
            ((XmlElement)toastImages[0]).SetAttribute("src", "ms-appx:///Assets/Tile.png");
            ((XmlElement)toastImages[0]).SetAttribute("alt", "Imagen");

            ToastNotification toast = new ToastNotification(toastXML);
            ToastNotificationManager.CreateToastNotifier().Show(toast);
        }

        private void btnAdvancedToastNotification_Click(object sender, RoutedEventArgs e)
        {
            ToastTemplateType toastType = ToastTemplateType.ToastImageAndText02;
            XmlDocument toastXML = ToastNotificationManager.GetTemplateContent(toastType);
            XmlNodeList toastText = toastXML.GetElementsByTagName("text");
            XmlNodeList toastImages = toastXML.GetElementsByTagName("image");
            toastText[0].InnerText = "Título de la Notificación Toast";
            toastText[1].InnerText = "Texto de la Notificación Toast.";
            ((XmlElement)toastImages[0]).SetAttribute("src", "ms-appx:///Assets/Tile.png");
            ((XmlElement)toastImages[0]).SetAttribute("alt", "Imagen");

            IXmlNode toastNode = toastXML.SelectSingleNode("/toast");
            ((XmlElement)toastNode).SetAttribute("duration", "long");
            XmlElement audioNode = toastXML.CreateElement("audio");
            audioNode.SetAttribute("src", "ms-winsoundevent:Notification.Looping.Alarm");
            audioNode.SetAttribute("loop", "true");
            toastNode.AppendChild(audioNode);
            ((XmlElement)toastNode).SetAttribute("launch", "<cat state='angry'><facebite state='true' /></cat>");

            ToastNotification toast = new ToastNotification(toastXML);
            ToastNotificationManager.CreateToastNotifier().Show(toast);
        }
    }
}
