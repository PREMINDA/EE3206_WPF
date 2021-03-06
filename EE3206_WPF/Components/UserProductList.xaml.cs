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

namespace EE3206_WPF.Components
{
    /// <summary>
    /// Interaction logic for UserProductList.xaml
    /// </summary>
    public partial class UserProductList : UserControl
    {




        public string VisibilityITM
        {
            get { return (string)GetValue(VisibilityITMProperty); }
            set { SetValue(VisibilityITMProperty, value); }
        }

        // Using a DependencyProperty as the backing store for VisibilityITM.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty VisibilityITMProperty =
            DependencyProperty.Register("VisibilityITM", typeof(string), typeof(UserProductList), new PropertyMetadata("Visible"));





        public string Link
        {
            get { return (string)GetValue(LinkProperty); }
            set { SetValue(LinkProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Link.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LinkProperty =
            DependencyProperty.Register("Link", typeof(string), typeof(UserProductList), new PropertyMetadata(String.Empty));

        public string Price
        {
            get { return (string)GetValue(PriceProperty); }
            set { SetValue(PriceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Price.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PriceProperty =
            DependencyProperty.Register("Price", typeof(string), typeof(UserProductList), new PropertyMetadata(string.Empty));


        public string Description
        {
            get { return (string)GetValue(DescriptionProperty); }
            set { SetValue(DescriptionProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Description.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DescriptionProperty =
            DependencyProperty.Register("Description", typeof(string), typeof(UserProductList), new PropertyMetadata(string.Empty));


        public string ProductName
        {
            get { return (string)GetValue(ProductNameProperty); }
            set { SetValue(ProductNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ProductName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ProductNameProperty =
            DependencyProperty.Register("ProductName", typeof(string), typeof(UserProductList), new PropertyMetadata(string.Empty));

        public static readonly RoutedEvent ClickEvent =
           EventManager.RegisterRoutedEvent(nameof(AddCart), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(LandingPageButton));

        public event RoutedEventHandler AddCart
        {
            add { AddHandler(ClickEvent, value); }
            remove { RemoveHandler(ClickEvent, value); }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(ClickEvent));
        }

        public UserProductList()
        {
            InitializeComponent();
        }

        
    }

}
