using FirstFloor.ModernUI.Presentation;
using KinproPressingApplication.ClothService;
using KinproPressingApplication.Extra;
using KinproPressingApplication.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace KinproPressingApplication.Pages
{
    public class DashboardViewModel : INotifyPropertyChanged
    {
        private ICommand m_ButtonCommand;

        
        private BitmapImage productImage;
        private int _productCountNumberVar;
        private ObservableCollection<ClothsModel> clothsModel;
        private ObservableCollection<ReceiptModel> receiptModel;

        private ObservableCollection<ClothsModel> product;
        public ObservableCollection<ClothsModel> Product
        {
            get { return product; }
            set { product = value; OnPropertyChanged("Product"); }
        }

        public int productCountNumberVar
        {
            get { return this._productCountNumberVar; }
            set {this._productCountNumberVar = value;}
        }


        public BitmapImage ProductImage
        {
            get { return this.productImage; }
            set { this.productImage = value; }
        }

        public ICommand MVVMClick
        {
            get { return m_ButtonCommand; }
            set { m_ButtonCommand = value; }
        }

        private ObservableCollection<ReceiptModel> _listOfSelectedItemsBind;
        public ObservableCollection<ReceiptModel> ListOfSelectedItemsBind
        {
            get { return this._listOfSelectedItemsBind; }
            set { this._listOfSelectedItemsBind = value; OnPropertyChanged("ListOfSelectedItemsBind"); }

        }

        private int _allitemsTotal;

        public int AllitemsTotal
        {
            get { return this._allitemsTotal; }
            set { this._allitemsTotal = value; OnPropertyChanged("AllitemsTotal"); }

        }

       private List<ClothsModel> clothsModelToShow = new List<ClothsModel>();

        public DashboardViewModel()
        {
            var listOfImages = Enum.GetValues(typeof(ProductList.ProductImagesEnum)).Cast<ProductList.ProductImagesEnum>().ToList();

            clothsModel = new ObservableCollection<ClothsModel>()
         {
             //        new ClothsModel(){Name="Chemise",Price=300, ItemId=20, ProductImageUrl = listOfImages },
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

            receiptModel = new ObservableCollection<ReceiptModel>() {
                new ReceiptModel(){Item ="testing"},
            };


           // clothsModelToShow.Add(clothsModel);
            Product = clothsModel; //clothsModelToShow.ToArray();
            ListOfSelectedItemsBind = receiptModel;
            productCountNumberVar = 0;
        }

        public void changeUIValue(int productvalue)
        {
            //clothsModel = new ClothsModel()
            //{
            //    Name = "tonny",
            //    Price = 90000,
            //    ProductImageUrl = Helper.ProductImageUrl(5)
            //};

            //clothsModelToShow.Add(clothsModel);
            //Product = clothsModelToShow.ToArray();
            //productCountNumberVar = 0;
            clothsModel = new ObservableCollection<ClothsModel>()
         {
             new ClothsModel(){Name="matsy",Price=80000}
         };
            var sss = Product;
            Product.Clear();
            // clothsModelToShow.Add(clothsModel);
            Product = clothsModel; //clothsModelToShow.ToArray();
            //Product.Add(new ClothsModel() { Name="Eude", Price=500 });
            //productCountNumberVar = 0;
        }

        private void DisplayProducts()
        {
            MVVMClick = new RelayCommand(new Action<object>(ShowMessage));

            ClothServiceClient clothService = new ClothServiceClient();

            GetAllClothsSetting_Result[] allCloths = clothService.GetAllClothsSetting();
            int imageNumber = 5;

            foreach (var t in allCloths)
            {
                //clothsModel = new ClothsModel()
                //{
                //    Name = t.Name,
                //    Price = (int)t.Price,
                //    ProductImageUrl = Helper.ProductImageUrl(imageNumber)
                //};

                //clothsModelToShow.Add(clothsModel);
            }

           // Product = clothsModelToShow.ToArray();
            productCountNumberVar = 0;
        }


  

        public void ShowMessage(object sender)
        {
           // ClothServiceClient clothService = new ClothServiceClient();
           // clothService.AddCloth("Chrishna", 300, "description yah");
           
            productCountNumberVar = 500;
         
            MessageBox.Show("Testing this command");
        }



        public event PropertyChangedEventHandler PropertyChanged;

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
