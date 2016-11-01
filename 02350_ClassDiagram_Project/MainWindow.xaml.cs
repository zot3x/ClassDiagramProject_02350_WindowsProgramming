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

namespace _02350_ClassDiagram_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            

        }

        private void Arrow_Usercontrol_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }

    class Core
    {
        private Canvas canvas;
        
        public Core(Canvas canvas)
        {
            this.canvas = canvas;
        }

        public void DrawTest()
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Fill = Brushes.Red;
            ellipse.Width = 20;
            ellipse.Height = 20;
            ellipse.SetValue(Canvas.TopProperty, 20d);
            ellipse.SetValue(Canvas.LeftProperty, 20d);
            this.canvas.Children.Add(ellipse);
        }
    }
}
