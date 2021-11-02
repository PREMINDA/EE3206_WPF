using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace EE3206_WPF.Pages.AddServises
{
    /// <summary>
    /// Interaction logic for AddServises.xaml
    /// </summary>
    public partial class AddServises : Page
    {
        string filePate;

 
        private void AddBtnClick1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(System.IO.Directory.GetCurrentDirectory());
            File.Copy(filePate, System.IO.Path.Combine(@"E:\asd", System.IO.Path.GetFileName(filePate)));

        }

        private void AddImage(object sender, RoutedEventArgs e)
        {

            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Multiselect = false;
                openFileDialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";

                if (openFileDialog.ShowDialog() == true)
                {

                    filePate = openFileDialog.FileName;
                    image1.Source = new BitmapImage(new Uri(openFileDialog.FileName));


                }

                openFileDialog = null;
                GC.Collect();



            }
            catch
            {

            }
        }

        public AddServises()
        {
            InitializeComponent();
        }
    }
}
