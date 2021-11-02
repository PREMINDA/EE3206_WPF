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
    /// Interaction logic for TextInput.xaml
    /// </summary>
    public partial class TextInput : UserControl
    {
        public object Icon
        {
            get { return (object)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }



        public string EnteredValue
        {
            get { return (string)GetValue(EnteredValueProperty); }
            set { SetValue(EnteredValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for EnteredValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EnteredValueProperty =
            DependencyProperty.Register("EnteredValue", typeof(string), typeof(TextInput), new PropertyMetadata(""));



        // Using a DependencyProperty as the backing store for Icon.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(object), typeof(TextInput), new PropertyMetadata(0));

        public TextInput()
        {
            InitializeComponent();
        }
    }
}
