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
    /// Interaction logic for AppoinmentListItem.xaml
    /// </summary>
    public partial class AppoinmentListItem : UserControl
    {


        public int AppoinmentID
        {
            get { return (int)GetValue(AppoinmentIDProperty); }
            set { SetValue(AppoinmentIDProperty, value); }
        }

        // Using a DependencyProperty as the backing store for AppoinmentID.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AppoinmentIDProperty =
            DependencyProperty.Register("AppoinmentID", typeof(int), typeof(AppoinmentListItem), new PropertyMetadata(0));



        public string AppoinmentDate
        {
            get { return (string)GetValue(AppoinmentDateProperty); }
            set { SetValue(AppoinmentDateProperty, value); }
        }

        // Using a DependencyProperty as the backing store for AppoinmentDate.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AppoinmentDateProperty =
            DependencyProperty.Register("AppoinmentDate", typeof(string), typeof(AppoinmentListItem), new PropertyMetadata(string.Empty));



        public string AppoinmentUser
        {
            get { return (string)GetValue(AppoinmentUserProperty); }
            set { SetValue(AppoinmentUserProperty, value); }
        }

        // Using a DependencyProperty as the backing store for AppoinmentUser.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AppoinmentUserProperty =
            DependencyProperty.Register("AppoinmentUser", typeof(string), typeof(AppoinmentListItem), new PropertyMetadata(string.Empty));



        public string AppoinmentTime
        {
            get { return (string)GetValue(AppoinmentTimeProperty); }
            set { SetValue(AppoinmentTimeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for AppoinmentTime.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AppoinmentTimeProperty =
            DependencyProperty.Register("AppoinmentTime", typeof(string), typeof(AppoinmentListItem), new PropertyMetadata(string.Empty));

        public static readonly RoutedEvent SeeMoreService =
           EventManager.RegisterRoutedEvent(nameof(SeeMoreServiceList), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(UsersDetail));

        public event RoutedEventHandler SeeMoreServiceList
        {
            add { AddHandler(SeeMoreService, value); }
            remove { RemoveHandler(SeeMoreService, value); }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(SeeMoreService));
        }


        public AppoinmentListItem()
        {
            InitializeComponent();
        }

    }
}
