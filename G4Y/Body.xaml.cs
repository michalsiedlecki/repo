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
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Body : Page
    {
        public Body()
        {
            this.InitializeComponent();
        }

        
        private void button_Click(object sender, RoutedEventArgs e)
        {
            double obwod = Convert.ToDouble(textBox.Text);
            double masa = Convert.ToDouble(textBox1.Text);
            double a, b, c, d, f, wynik;

            a = 4.15 * obwod;
            b = a / 2.54;
            c = 0.082 * masa * 2.2;
            d = b - c - 98.42;
            //(dla kobiet b – c - 76, 76)
            f = masa * 2.2;
            wynik = d / f * 100;
            if (wynik < 0)  textBlock3.Text = "0"; 
            else textBlock3.Text = Convert.ToString(wynik); 
        }
    }
}
