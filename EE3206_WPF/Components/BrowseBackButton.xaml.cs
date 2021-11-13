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
    /// Interaction logic for BrowseBackButton.xaml
    /// </summary>
    public partial class BrowseBackButton : UserControl
    {
        public BrowseBackButton()
        {
            InitializeComponent();
        }

        public static readonly RoutedEvent ClickEvent =
           EventManager.RegisterRoutedEvent(nameof(BackButton), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(BrowseBackButton));

        public event RoutedEventHandler BackButton
        {
            add { AddHandler(ClickEvent, value); }
            remove { RemoveHandler(ClickEvent, value); }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(ClickEvent));
        }
    }
}
