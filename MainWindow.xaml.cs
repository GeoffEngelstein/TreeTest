using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace TreeTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Object> Categories;
        public MainWindow()
        {
            InitializeComponent();
            Categories = GetCategoriesAndProducts();
            tv.ItemsSource = Categories;
        }

        private ObservableCollection<Object> GetCategoriesAndProducts()
        {
            var CatColl = new ObservableCollection<Object>();
            var FruitParts = new ObservableCollection<Part>();

            var a1 = new Product("A1", "Apple");
            a1.Parts = FruitParts;

            var a2 = new Product("A2", "Avocado");
            
            var a3 = new Product("A3", "Apriciot");
            a3.Parts = FruitParts;

            var ap = new ObservableCollection<Product>();
            ap.Add(a1);
            ap.Add(a2);
            ap.Add(a3);

            FruitParts.Add(new Part("Stem"));
            FruitParts.Add(new Part("Seed"));
            FruitParts.Add(new Part("Skin"));

            var a = new Category("Alpha",ap);

            var b1 = new Product("B1", "Banana");
            b1.Parts = FruitParts;  

            var b2 = new Product("B2", "Beef");
            var b3 = new Product("B3", "Buffalo");
            var bp = new ObservableCollection<Product>();
            bp.Add(b1);
            bp.Add(b2);
            bp.Add(b3);
            var b = new Category("Beta", bp);

            CatColl.Add(a);
            CatColl.Add(b);

            var pp = new Product("C4", "Califlower");
            CatColl.Add(pp);
            return CatColl;

        }

        private void cndAdd_Click(object sender, RoutedEventArgs e)
        {
            var p = new Product("X-001", "Extra");
            foreach (Category cc in Categories)
            {
                if (cc.CategoryName == "Alpha")
                {
                    cc.Products.Add(p);
                }
            }
        }
    }
}
