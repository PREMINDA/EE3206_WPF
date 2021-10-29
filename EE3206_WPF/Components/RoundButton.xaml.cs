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
    /// Interaction logic for RoundButton.xaml
    /// </summary>
    public partial class RoundButton : UserControl
    {


        public string ButtonTilte
        {
            get { return (string)GetValue(ButtonTilteProperty); }
            set { SetValue(ButtonTilteProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ButtonTilte.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonTilteProperty =
            DependencyProperty.Register("ButtonTilte", typeof(string), typeof(RoundButton), new PropertyMetadata("asdasd"));


        public RoundButton()
        {
            InitializeComponent();
        }
    }
}
