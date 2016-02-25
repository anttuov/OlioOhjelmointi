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

namespace D10T3
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

        public List<int> ArvoNumerot(int max, Random r, int nums)
        {
            
            int numero;
            List<int> rivi2 = new List<int>();
            for (int i = 0; i < nums; i++)
            {
                do
                {
                    numero = r.Next(1, max+1);
                } while (rivi2.Contains(numero) == true);

                rivi2.Add(numero);
            }
            rivi2.Sort();
            return rivi2;

        }

        private void draw_Click(object sender, RoutedEventArgs e)
        {
            string valinta = comboBox.SelectedValue.ToString();
            string rivitxt = "";
            List<int> rivi = new List<int>();
            Random r = new Random();

            int rivimaara = int.Parse(rivienmaara.Text);
            for (int ii = 0; ii < rivimaara; ii++)
            {
                if (valinta == "Lotto")
                {

                    rivi = ArvoNumerot(39, r, 7);
                }

                if (valinta == "Viking Lotto")
                {

                    rivi = ArvoNumerot(48, r, 6);
                }

                if (valinta == "Eurojackpot")
                {

                    rivi = ArvoNumerot(50, r, 7);
                }


                rivitxt += "Rivi " + ii + ": ";
                    foreach(int rr in rivi)
                    {
                        rivitxt += rr + " ";
                    }
                    rivitxt = rivitxt + "\n";

                
                
            }
            rivit.Text = rivitxt;
        }
    }
}
