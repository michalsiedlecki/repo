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
    public sealed partial class Body : Page
    {
        private MobileServiceCollection<Dane, Dane> items;
        private IMobileServiceTable<Dane> resultsTable = App.MobileService.GetTable<Dane>();

        public Body()
        {
            this.InitializeComponent();
            getData();
        }

        
        private void button_Click(object sender, RoutedEventArgs e)
        {
            double obwod = Convert.ToDouble(textBox.Text);
            double masa = Convert.ToDouble(textBox1.Text);
            double a, b, c, d, f, wynik;

            a = 4.15 * obwod;
            b = a / 2.54;
            c = 0.082 * masa * 2.2;
            //mężczyźni
            if (radioButtonMan.IsChecked == true) {
                d = b - c - 98.42; }
            // kobiety
            else { d = b - c - 76.76; }
            f = masa * 2.2;
            wynik = d / f * 100;
            if (wynik < 0)  textBlock3.Text = "0"; 
            else textBlock3.Text = Convert.ToString(wynik);
            sendData(wynik);
            getData(); 
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

        public async void sendData(double arg)
        {
            Dane send = new Dane {result = Convert.ToString(arg)};
            await resultsTable.InsertAsync(send);
        }

        public async void getData()
        {
            items = await resultsTable.ToCollectionAsync();
            this.listData.ItemsSource = items;
        }
    }
}
