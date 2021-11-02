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
    /// Interaction logic for AddButton.xaml
    /// </summary>
    public partial class AddButton : UserControl
    {


        public string tagName
        {
            get { return (string)GetValue(tagNameProperty); }
            set { SetValue(tagNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for tagName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty tagNameProperty =
            DependencyProperty.Register("tagName", typeof(string), typeof(AddButton), new PropertyMetadata("Add"));

        public static readonly RoutedEvent ClickEvent =
            EventManager.RegisterRoutedEvent(nameof(AddBtnClick), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(LandingPageButton));

        public event RoutedEventHandler AddBtnClick
        {
            add { AddHandler(ClickEvent, value); }
            remove { RemoveHandler(ClickEvent, value); }
        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(ClickEvent));
        }

        public AddButton()
        {
            InitializeComponent();
        }
    }
}
