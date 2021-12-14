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
    /// Interaction logic for CartItemList.xaml
    /// </summary>
    public partial class CartItemList : UserControl
    {


        public string ProductName
        {
            get { return (string)GetValue(ProductNameProperty); }
            set { SetValue(ProductNameProperty, value); }
        }



        public string PriceVal
        {
            get { return (string)GetValue(PriceValProperty); }
            set { SetValue(PriceValProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PriceVal.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PriceValProperty =
            DependencyProperty.Register("PriceVal", typeof(string), typeof(CartItemList), new PropertyMetadata(string.Empty));



        // Using a DependencyProperty as the backing store for ProductName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ProductNameProperty =
            DependencyProperty.Register("ProductName", typeof(string), typeof(CartItemList), new PropertyMetadata(string.Empty));



        public CartItemList()
        {
            InitializeComponent();
        }
    }
}
