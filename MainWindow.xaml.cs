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

namespace Latintanc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Feladatok f = new Feladatok();

        public MainWindow()
        {
            InitializeComponent();
            f.Beolvasas();
            kiir();
            Masodik();
            Harmadik();
            Negyedik();

        }

        private void kiir()
        {
            string s = "";
            foreach (var item in f.Lista)
            {
                s += item.ToString(); ;
            }
            output.Text = s;
        }

        private void Masodik()
        {
            masodik.Text = f.Masodik();
        }
        private void Harmadik()
        {
            harmadik.Text = f.Harmadik().ToString(); 
        }
        private void Negyedik()
        {
            string s = "";
            foreach (var item in f.Negyedik())
            {
                s += item + " ";
            }
            negyedik.Text = s;
        }
    }
}
