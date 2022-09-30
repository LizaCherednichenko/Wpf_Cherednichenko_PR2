﻿using System;
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
using System.Windows.Shapes;

namespace Wpf_Cherednichenko_PR2
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        
        private void CBRed_Selected(object sender, RoutedEventArgs e)
        {
            inccanvas1.DefaultDrawingAttributes.Color = Colors.Red;
        }

        private void CBBlue_Selected(object sender, RoutedEventArgs e)
        {
            inccanvas1.DefaultDrawingAttributes.Color = Colors.Blue;
        }

        private void CBGreen_Selected(object sender, RoutedEventArgs e)
        {
            inccanvas1.DefaultDrawingAttributes.Color = Colors.Green;
        }

        private void ButtonClean_Click(object sender, RoutedEventArgs e)
        {
            inccanvas1.DefaultDrawingAttributes.Color = Colors.White;
        }

        
        private void Slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //double value = Slider1.Value;
            //inccanvas1.DefaultDrawingAttributes.Width = value;
            //inccanvas1.DefaultDrawingAttributes.Height = value;
        }
    }
}
