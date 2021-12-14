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
    /// Interaction logic for OrderListItem.xaml
    /// </summary>
    public partial class OrderListItem : UserControl
    {
        public int OrderID
        {
            get { return (int)GetValue(OrderIDProperty); }
            set { SetValue(OrderIDProperty, value); }
        }

        // Using a DependencyProperty as the backing store for OrderID.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OrderIDProperty =
            DependencyProperty.Register("OrderID", typeof(int), typeof(OrderListItem), new PropertyMetadata(0));



        public string OrderUserName
        {
            get { return (string)GetValue(OrderUserNameProperty); }
            set { SetValue(OrderUserNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for OrderUserName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OrderUserNameProperty =
            DependencyProperty.Register("OrderUserName", typeof(string), typeof(OrderListItem), new PropertyMetadata(string.Empty));






        public string OrderUserEmail
        {
            get { return (string)GetValue(OrderUserEmailProperty); }
            set { SetValue(OrderUserEmailProperty, value); }
        }

        // Using a DependencyProperty as the backing store for OrderUserEmail.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OrderUserEmailProperty =
            DependencyProperty.Register("OrderUserEmail", typeof(string), typeof(OrderListItem), new PropertyMetadata(string.Empty));







        public string OrderUserTelNum
        {
            get { return (string)GetValue(OrderUserTelNumProperty); }
            set { SetValue(OrderUserTelNumProperty, value); }
        }

        // Using a DependencyProperty as the backing store for OrderUserTelNum.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OrderUserTelNumProperty =
            DependencyProperty.Register("OrderUserTelNum", typeof(string), typeof(OrderListItem), new PropertyMetadata(string.Empty));



        public static readonly RoutedEvent SeeMore =
           EventManager.RegisterRoutedEvent(nameof(SeeMoreList), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(UsersDetail));

        public event RoutedEventHandler SeeMoreList
        {
            add { AddHandler(SeeMore, value); }
            remove { RemoveHandler(SeeMore, value); }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(SeeMore));
        }
        public OrderListItem()
        {
            InitializeComponent();
        }
    }
}
