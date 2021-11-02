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



    public partial class CustomeTextInput : UserControl
    {
        public string TextVal
        {
            get { return (string)GetValue(TextValProperty); }
            set { SetValue(TextValProperty, value); }
        }



        public string VerticalLoc
        {
            get { return (string)GetValue(VerticalLocProperty); }
            set { SetValue(VerticalLocProperty, value); }
        }

        // Using a DependencyProperty as the backing store for VerticalLoc.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty VerticalLocProperty =
            DependencyProperty.Register("VerticalLoc", typeof(string), typeof(CustomeTextInput), new PropertyMetadata("Center"));



        // Using a DependencyProperty as the backing store for TextVal.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextValProperty =
            DependencyProperty.Register("TextVal", typeof(string), typeof(CustomeTextInput), new PropertyMetadata(""));


        public CustomeTextInput()
        {
            InitializeComponent();
        }
    }
}
