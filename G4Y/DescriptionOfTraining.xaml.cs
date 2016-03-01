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
        private IMobileServiceTable<Klatka> todoTable = App.MobileService.GetTable<Klatka>();

 

        public async void a(int value) {
            var fname = String.Empty;
            this.list.Items.Clear();
             items = await todoTable.ToCollectionAsync();
            fname = items.First().Description;
            textBox1.Text = fname;
           // var query =  todoTable;
            // textBox.Text = Convert.ToString(items.ElementAt(1));
            this.list.ItemsSource = items;


           // textBox.Text = Convert.ToString(list.Items);
           // textBox1.Text = Convert.ToString(todoTable.WithParameters());

        }
       
       

        string path;
        SQLite.Net.SQLiteConnection conn;
        public DescriptionOfTraining()
        {
            this.InitializeComponent();
            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "db.sqlite");
            conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
            conn.CreateTable<SQLTrainig>();
            

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            int value = (int)e.Parameter;
            /*  var query = conn.Table<SQLTrainig>();
              string trainingName = String.Empty;
              string trainingDescription = String.Empty;

              foreach (var item in query)
              {
                  if (item.Id == value)
                  textBox.Text = String.Format( item.TrainingName);
                  textBox1.Text = String.Format(item.Description);

              }*/

            a(value);
            
        }
    }
}
