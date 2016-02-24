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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace D9T3
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




        private void button_Click(object sender, RoutedEventArgs e)
        {
            double L = double.Parse(leveys.Text);
            double H = double.Parse(korkeus.Text);
            double W = double.Parse(karmileveys.Text);
            double A1 = L * H;
            double A2 = (L - (W * 2)) * (H - (W * 2));
            ikkunapinta.Text = A1.ToString();
            lasipinta.Text = A2.ToString();
            karmipinta.Text = (L * 2 + H * 2).ToString();

        }

        private void leveys_TextChanged(object sender, TextChangedEventArgs e)
        {
            double lev = 0;
            
            if (double.TryParse(leveys.Text, out lev))
            {
                border.Width = lev/10;
            }
            

        }

        private void korkeus_TextChanged(object sender, TextChangedEventArgs e)
        {
            double kor = 0;

            if (double.TryParse(korkeus.Text, out kor))
            {
                border.Height = kor/10;
            }

        }

        private void karmileveys_TextChanged(object sender, TextChangedEventArgs e)
        {
            double kor = 0;

            if (double.TryParse(karmileveys.Text, out kor))
            {
                border.BorderThickness = new Thickness(kor / 10);
            }

            
        }
    }
}
