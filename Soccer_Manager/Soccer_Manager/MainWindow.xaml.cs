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

namespace Soccer_Manager
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //TeamsListView.ItemSource = RequestCachePolicyConverter.GetNation();
        }

        private void Event_Select_Swiss(object sender, RoutedEventArgs e)
        {
            //load Team Schweiz
            Console.WriteLine("Schweiz ist angewählt");
        }
        private void Event_Select_France(object sender, RoutedEventArgs e)
        {
            //load Team Frankreich
            Console.WriteLine("Frankreich ist angewählt");
        }
        private void Event_Select_England(object sender, RoutedEventArgs e)
        {
            //load Team England
            Console.WriteLine("England ist angewählt");
        }
    }
}
