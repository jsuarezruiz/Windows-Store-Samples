using System;
using System.IO;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238
namespace Ejemplo_SQLite
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            InitDB();
        }

        private async void InitDB()
        {
            var dbPath = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "books.sqlite");
            using (var db = new SQLite.SQLiteConnection(dbPath))
            {
                db.CreateTable<Book>();

                db.RunInTransaction(() =>
                {
                    db.Insert(new Book() { Title = "Windows Phone 7.5 Mango - Desarrollo Silverlight", Author = "Josué Yeray Julián" });
                    db.Insert(new Book() { Title = "Trabajando en equipo con Visual Studio ALM ", Author = "Bruno Capuano" });
                });

                int NumBooks1 = db.Table<Book>().Count();
                int NumBooks2 = db.ExecuteScalar<int>("SELECT COUNT(ID) FROM Book");

                MessageDialog message = new MessageDialog(string.Format("Número de libros: {0}", NumBooks1));
                await message.ShowAsync();
            }
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }

    public class Book
    {
        [SQLite.AutoIncrement, SQLite.PrimaryKey]
        public int ID { get; set; }

        [SQLite.MaxLength(256)]
        public string Title { get; set; }

        [SQLite.MaxLength(256)]
        public string Author { get; set; }
    }
}
