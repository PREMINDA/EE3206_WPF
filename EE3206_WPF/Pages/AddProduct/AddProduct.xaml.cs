
using EE3206_WPF.Database;
using EE3206_WPF.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace EE3206_WPF.Pages.AddProduct
{
    /// <summary>
    /// Interaction logic for AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Page
    {
        string filePate;
     

        public AddProduct()
        {
            InitializeComponent(); 
        }

        private void AddBtnClick1(object sender, RoutedEventArgs e)
        {
           
            
            using (DataBaseRepository repository = new DataBaseRepository()) 
            {
                
                if (String.IsNullOrEmpty(ProdName.TextVal) || String.IsNullOrEmpty(Price.TextVal) || String.IsNullOrEmpty(Description.TextVal))
                {
                    popwindow.TextVal = "Everything Should be fill";
                    popwindow.isOpen = true;
                }
                else
                {
                    Product product = new Product()
                    {
                        productName = ProdName.TextVal,
                        price = int.Parse(Price.TextVal),
                        description = Description.TextVal
                    };

                    if (filePate == null)
                    {
                        popwindow.TextVal = "Select Image For Product";
                        popwindow.isOpen = true;
                    }
                    else 
                    {
                       
                        File.Copy(filePate, System.IO.Path.Combine(@"E:\asd\product", ProdName.TextVal.ToString() + ".jpg"));
                        string link = String.Format(@"E:\asd\product\{0}.jpg",ProdName.TextVal.ToString());
                        product.Link = link;
                        repository.Products.Add(product);
                        repository.SaveChanges();

                        if (this.NavigationService.CanGoBack)
                        {
                            this.NavigationService.GoBack();
                        }
                    }
                    
                }
            }
            
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
            catch (IOException)
            {
                
            }
        }

        private void popwindow_CloseEnv(object sender, RoutedEventArgs e)
        {
            popwindow.isOpen = false;
        }

        private void Price_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            if (regex.IsMatch(e.Text) == true)
            {
                popwindow.TextVal = "Only allow numbers";
                popwindow.isOpen = true;
            }
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
