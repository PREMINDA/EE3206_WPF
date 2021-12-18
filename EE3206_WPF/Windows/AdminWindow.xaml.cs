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
using System.Windows.Shapes;

namespace EE3206_WPF.Windows
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        Admin admin;

        public AdminWindow()
        {
            InitializeComponent();
        }

        public void GetUser(object newuser)
        {
            admin = (Admin)newuser;
            _userName.Text = admin.Name;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CommonWindow commonWindow = new CommonWindow();
            commonWindow.Show();


            var w = Application.Current.Windows[0];
            if (w != null) w.Close();
        }
    }
}
