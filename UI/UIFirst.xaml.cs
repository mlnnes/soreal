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

namespace UI
{
    /// <summary>
    /// Логика взаимодействия для UIFirst.xaml
    /// </summary>
    public partial class UIFirst : Window
    {
        public UIFirst()
        {
            InitializeComponent();
        }

        private void ButtonFirstAdd_Click(object sender, RoutedEventArgs e)
        {
            UISearch UISearch = new UISearch();
            UISearch.Show();
            this.Close();
        }
    }
}