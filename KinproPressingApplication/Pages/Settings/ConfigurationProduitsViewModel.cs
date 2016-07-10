using FirstFloor.ModernUI.Presentation;
using KinproPressingApplication.Extra;
using KinproPressingApplication.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinproPressingApplication.Pages.Settings
{
    public class ConfigurationProduitsViewModel : NotifyPropertyChanged
    {
        private ObservableCollection<ClothsModel> clothsModel;

        private ObservableCollection<ProductList.ProductImagesEnum> _productListEnum;
        //public ObservableCollection<ProductList.ProductImagesEnum> ProductListEnum
        //{
        //    get { return _productListEnum; }
        //    set { _productListEnum = value; OnPropertyChanged("ProductListEnum"); }
        
        //}

        public IEnumerable<ProductList.ProductImagesEnum> ProductListEnum
        {
            get
            {
                return Enum.GetValues(typeof(ProductList.ProductImagesEnum)).Cast<ProductList.ProductImagesEnum>();
            }
        }

        private ObservableCollection<ClothsModel> product;
        public ObservableCollection<ClothsModel> Product
        {
            get { return product; }
            set { product = value; OnPropertyChanged("Product"); }
        }

        public ConfigurationProduitsViewModel()
        {
            //var listOfImages = Enum.GetValues(typeof(ProductList.ProductImagesEnum)).Cast<ProductList.ProductImagesEnum>;
           
            clothsModel = new ObservableCollection<ClothsModel>()
         {
             new ClothsModel(){Name="Chemise",Price=300, ItemId=20, ProductImageUrl= ProductListEnum },
             //new ClothsModel(){Name="Pantalon",Price=600, ItemId=24, ProductImageUrl = listOfImages},
             //new ClothsModel(){Name="Cravate",Price=250, ItemId=27, ProductImageUrl = listOfImages },
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=30, ProductImageUrl = listOfImages},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=31, ProductImageUrl = listOfImages},
             //new ClothsModel(){Name="Jupe",Price=400,ItemId=32,  ProductImageUrl = listOfImages},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=33, ProductImageUrl =listOfImages},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=34, ProductImageUrl = listOfImages},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=35, ProductImageUrl = listOfImages},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=36, ProductImageUrl = listOfImages},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=37, ProductImageUrl = listOfImages},
             //new ClothsModel(){Name="Jupe",Price=400,ItemId=38,  ProductImageUrl = listOfImages},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=39, ProductImageUrl = listOfImages},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=40, ProductImageUrl = listOfImages},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=41, ProductImageUrl = listOfImages},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=42, ProductImageUrl = listOfImages},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=43, ProductImageUrl = listOfImages},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=44, ProductImageUrl = listOfImages},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=45, ProductImageUrl = listOfImages},
             //new ClothsModel(){Name="Jupe",Price=400,ItemId=46,  ProductImageUrl = listOfImages},
             //new ClothsModel(){Name="Jupe",Price=400,ItemId=47,  ProductImageUrl = listOfImages},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=48, ProductImageUrl = listOfImages},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=49, ProductImageUrl = listOfImages},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=50, ProductImageUrl = listOfImages},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=54, ProductImageUrl = listOfImages},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=55, ProductImageUrl = listOfImages},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=56, ProductImageUrl = listOfImages},
             //new ClothsModel(){Name="Jupe",Price=400,ItemId=57,  ProductImageUrl = listOfImages},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=58, ProductImageUrl = listOfImages},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=59, ProductImageUrl = listOfImages},

         };

            Product = clothsModel;
        
        }
    }
}
