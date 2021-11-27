using EE3206_WPF.Components;
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

namespace EE3206_WPF.Pages.UserDashBoard
{
    /// <summary>
    /// Interaction logic for UserDashBoard.xaml
    /// </summary>
    public partial class UserDashBoard : Page
    {
        public UserDashBoard()
        {
            InitializeComponent();
        }

        private void LandingPageButton_NavClick(object sender, RoutedEventArgs e)
        {
            var ClickButton = e.OriginalSource as LandingPageButton;
           // NavigationService.Navigate(ClickButton.NavUri);
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(ClickButton.NavUri);
            if (NavigationService.CanGoBack)
            {
                NavigationService.RemoveBackEntry();
            }
        }

       
    }
}
