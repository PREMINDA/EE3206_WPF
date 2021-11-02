﻿using EE3206_WPF.Database;
using EE3206_WPF.Models;
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

namespace EE3206_WPF.Pages.AdminReg
{
    /// <summary>
    /// Interaction logic for AdminReg.xaml
    /// </summary>
    public partial class AdminReg : Page
    {
        public AdminReg()
        {
            InitializeComponent();
        }

        private void RoundButton_Submitclick(object sender, RoutedEventArgs e)
        {
            AdminContext ad = new AdminContext();
            Admin admin = new Admin()
            {
                Name = UserName.EnteredValue,
                Email = Email.EnteredValue
                
            };
            ad.Admins.Add(admin);
            ad.SaveChanges();
        }


    }
}
