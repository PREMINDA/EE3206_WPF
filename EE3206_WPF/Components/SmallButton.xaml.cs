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
    /// Interaction logic for SmallButton.xaml
    /// </summary>
    public partial class SmallButton : UserControl
    {
        public string ButtonTilte
        {
            get { return (string)GetValue(ButtonTilteProperty); }
            set { SetValue(ButtonTilteProperty, value); }
        }
      
        public object Icon
        {
            get { return (object)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public object IconTitle
        {
            get { return (object)GetValue(IconTitleProperty); }
            set { SetValue(IconTitleProperty, value); }
        }


        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(object), typeof(SmallButton), new PropertyMetadata(0));


        public static readonly DependencyProperty ButtonTilteProperty =
            DependencyProperty.Register("ButtonTilte", typeof(string), typeof(SmallButton), new PropertyMetadata("asdasd"));


        public static readonly DependencyProperty IconTitleProperty =
            DependencyProperty.Register("IconTitle", typeof(object), typeof(SmallButton), new PropertyMetadata(0));



        public SmallButton()
        {
            InitializeComponent();
        }
    }
}


