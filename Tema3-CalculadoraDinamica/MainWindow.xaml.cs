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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tema3_CalculadoraDinamica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int c = 1;
            int r = 0;

            for (int i = 3; i < 6; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button button = new Button();
                    button.Content = c;
                    button.Click += click_Button;
                    nums.Children.Add(button);
                    Grid.SetColumn(button, j);
                    Grid.SetRow(button, i);
                    c++;
                }
            }
        }

        private void click_Button(object sender, RoutedEventArgs e)
        {
            Button boton = (Button)sender;
            caja.Text += boton.Content.ToString();
        }
    }
}
