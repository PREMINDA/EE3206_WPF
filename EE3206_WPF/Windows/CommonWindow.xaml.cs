using EE3206_WPF.Pages.UserLogin;
using EE3206_WPF.Pages.UserRegister;
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

namespace EE3206_WPF.Windows
{
    /// <summary>
    /// Interaction logic for CommonWindow.xaml
    /// </summary>
    public partial class CommonWindow : Window
    {
        public CommonWindow()
        {
            InitializeComponent();
           
        }

        private void RoundButton_Submitclick(object sender, RoutedEventArgs e)
        {
            //_FrameName.Source = new Uri("/Pages/UserLogin/UserLogin.xaml", UriKind.Relative);

            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new UserLogin());
            GC.Collect();
        }

        private void RoundButton_Submitclick_1(object sender, RoutedEventArgs e)
        {
            //_FrameName.Source = new Uri("/Pages/UserRegister/UserRegister.xaml", UriKind.Relative);

            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new UserRegister());
            GC.Collect();
        }

        private void RoundButton_Submitclick_2(object sender, RoutedEventArgs e)
        {
            //Uri asd = new Uri("/Pages/AdminLogin/AdminLogin.xaml", UriKind.Relative);
            // NavigationService.Navigate(asd);

            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("/Pages/AdminLogin/AdminLogin.xaml", UriKind.Relative));

            //_FrameName.Source = new Uri("/Pages/AdminLogin/AdminLogin.xaml", UriKind.Relative);
            GC.Collect();
        }
    }
}
