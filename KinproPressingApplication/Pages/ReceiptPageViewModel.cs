using FirstFloor.ModernUI.Presentation;
using KinproPressingApplication.Extra;
using KinproPressingApplication.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinproPressingApplication.Pages
{
    public class ReceiptPageViewModel : NotifyPropertyChanged
    {
        private ObservableCollection<ClothsModel> _listOfSelectedItemsBind;

       

        public ObservableCollection<ClothsModel> ListOfSelectedItemsBind
        {
            get { return this._listOfSelectedItemsBind; }
            set { this._listOfSelectedItemsBind = value; OnPropertyChanged("ListOfSelectedItemsBind"); }

        }

        public ReceiptPageViewModel()
        {
            var receiptModel = new ObservableCollection<ReceiptModel>()
         {
             //new ClothsModel(){Name="Chemise"},
             //new ClothsModel(){Name="Pantalon",Price=600, ItemId=24, ProductImageUrl = Helper.ProductImageUrl(2)},
             //new ClothsModel(){Name="Cravate",Price=250, ItemId=27, ProductImageUrl = Helper.ProductImageUrl(3) },
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=30, ProductImageUrl = Helper.ProductImageUrl(4)},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=31, ProductImageUrl = Helper.ProductImageUrl(4)},
             //new ClothsModel(){Name="Jupe",Price=400,ItemId=32,  ProductImageUrl = Helper.ProductImageUrl(4)},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=33, ProductImageUrl = Helper.ProductImageUrl(4)},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=34, ProductImageUrl = Helper.ProductImageUrl(4)},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=35, ProductImageUrl = Helper.ProductImageUrl(4)},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=36, ProductImageUrl = Helper.ProductImageUrl(4)},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=37, ProductImageUrl = Helper.ProductImageUrl(4)},
             //new ClothsModel(){Name="Jupe",Price=400,ItemId=38,  ProductImageUrl = Helper.ProductImageUrl(4)},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=39, ProductImageUrl = Helper.ProductImageUrl(4)},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=40, ProductImageUrl = Helper.ProductImageUrl(4)},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=41, ProductImageUrl = Helper.ProductImageUrl(4)},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=42, ProductImageUrl = Helper.ProductImageUrl(4)},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=43, ProductImageUrl = Helper.ProductImageUrl(4)},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=44, ProductImageUrl = Helper.ProductImageUrl(4)},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=45, ProductImageUrl = Helper.ProductImageUrl(4)},
             //new ClothsModel(){Name="Jupe",Price=400,ItemId=46,  ProductImageUrl = Helper.ProductImageUrl(4)},
             //new ClothsModel(){Name="Jupe",Price=400,ItemId=47,  ProductImageUrl = Helper.ProductImageUrl(4)},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=48, ProductImageUrl = Helper.ProductImageUrl(4)},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=49, ProductImageUrl = Helper.ProductImageUrl(4)},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=50, ProductImageUrl = Helper.ProductImageUrl(4)},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=54, ProductImageUrl = Helper.ProductImageUrl(4)},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=55, ProductImageUrl = Helper.ProductImageUrl(4)},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=56, ProductImageUrl = Helper.ProductImageUrl(4)},
             //new ClothsModel(){Name="Jupe",Price=400,ItemId=57,  ProductImageUrl = Helper.ProductImageUrl(4)},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=58, ProductImageUrl = Helper.ProductImageUrl(4)},
             //new ClothsModel(){Name="Jupe",Price=400, ItemId=59, ProductImageUrl = Helper.ProductImageUrl(4)},



         };
           // ListOfSelectedItemsBind = receiptModel;
        
        }



        private ArrayList LoadListBoxData()
        {
            ArrayList itemsList = new ArrayList();
            itemsList.Add("Coffie");
            itemsList.Add("Tea");
            itemsList.Add("Orange Juice");
            itemsList.Add("Milk");
            itemsList.Add("Mango Shake");
            itemsList.Add("Iced Tea");
            itemsList.Add("Soda");
            itemsList.Add("Water");
            return itemsList;
        }


    }


}
