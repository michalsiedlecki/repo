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


        public Trainings()
        {
            this.InitializeComponent();
            
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
        private void buttonPlecyDrazek_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DescriptionOfTraining), 6);
        }

        private void buttonPlecyWioslowanieSztanga_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DescriptionOfTraining), 7);
        }

        private void buttonPlecyWioslowanieHantla_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DescriptionOfTraining), 8);
        }

        private void buttonPlecyRzymska_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DescriptionOfTraining), 9);
        }

        private void buttonPlecyMartwyCiag_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DescriptionOfTraining), 10);
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

        private void buttonBarkiWyciskanie_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DescriptionOfTraining), 11);
        }

        private void buttonBarkiUnoszenie_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DescriptionOfTraining), 12);
        }

        private void buttonBarkiOpad_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DescriptionOfTraining), 13);
        }

        private void buttonBarkiPodciaganie_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DescriptionOfTraining), 14);
        }

        private void buttonBarkiPrzod_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DescriptionOfTraining), 15);
        }

        private void buttonNogiPrzysiady_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DescriptionOfTraining), 16);
        }

        private void buttonNogiProstowanie_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DescriptionOfTraining), 17);
        }

        private void buttonNogiUginanie_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DescriptionOfTraining), 18);
        }

        private void buttonNogiWykroki_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DescriptionOfTraining), 19);
        }

        private void buttonNogiStep_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DescriptionOfTraining), 20);
        }

        private void buttonBicUginanie_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DescriptionOfTraining), 21);
        }

        private void buttonBicModlitewnik_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DescriptionOfTraining), 22);
        }

        private void buttonTricProstowanie_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DescriptionOfTraining), 23);
        }

        private void buttonTricFrancuz_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DescriptionOfTraining), 24);
        }
    }
}
