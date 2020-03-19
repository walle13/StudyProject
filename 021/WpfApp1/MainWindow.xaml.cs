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

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           // this.button1.Click += this.ButtonClicked;
            this.button1.Click += new RoutedEventHandler(this.ButtonClicked);
        }

        private void ButtonClicked(object sender, RoutedEventArgs e)
        {
            this.textBox1.Text = "Hello, WASPEC!";
        }
    }
}