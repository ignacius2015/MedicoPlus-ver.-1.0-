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

namespace MedicoPlus_ver._1._0__Модуль_Реєстратура.Registry
{
    /// <summary>
    /// Interaction logic for CreateCard.xaml
    /// </summary>
    public partial class CreateCard : Window
    {

        MySQL db = new MySQL();
        private DateTime data;
        public CreateCard()
        {
            InitializeComponent();

        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            string fullname = surname + " " + name + " " + lastname;
            data = (DateTime) birthday.SelectedDate;
        }

        
       
    }
}
