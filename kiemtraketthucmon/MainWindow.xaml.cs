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

namespace kiemtraketthucmon
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


        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_Meo_Click(object sender, RoutedEventArgs e)
        {
            Meo conmeo = new Meo();
            conmeo.sound = "Meow Meow";
            conmeo.Color = "Đen";
            conmeo.OK();
        }

        private void btn_Cho_Click(object sender, RoutedEventArgs e)
        {
            Cho concho = new Cho();
            concho.sound = "Gâu Gâu";
            concho.Color = "Vàng";
            concho.OK();
        }
    }
}