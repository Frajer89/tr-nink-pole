using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace trénink_pole
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] pole = new int[100];
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Generujpole(pole, -999, 1000);
            txtText.Text = string.Join(";", pole);
            txtText.Text += "\r\n\r\n";
            txtText.Text += $"Součet" ={SoucetPrvkuPoli(pole)}"
        }

        private void Generujpole(int[] array, int min, int max)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(min, max);
            }

        }

        private int[] Generujpole(int count, int min, int max)
        {
            int[] Array = new int[count];
            Random random = new Random();
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = random.Next(min, max);
            }
            return Array;
        }

        private int SoucetPrvkuPoli(int[] Array)
        {
            int soucet = 0;
            for(int i = 0;i <Array.Length; i++)
            {
                soucet = soucet + Array[i];
                     
            }
            return soucet;
        }
    }
}
