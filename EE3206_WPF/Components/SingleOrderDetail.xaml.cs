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


    public partial class SingleOrderDetail : UserControl
    {



        public int OrderDetaiID
        {
            get { return (int)GetValue(OrderDetaiIDProperty); }
            set { SetValue(OrderDetaiIDProperty, value); }
        }

        // Using a DependencyProperty as the backing store for OrderDetaiID.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OrderDetaiIDProperty =
            DependencyProperty.Register("OrderDetaiID", typeof(int), typeof(SingleOrderDetail), new PropertyMetadata(0));


        public string OrderProductName
        {
            get { return (string)GetValue(OrderProductNameProperty); }
            set { SetValue(OrderProductNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for OrderProductName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OrderProductNameProperty =
            DependencyProperty.Register("OrderProductName", typeof(string), typeof(SingleOrderDetail), new PropertyMetadata(string.Empty));



        public int OrderProductPrice
        {
            get { return (int)GetValue(OrderProductPriceProperty); }
            set { SetValue(OrderProductPriceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for OrderProductPrice.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OrderProductPriceProperty =
            DependencyProperty.Register("OrderProductPrice", typeof(int), typeof(SingleOrderDetail), new PropertyMetadata(0));

        public Uri OrderImageSource
        {
            get { return (Uri)GetValue(OrderImageSourceProperty); }
            set { SetValue(OrderImageSourceProperty, value); }
        }

        public static readonly DependencyProperty OrderImageSourceProperty =
         DependencyProperty.Register("OrderImageSource",
        typeof(Uri), typeof(SingleOrderDetail),
        new FrameworkPropertyMetadata(new PropertyChangedCallback(OnImageSourceChanged)));

        private static void OnImageSourceChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {

            SingleOrderDetail userControl = (SingleOrderDetail)sender;

            userControl.OrderImage.Source = new BitmapImage((Uri)e.NewValue);
        }


        public SingleOrderDetail()
        {
            InitializeComponent();
        }
    }
}
