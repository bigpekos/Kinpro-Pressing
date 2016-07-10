using FirstFloor.ModernUI.Presentation;
using KinproPressingApplication.ClothService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace KinproPressingApplication.Pages
{
    public class HomeViewModel : NotifyPropertyChanged
    {
        private GetAllClothsSetting_Result[] product;
        private string color;

        public GetAllClothsSetting_Result[] Product
        {
            get { return this.product ;}
            set { this.product = value; }
           
        }

        public string Color
        {
            get { return color; }
            set{color=value;}
        
        }

        public HomeViewModel()
        {
            //List<ProductModel> productModel = new List<ProductModel>();
            //productModel.Add(new ProductModel() { Title = "title 1", SmallImage = "some path" });

            //ClothServiceClient clientService = new ClothServiceClient();
            //clientService.AddCloth("sankara", 1500, "Nobody knows");

            var imagePath = "pack://application:,,,/Images/";
            var uriSource = new Uri(imagePath + "round_green_play_button_4044.jpg");

           // mimg.Source = new BitmapImage(uriSource);

            ClothServiceClient clothService = new ClothServiceClient();
            GetAllClothsSetting_Result[] allCloths = clothService.GetAllClothsSetting();



            product = allCloths;

        
        }

    }


}
