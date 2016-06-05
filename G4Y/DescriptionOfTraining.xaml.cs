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
using XamlAnimatedGif;

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

        public void gif(int value)
        {
            string path = "ms-appx:///Assets/"+value+".gif";
            var uri = new Uri(path);
            AnimationBehavior.SetSourceUri(Image, uri);
        }
        public DescriptionOfTraining()
        {
            this.InitializeComponent();
            
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            int value = (int)e.Parameter;
             getData(value);
             gif(value);      
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
