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
    /// Interaction logic for LandingPageButton.xaml
    /// </summary>
    public partial class LandingPageButton : UserControl
    {

        public string ButtonTilte
        {
            get { return (string)GetValue(ButtonTilteProperty); }
            set { SetValue(ButtonTilteProperty, value); }
        }

        public object Icon
        {
            get { return (object)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public object IconTitle
        {
            get { return (object)GetValue(IconTitleProperty); }
            set { SetValue(IconTitleProperty, value); }
        }

        public static readonly RoutedEvent ClickEvent = 
            EventManager.RegisterRoutedEvent(nameof(NavClick), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(LandingPageButton));

        public event RoutedEventHandler NavClick
        {
            add { AddHandler(ClickEvent, value); }
            remove { RemoveHandler(ClickEvent, value); }
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(object), typeof(LandingPageButton), new PropertyMetadata(0));


        public static readonly DependencyProperty ButtonTilteProperty =
            DependencyProperty.Register("ButtonTilte", typeof(string), typeof(LandingPageButton), new PropertyMetadata(""));


        public static readonly DependencyProperty IconTitleProperty =
            DependencyProperty.Register("IconTitle", typeof(object), typeof(LandingPageButton), new PropertyMetadata(0));



        public Uri NavUri
        {
            get { return (Uri)GetValue(NavUriProperty); }
            set { SetValue(NavUriProperty, value); }
        }

        // Using a DependencyProperty as the backing store for NavUri.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NavUriProperty =
            DependencyProperty.Register("NavUri", typeof(Uri), typeof(LandingPageButton), new PropertyMetadata(null));




        public LandingPageButton()
        {
            InitializeComponent();
            
        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(ClickEvent));
        }
    }
}
