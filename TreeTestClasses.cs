using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows;
using System.Collections.ObjectModel;

namespace TreeTest
{

    class Part: INotifyPropertyChanged
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(new PropertyChangedEventArgs("Name")); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }

        //Creator
        public Part(string name)
        {
            Name = name;
        }
    }
    class Product : INotifyPropertyChanged
    {
        private string model;
        private string name;
        private ObservableCollection<Part> parts;

        // Creators
        public Product(string model, string name, ObservableCollection<Part> parts )
        {
            Model = model;
            Name = name;
            Parts = parts;
        }

        public Product(string model, string name)
        {
            Model = model;
            Name = name;
            Parts = null;
        }

        public ObservableCollection<Part> Parts
        {
            get { return parts; }
            set { parts = value; OnPropertyChanged(new PropertyChangedEventArgs("Parts")); }
        }

        // Properties
        public string Model {
            get {return model;}
            set { model = value; OnPropertyChanged(new PropertyChangedEventArgs("Model"));
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
               
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }
    }

    class Category : INotifyPropertyChanged
    {

        //Constructors
        public Category(string categoryName, ObservableCollection<Product> products)
        {
            CategoryName = categoryName;
            Products = products;
        }

        private string categoryName;
        public string CategoryName
        {
            get { return categoryName; }
            set
            {
                categoryName = value;
                OnPropertyChanged(new PropertyChangedEventArgs("CategoryName"));       
            }
        }

        private ObservableCollection<Product> products;
        public ObservableCollection<Product> Products
        {
            get { return products; }
            set 
            { 
                products = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Products"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }
    }
}
