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
using System.IO;

namespace InfojegyzetDoga
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// balra Szidor Mihály
    public partial class MainWindow : Window
    {
        List<Fuvar> fuvarok = new List<Fuvar>();
        public MainWindow()
        {
            InitializeComponent();
            
            foreach (string sorAdat in File.ReadAllLines("fuvar.csv").Skip(1))
            {
                var adatok = sorAdat.Split(';');
                fuvarok.Add(new Fuvar(Convert.ToInt32(adatok[0]), Convert.ToDateTime(adatok[1]), Convert.ToInt32(adatok[2]), float.Parse(adatok[3]), float.Parse(adatok[4]), float.Parse(adatok[5]),adatok[6]));
            }

            
        }

        private void egy_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{fuvarok.Count} fuvar");
        }

        private void ketto_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{fuvarok.Where(x => x.Id == Convert.ToInt32(tbTaxisId.Text)).Count()} fuvar alatt {fuvarok.Select(x => x.Viteldij).Sum() + fuvarok.Select(x => x.Borravalo).Sum()}$-t");
            ;
        }

        private void negy_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{Math.Round(fuvarok.Select(x => x.Tavolsag).Sum() * 1.6, digits:2)}km");
        }

        private void ot_Click(object sender, RoutedEventArgs e)
        {
            lbLeghosszabbFuvar.Items.Add(fuvarok.Select(x => x).Where(x => x.Tavolsag == fuvarok.Select(x => x.Tavolsag).Max()));
             
        }

        private void hat_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("hibak.txt");
            foreach (var item in fuvarok)
            {

            }
        }
    }
}
