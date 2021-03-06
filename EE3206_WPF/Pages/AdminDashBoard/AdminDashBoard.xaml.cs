using EE3206_WPF.Components;
using EE3206_WPF.Database;
using EE3206_WPF.Models;
using EE3206_WPF.Windows;
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

namespace EE3206_WPF.Pages.AdminDashBoard
{
    /// <summary>
    /// Interaction logic for AdminDashBoard.xaml
    /// </summary>
    public partial class AdminDashBoard : Page
    {
        public AdminDashBoard()
        {
            InitializeComponent();
            
        }

        public static implicit operator Frame(AdminDashBoard v)
        {
            throw new NotImplementedException();
        }

        private void NavClick_User(object sender, RoutedEventArgs e)
        {
            var ClickButton = e.OriginalSource as LandingPageButton;
            NavigationService.Navigate(ClickButton.NavUri);
            if (NavigationService.CanGoBack)
            {
                NavigationService.RemoveBackEntry();
            }

        }

        private void logout() 
        {
            
        }

    }
}
