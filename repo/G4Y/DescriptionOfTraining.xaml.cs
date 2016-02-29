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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace G4Y
{
    public sealed partial class DescriptionOfTraining : Page
    {
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
            var query = conn.Table<SQLTrainig>();
            string trainingName = String.Empty;
            string trainingDescription = String.Empty;

            foreach (var item in query)
            {
                if (item.Id == value)
                textBox.Text = String.Format( item.TrainingName);
                textBox1.Text = String.Format(item.Description);
                
            }
            
            
        }
    }
}
