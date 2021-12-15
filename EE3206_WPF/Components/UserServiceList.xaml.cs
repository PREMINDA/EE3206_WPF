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
    /// Interaction logic for UserServiceList.xaml
    /// </summary>
    public partial class UserServiceList : UserControl
    {


        public string ServiceName
        {
            get { return (string)GetValue(ServiceNameProperty); }
            set { SetValue(ServiceNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ServiceName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ServiceNameProperty =
            DependencyProperty.Register("ServiceName", typeof(string), typeof(UserServiceList), new PropertyMetadata(string.Empty));


        public string ServiceDescription
        {
            get { return (string)GetValue(ServiceDescriptionProperty); }
            set { SetValue(ServiceDescriptionProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ServiceDescription.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ServiceDescriptionProperty =
            DependencyProperty.Register("ServiceDescription", typeof(string), typeof(UserServiceList), new PropertyMetadata(string.Empty));


        public int ServicePrice
        {
            get { return (int)GetValue(ServicePriceProperty); }
            set { SetValue(ServicePriceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ServicePrice.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ServicePriceProperty =
            DependencyProperty.Register("ServicePrice", typeof(int), typeof(UserServiceList), new PropertyMetadata(0));



        public static readonly RoutedEvent ClickEvent =
           EventManager.RegisterRoutedEvent(nameof(AddServiceList), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(LandingPageButton));

        public event RoutedEventHandler AddServiceList
        {
            add { AddHandler(ClickEvent, value); }
            remove { RemoveHandler(ClickEvent, value); }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(ClickEvent));
        }


        public Uri MyImageSource
        {
            get { return (Uri)GetValue(MyImageSourceProperty); }
            set { SetValue(MyImageSourceProperty, value); }
        }

        public static readonly DependencyProperty MyImageSourceProperty =
         DependencyProperty.Register("MyImageSource",
        typeof(Uri), typeof(UserServiceList),
        new FrameworkPropertyMetadata(new PropertyChangedCallback(OnImageSourceChanged)));

        private static void OnImageSourceChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {

            UserServiceList userControl = (UserServiceList)sender;

            userControl.someImage.Source = new BitmapImage((Uri)e.NewValue);
        }

        public UserServiceList()
        {
            InitializeComponent();
        }

       
    }
}
