using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.WindowsAzure.MobileServices;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace G4Y
{
    public sealed partial class DescriptionOfTraining : Page
    {
       //private List<Klatka> items;
        private MobileServiceCollection<Klatka, Klatka> items;
        private IMobileServiceTable<Klatka> trainingTable = App.MobileService.GetTable<Klatka>();
        
        public async void getData(int value) {
            var name = String.Empty;
            var description = String.Empty;
            items = await trainingTable.Where(x => x.id.Contains(Convert.ToString(value))).ToCollectionAsync();
            name = items.First().Name;
            description = items.First().Description;
            textBox.Text = name;
            textBox1.Text = description; 
        }

        // Wypisywanie z SQLite
       // string path;
        //SQLite.Net.SQLiteConnection conn;
        public DescriptionOfTraining()
        {
            this.InitializeComponent();
           // path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "db.sqlite");
          //  conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
           // conn.CreateTable<SQLTrainig>();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            int value = (int)e.Parameter;
           
            // Wypisywanie z SQLite
            /*  var query = conn.Table<SQLTrainig>();
              string trainingName = String.Empty;
              string trainingDescription = String.Empty;

              foreach (var item in query)
              {
                  if (item.Id == value)
                  textBox.Text = String.Format( item.TrainingName);
                  textBox1.Text = String.Format(item.Description);

              }*/

            getData(value);      
        }

        private void buttonShowPanel_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
            if (!MySplitView.IsPaneOpen)
                buttonShowPanel.Content = "\uE00E";
            else
                buttonShowPanel.Content = "\uE00F";
        }

        private void TextBlock_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Body));
        }

        private void Back_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (Frame.CanGoBack) Frame.GoBack();

        }

        private void TrainingMenu_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Trainings));
        }
    }
}
