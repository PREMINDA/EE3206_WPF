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
    /// Interaction logic for SelectedServices.xaml
    /// </summary>
    public partial class SelectedServices : UserControl
    {


        public string SelServName
        {
            get { return (string)GetValue(SelServNameProperty); }
            set { SetValue(SelServNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelServName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelServNameProperty =
            DependencyProperty.Register("SelServName", typeof(string), typeof(SelectedServices), new PropertyMetadata(string.Empty));




        public int SelServPrice
        {
            get { return (int)GetValue(SelServPriceProperty); }
            set { SetValue(SelServPriceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelServPrice.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelServPriceProperty =
            DependencyProperty.Register("SelServPrice", typeof(int), typeof(SelectedServices), new PropertyMetadata(0));



        public SelectedServices()
        {
            InitializeComponent();
        }
    }
}
