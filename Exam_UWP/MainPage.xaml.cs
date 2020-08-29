using Exam_UWP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using static Exam_UWP.Models.Product;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Exam_UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<Product> Products;

        public MainPage()
        {
            this.InitializeComponent();
            Products = new ObservableCollection<Product>();
            ProductManager.GetAllproduct(Products);

        }
        private void selectOption_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(((Product)AvatarComboBox.SelectedValue).name != "")
            {
                string name = ((Product)AvatarComboBox.SelectedValue).name;
                string description = Description.Text;
                var newProduct = new Product(name, description, ProductCategory.cogai);
                this.Products.Add(newProduct);
                ProductManager.GetAllproduct(Products);

            }
        }
    }
}
