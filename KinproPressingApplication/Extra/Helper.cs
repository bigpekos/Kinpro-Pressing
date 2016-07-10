using KinproPressingApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace KinproPressingApplication.Extra
{
    public static class Helper
    {
        public static BitmapImage ProductImageUrl(int imageNumber)
        {
            var imagePath = "pack://application:,,,/Images/Produits/";
            Uri uriSource = new Uri(imagePath + ProductImagesConstants.CHEMISE);

            string produitImageName = Enum.GetName(typeof(ProductList.ProductImagesEnum), imageNumber);

            switch (produitImageName.ToLower())
            {
                case "chemise":
                    uriSource = new Uri(imagePath + ProductImagesConstants.CHEMISE);
                    break;
                case "jupe":
                    uriSource = new Uri(imagePath + ProductImagesConstants.JUPE);
                    break;
                case "veste":
                    uriSource = new Uri(imagePath + ProductImagesConstants.VESTE);
                    break;
                default:
                    uriSource = new Uri(imagePath + "jacket.png"); 
                    break;

            }
                
            return new BitmapImage(uriSource);
        }


    }

   
}
