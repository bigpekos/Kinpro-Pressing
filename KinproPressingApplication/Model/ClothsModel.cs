using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace KinproPressingApplication.Model
{
    public class ClothsModel : INotifyPropertyChanged
    {
        
        private IEnumerable<ProductList.ProductImagesEnum> _productImageUrl;
        private string name;
        private int _itemId;


        public IEnumerable<ProductList.ProductImagesEnum> ProductImageUrl { get{return _productImageUrl;} set{_productImageUrl=value;OnPropertyChanged("ProductImageUr");} }

        private string _name;
        public int _price { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;



        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("Name");
            }
        }
        public int ItemId
        {
            get { return _itemId; }
            set
            {
                _itemId = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("ItemId");
            }
        }


        public int Price
        {
            get { return _price; }
            set { _price = value; OnPropertyChanged("Price"); }
        
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

       

    }
}
