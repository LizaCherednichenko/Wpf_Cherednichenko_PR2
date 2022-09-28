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

namespace Wpf_Cherednichenko_PR2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuClose_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void MenuRed_Click(object sender, RoutedEventArgs e)
        {
            Window1.Background = Brushes.Red;
        }

        private void MenuGreen_Click(object sender, RoutedEventArgs e)
        {
            Window1.Background = Brushes.Green;
        }

        private void MenuBlue_Click(object sender, RoutedEventArgs e)
        {
            Window1.Background = Brushes.Blue;
        }

        private void MenuViolet_Click(object sender, RoutedEventArgs e)
        {
            Window1.Background = Brushes.Violet;
        }

        private void MenuOrange_Click(object sender, RoutedEventArgs e)
        {
            Window1.Background = Brushes.Orange;
        }

        private void MenuWhite_Click(object sender, RoutedEventArgs e)
        {
            Window1.Background = Brushes.White;
        }

        private void MenuRazr_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("О разработчике:" + Environment.NewLine + "студентка 402 группы ИСП" + Environment.NewLine + "Чередниченко Елизавета");
        }

        private void TBRed_Click(object sender, RoutedEventArgs e)
        {
            Window1.Background = Brushes.Red;
        }

        private void TBGreen_Click(object sender, RoutedEventArgs e)
        {
            Window1.Background = Brushes.Green;
        }

        private void TBBlue_Click(object sender, RoutedEventArgs e)
        {
            Window1.Background = Brushes.Blue;
        }

        private void TBViolet_Click(object sender, RoutedEventArgs e)
        {
            Window1.Background = Brushes.Violet;
        }

        private void TBOrange_Click(object sender, RoutedEventArgs e)
        {
            Window1.Background = Brushes.Orange;
        }

        private void TBWhite_Click(object sender, RoutedEventArgs e)
        {
            Window1.Background = Brushes.White;
        }

        private void TBRazr_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("О разработчике:" + Environment.NewLine + "студентка 402 группы ИСП" + Environment.NewLine + "Чередниченко Елизавета");
        }

        private void TBClose_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
