using KinproPressingApplication.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
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

namespace KinproPressingApplication.Pages.Settings
{
    /// <summary>
    /// Interaction logic for ConfigurationProduits.xaml
    /// </summary>
    public partial class ConfigurationProduits : UserControl
    {
        ConfigurationProduitsViewModel _viewModel;
        DashboardViewModel _viewModelDashboard;

        public ConfigurationProduits()
        {
            InitializeComponent();
            this.DataContext = new ConfigurationProduitsViewModel();
            _viewModel = (ConfigurationProduitsViewModel)base.DataContext;
            _viewModelDashboard = new DashboardViewModel();
        }

        private void OnProductDelete(object sender, RoutedEventArgs e)
        {
            var productIdTag = ((Button)sender).Tag;
            //Delete from db where productidtag 
            

            //then remove from the view
            var itemToRemove = _viewModel.Product.Single(x => x.ItemId == Convert.ToInt32(productIdTag));
            _viewModel.Product.Remove(itemToRemove);

            _viewModelDashboard.Product = _viewModel.Product;
                      
        }

       

        private void SaveAfterEdit_Event(object sender, DataGridRowEditEndingEventArgs e)
        {
            if (e.EditAction == DataGridEditAction.Commit)
            {
                ClothsModel rowView = e.Row.Item as ClothsModel;
               
   
                var rowBeingEdited = rowView.Price;
                var productV = _viewModel.Product;

                MessageBox.Show("asd");
            }
        }

        private void SaveAfterCellEdit_Event(object sender, DataGridCellEditEndingEventArgs e)
        {
            //Get ItemId
            ClothsModel rowView = e.Row.Item as ClothsModel;
            int itemId = rowView.ItemId;

            var editedItem = e.EditingElement as TextBox;
            var editedItemImage = e.EditingElement as ComboBox;
 
            //Get item Header
            var editedDataGridCell = e.EditingElement.Parent as DataGridCell;
            var editedHedder = editedDataGridCell.Column.SortMemberPath;

            var clothsModel = new ClothsModel();
            ObservableCollection<ClothsModel>productList = _viewModel.Product;
            var currentProduct = productList.Where(x => x.ItemId == itemId);
            
            foreach(var item in currentProduct)
            {
                clothsModel.Price = item.Price;
                clothsModel.Name = item.Name;
                clothsModel.ProductImageUrl =item.ProductImageUrl;
            }
            
            switch(editedHedder)
            {
                case "Price":
                clothsModel.Price = Convert.ToInt32(editedItem.Text);
                    break;
                case "Name":
               clothsModel.Name = editedItem.Text;
                    break;
               default:
                    break;                   
            
            }        


            //TODO::: Save the clothsModel change in database.

           
         

        }
    }
}
