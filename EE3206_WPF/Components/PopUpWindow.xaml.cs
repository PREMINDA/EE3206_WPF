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
    /// Interaction logic for PopUpWindow.xaml
    /// </summary>
    public partial class PopUpWindow : UserControl
    {

        public string TextVal
        {
            get { return (string)GetValue(TextValProperty); }
            set { SetValue(TextValProperty, value); }
        }



        public bool isOpen
        {
            get { return (bool)GetValue(isOpenProperty); }
            set { SetValue(isOpenProperty, value); }
        }

        public static readonly RoutedEvent popUpClose =
            EventManager.RegisterRoutedEvent(nameof(Submitclick), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(LandingPageButton));

        public event RoutedEventHandler Submitclick
        {
            add { AddHandler(popUpClose, value); }
            remove { RemoveHandler(popUpClose, value); }
        }

        // Using a DependencyProperty as the backing store for ButtonTilte.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonTilteProperty =
            DependencyProperty.Register("ButtonTilte", typeof(string), typeof(RoundButton), new PropertyMetadata("asdasd"));

        // Using a DependencyProperty as the backing store for isOpen.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty isOpenProperty =
            DependencyProperty.Register("isOpen", typeof(bool), typeof(PopUpWindow), new PropertyMetadata(false));



        // Using a DependencyProperty as the backing store for TextVal.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextValProperty =
            DependencyProperty.Register("TextVal", typeof(string), typeof(PopUpWindow), new PropertyMetadata(""));


        public PopUpWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(popUpClose));
        }
    }
}
