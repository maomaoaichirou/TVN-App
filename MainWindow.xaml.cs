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
using System.Diagnostics;
using System.Threading;

namespace TVN_APP
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

        private void Button1_Click (object sender, RoutedEventArgs e)
        {
            tvnCommand.tvnCE("192.168.0.91", "Vossler");
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            tvnCommand.tvnCE("192.168.0.92", "Vossler");
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            tvnCommand.tvnCE("192.168.0.93", "Vossler");
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            tvnCommand.tvnCE("192.168.0.94", "Vossler");
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            tvnCommand.tvnCE("192.168.0.95", "Vossler");
        }

        private void CloseAll_Click(object sender, RoutedEventArgs e)
        {
            tvnCommand.tvnCK();
        }

        private void OpenAll_Click(object sender, RoutedEventArgs e)
        {
            tvnCommand.tvnCE("192.168.0.91", "Vossler");
            Thread.Sleep(250);
            tvnCommand.tvnCE("192.168.0.92", "Vossler");
            Thread.Sleep(250);
            tvnCommand.tvnCE("192.168.0.93", "Vossler");
            Thread.Sleep(250);
            tvnCommand.tvnCE("192.168.0.94", "Vossler");
            Thread.Sleep(250);
            tvnCommand.tvnCE("192.168.0.95", "Vossler");
        }
    }
}
