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

namespace EE3206_WPF.Components
{
    /// <summary>
    /// Interaction logic for CustomeUserInput.xaml
    /// </summary>
    public partial class CustomeUserInput : UserControl
    {


        public string PlaceValuPassword
        {
            get { return (string)GetValue(PlaceValuPasswordProperty); }
            set { SetValue(PlaceValuPasswordProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PlaceValuPassword.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PlaceValuPasswordProperty =
            DependencyProperty.Register("PlaceValuPassword", typeof(string), typeof(CustomeUserInput), new PropertyMetadata(string.Empty));




        public string Password
        {
            get { return (string)GetValue(PasswordProperty); }
            set { SetValue(PasswordProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Password.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register("Password", typeof(string), typeof(CustomeUserInput), new PropertyMetadata(string.Empty));



        public object Icon
        {
            get { return (object)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Icon.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(object), typeof(CustomeUserInput), new PropertyMetadata(0));

        public CustomeUserInput()
        {
            InitializeComponent();
        }

        private void _passwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            Password = _passwordBox.Password;
        }

        private void _passwordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Password))
            {
                _passwordBox.Visibility = System.Windows.Visibility.Collapsed;
                place.Visibility = System.Windows.Visibility.Visible;

            }
        }

        private void place_GotFocus(object sender, RoutedEventArgs e)
        {
            place.Visibility = System.Windows.Visibility.Collapsed;
            _passwordBox.Visibility = System.Windows.Visibility.Visible;
            _passwordBox.Focus();
        }
    }
}
