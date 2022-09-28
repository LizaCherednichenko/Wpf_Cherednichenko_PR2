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

        private void MenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            SbTb.Text = "Выбор цвета фона";
        }

        private void MenuItem_MouseLeave(object sender, MouseEventArgs e)
        {
            SbTb.Text = "";
        }

        private void MenuRazr_MouseMove(object sender, MouseEventArgs e)
        {
            SbTb.Text = "Информация о разработчике программы";
        }

        private void MenuRazr_MouseLeave(object sender, MouseEventArgs e)
        {
            SbTb.Text = "";
        }

        private void MenuClose_MouseMove(object sender, MouseEventArgs e)
        {
            SbTb.Text = "Закрытие программы";
        }

        private void MenuClose_MouseLeave(object sender, MouseEventArgs e)
        {
            SbTb.Text = "";
        }

        private void TBRed_MouseMove(object sender, MouseEventArgs e)
        {
            SbTb.Text = "Установка красного фона";
        }

        private void TBRed_MouseLeave(object sender, MouseEventArgs e)
        {
            SbTb.Text = "";
        }

        private void TBGreen_MouseMove(object sender, MouseEventArgs e)
        {
            SbTb.Text = "Установка зеленого фона";
        }

        private void TBGreen_MouseLeave(object sender, MouseEventArgs e)
        {
            SbTb.Text = "";
        }

        private void TBBlue_MouseMove(object sender, MouseEventArgs e)
        {
            SbTb.Text = "Установка синего фона";
        }

        private void TBBlue_MouseLeave(object sender, MouseEventArgs e)
        {
            SbTb.Text = "";
        }

        private void TBViolet_MouseMove(object sender, MouseEventArgs e)
        {
            SbTb.Text = "Установка фиолетового фона";
        }

        private void TBViolet_MouseLeave(object sender, MouseEventArgs e)
        {
            SbTb.Text = "";
        }

        private void TBOrange_MouseMove(object sender, MouseEventArgs e)
        {
            SbTb.Text = "Установка оранжевого фона";
        }

        private void TBOrange_MouseLeave(object sender, MouseEventArgs e)
        {
            SbTb.Text = "";
        }

        private void TBWhite_MouseMove(object sender, MouseEventArgs e)
        {
            SbTb.Text = "Установка белого фона";
        }

        private void TBWhite_MouseLeave(object sender, MouseEventArgs e)
        {
            SbTb.Text = "";
        }

        private void TBRazr_MouseMove(object sender, MouseEventArgs e)
        {
            SbTb.Text = "Информация о разработчике программы";
        }

        private void TBRazr_MouseLeave(object sender, MouseEventArgs e)
        {
            SbTb.Text = "";
        }

        private void TBClose_MouseMove(object sender, MouseEventArgs e)
        {
            SbTb.Text = "Закрытие программы";
        }

        private void TBClose_MouseLeave(object sender, MouseEventArgs e)
        {
            SbTb.Text = "";
        }
    }
}
