using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public sealed partial class Trainings : Page
    {
        string path;
        SQLite.Net.SQLiteConnection conn;


        public Trainings()
        {
            this.InitializeComponent();
            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "db.sqlite");
            conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
            conn.CreateTable<SQLTrainig>();
            ShowAll();
        }

        private void ShowAll()
        {
            //Dodanie rekordu
            //var add = conn.Insert(new SQLTrainig() { TrainingName = "Wiatrak", Description = "Musisz zrobci dsadasd dasd" });
    
            var query = conn.Table<SQLTrainig>();
            string result = String.Empty;
            foreach (var item in query)
                {
                result = String.Format("{0} : {1}", item.Id, item.TrainingName, item.Description);
                Debug.WriteLine(result);
                }
        }

        
        private void buttonKlatkaPlasko_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DescriptionOfTraining), 1);
        }

        private void buttonKlatkaSkosGora_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DescriptionOfTraining), 2);
        }

        private void buttonKlatkaSkosDol_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DescriptionOfTraining), 3);
        }

        private void buttonKlatkaRozpietki_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DescriptionOfTraining), 4);
        }

        private void buttonKlatkaPompki_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DescriptionOfTraining), 5);
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
