using KinproPressingApplication.Extra;
using KinproPressingApplication.Model;
using KinproPressingApplication.Pages.Settings;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace KinproPressingApplication.Pages
{
    /// <summary>
    /// Interaction logic for dashboard.xaml
    /// </summary>
    public partial class Dashboard : UserControl
    {
        DashboardViewModel _viewModel;
        ReceiptPageViewModel _receiptViewModel;
        public Dashboard()
        {
            InitializeComponent();
            this.DataContext = new DashboardViewModel();
            _viewModel = (DashboardViewModel)base.DataContext;
            //var imagePath = "pack://application:,,,/Images/";
            //var uriSource = new Uri(imagePath + "round_green_play_button_4044.jpg");

            //mimg.Source = new BitmapImage(uriSource);


            //var imagePath = "pack://application:,,,/Images/";
            //var uriSource = new Uri(imagePath + "round_green_play_button_4044.jpg");

            //mimg.Source = new BitmapImage(uriSource);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("testing this shit");
        }

        private void MinusProductCount(object sender, RoutedEventArgs e)
        {
            var clth = new ReceiptModel();
            var _listBox = listboxofproduct as ListBox;
            var productTag = ((Button)sender).Tag;
            int idx = -1;
            //Incriment the productCount
            foreach (ClothsModel _listBoxItem in _listBox.Items)
            {
                idx++;
                var _Container = _listBox.ItemContainerGenerator.ContainerFromItem(_listBoxItem);
                var _Children = GetChildren(_Container);

                var productName = (Label)_Children.First(x => x.Name == "productName");
                var productCountNumber = (Label)_Children.First(x => x.Name == "productCountNumber");
                var productItemId = (Label)_Children.First(x => x.Name == "itemId");
                var price = (Label)_Children.First(x => x.Name == "productPrice");

                int productItemIdToInt = Convert.ToInt32(productItemId.Content);


                if (productItemId.Content.ToString() == productTag.ToString())
                {
                    var itemToRemove = _viewModel.ListOfSelectedItemsBind.SingleOrDefault(r => r.ItemId == productItemIdToInt);
                    if (Convert.ToInt32(productCountNumber.Content)-1 >= 1)
                    {
                        int newProductCountNumber = Convert.ToInt32(productCountNumber.Content) - 1;
                        productCountNumber.Content = newProductCountNumber.ToString();
                        _listBox.SelectedItem = _listBox.Items[idx];
                        idx = 0;

                        ObservableCollection<ReceiptModel> clothsModelList = new ObservableCollection<ReceiptModel>();
                        clothsModelList.Clear();
                        var ItemInReceipt = string.Empty;

                        //Display on receipt column
                        clth = new ReceiptModel()
                        {
                            ItemId = Convert.ToInt32(productItemId.Content.ToString()),
                            ItemTotal = Convert.ToInt32(productCountNumber.Content.ToString()) > 0 ? Convert.ToInt32(price.Content) * Convert.ToInt32(productCountNumber.Content.ToString()) : Convert.ToInt32(price.Content),
                            Item = productName.Content.ToString(),
                            ItemsCount = Convert.ToInt32(productCountNumber.Content.ToString()),

                        };


                        //only new if the item is not already on the receipt column
                        var itemId = _viewModel.ListOfSelectedItemsBind.Where(x => x.ItemId == Convert.ToInt32(productItemId.Content));

                        if (itemId.Count() >=1)
                        {

                            //First remove the current item in the list before adding
                            itemToRemove = _viewModel.ListOfSelectedItemsBind.SingleOrDefault(r => r.ItemId == productItemIdToInt);
                            _viewModel.ListOfSelectedItemsBind.Remove(itemToRemove);
                           
                        }
                        clothsModelList.Add(clth);
                        _viewModel.ListOfSelectedItemsBind.Insert(0, clth);// = clothsModelList;

                    }
                    else
                    {
                        productCountNumber.Content = 0;
                            _viewModel.ListOfSelectedItemsBind.Remove(itemToRemove);
                    
                    }
                   

                }


            }

          
            _viewModel.AllitemsTotal = _viewModel.ListOfSelectedItemsBind.Sum(x => x.ItemTotal);
            SelectedProducts();
            HighLightFirstRowOfTheReceiptByDefault();

        }

        private void ImportantCode(ListBox _listBox, ClothsModel _listBoxItem)
        {
            //var _listBox = listboxofproduct as ListBox;

            var myVideo = (TextBox)GetChildren(_listBox).First(x => x.Name == "TextBox2");
            string tttt = myVideo.Text;
            var _Container = _listBox.ItemContainerGenerator.ContainerFromItem(_listBoxItem);

            var _Children = GetChildren(_Container);
            var _Name = "productCountNumber";


            Label _control = (Label)_Children.First(c => c.Name == _Name);
            _control.Content = "88888";




            //foreach (ClothsModel _listBoxItem in _listBox.Items)
            //{
            //    //var numberOfProduct = _listBoxItem.Price + 1;
            //    // _listBoxItem.Price = 25;

            //    //_viewModel.Product.Clear();
            //    //_viewModel.Product.Add(new ClothsModel() { Name = "Eude", Price = _listBoxItem.Price+1});


            //    ImportantCode(_listBox, _listBoxItem);

            //}

        }

        private List<FrameworkElement> GetChildren(DependencyObject parent)
        {
            List<FrameworkElement> controls = new List<FrameworkElement>();

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); ++i)
            {
                var child = VisualTreeHelper.GetChild(parent, i);
                if (child is FrameworkElement)
                {
                    controls.Add(child as FrameworkElement);
                }
                controls.AddRange(GetChildren(child));
            }

            return controls;
        }

        
        private void AddProductCount(object sender, RoutedEventArgs e)
        {
            var _listBox = listboxofproduct as ListBox;
            var productTag = ((Button)sender).Tag;
            int idx = -1; 
            var clth = new ReceiptModel();
            //Incriment the productCount
            foreach (ClothsModel _listBoxItem in _listBox.Items)
            {
              
                idx++;
                var _Container = _listBox.ItemContainerGenerator.ContainerFromItem(_listBoxItem);
                var _Children = GetChildren(_Container);
               
                var productName = (Label)_Children.First(x => x.Name == "productName");
                var productCountNumber = (Label)_Children.First(x => x.Name == "productCountNumber");
                var productItemId = (Label)_Children.First(x => x.Name == "itemId");
                var price = (Label)_Children.First(x => x.Name == "productPrice");

                int productItemIdToInt  = Convert.ToInt32(productItemId.Content);



                if (productItemId.Content.ToString() == productTag.ToString())
                {
                    int newProductCountNumber = Convert.ToInt32(productCountNumber.Content)+1;
                    productCountNumber.Content = newProductCountNumber.ToString();
                    _listBox.SelectedItem = _listBox.Items[idx];
                    idx = 0;

                   
                    ObservableCollection<ReceiptModel> clothsModelList = new ObservableCollection<ReceiptModel>();
                    clothsModelList.Clear();
                    var ItemInReceipt = string.Empty;

                    //Display on receipt column
                    clth = new ReceiptModel()
                    {
                        ItemId = Convert.ToInt32(productItemId.Content.ToString()),
                        ItemTotal = Convert.ToInt32(productCountNumber.Content.ToString()) > 0 ? Convert.ToInt32(price.Content) * Convert.ToInt32(productCountNumber.Content.ToString()) : Convert.ToInt32(price.Content),
                        Item = productName.Content.ToString(),
                        ItemsCount = Convert.ToInt32(productCountNumber.Content.ToString()),
                        
                    };

                    //only new if the item is not already on the receipt column
                    var itemId = _viewModel.ListOfSelectedItemsBind.Where(x => x.ItemId == Convert.ToInt32(productItemId.Content));
                    if (itemId.Count()> 0)
                    {

                        //First remove the current item in the list before adding
                        var itemToRemove = _viewModel.ListOfSelectedItemsBind.SingleOrDefault(r => r.ItemId == productItemIdToInt);
                        _viewModel.ListOfSelectedItemsBind.Remove(itemToRemove);
                    }

                             
                    clothsModelList.Add(clth);
                  
                }
            
            }

            _viewModel.ListOfSelectedItemsBind.Insert(0, clth);// = clothsModelList;
            _viewModel.AllitemsTotal = _viewModel.ListOfSelectedItemsBind.Sum(x => x.ItemTotal);
            SelectedProducts();
            HighLightFirstRowOfTheReceiptByDefault();
           
        }

        private void RegisterProduct(object sender, RoutedEventArgs e)
        {

        }

        private void ResetProductList(object sender, RoutedEventArgs e)
        {
            _viewModel.ListOfSelectedItemsBind.Clear();
            _viewModel.AllitemsTotal = 0;
            var _listBox = listboxofproduct as ListBox;

            foreach (ClothsModel _listBoxItem in _listBox.Items)
            {
                var _Container = _listBox.ItemContainerGenerator.ContainerFromItem(_listBoxItem);
                var _Children = GetChildren(_Container);

                var productCountNumber = (Label)_Children.First(x => x.Name == "productCountNumber");
                productCountNumber.Content = "0";
                SelectedProducts();
            }
        }

        /// <summary>
        /// Highlights all selected Products
        /// </summary>
        public void SelectedProducts()
        {
            var _listBox = listboxofproduct as ListBox;
            foreach (ClothsModel _listBoxItem in _listBox.Items)
            {
                var _Container = _listBox.ItemContainerGenerator.ContainerFromItem(_listBoxItem);
                var _Children = GetChildren(_Container);

                var productCountNumber = (Label)_Children.First(x => x.Name == "productCountNumber");
                productCountNumber.Background = Brushes.Transparent;

                if(Convert.ToInt32(productCountNumber.Content)>0)
                {
                    productCountNumber.Background = Brushes.DarkSlateGray;
                }
            }

            

        }


        private void HighLightFirstRowOfTheReceiptByDefault()
        {
            var _listBox2 = listOfSelectedItemsReceipt as ListBox;
            _listBox2.SelectedItem = _listBox2.Items[0];
        
        }

        
        private void SelectProductOnLeftGrid_Event(object sender, SelectionChangedEventArgs e)
        {
          
            var _listBox2 = listOfSelectedItemsReceipt as ListBox;
            var _listBox1 = listboxofproduct as ListBox;

            
            //_listBox1.SelectedItem = _listBox1.Items[itemIndex];

            //get itemid

            if ( _listBox2.SelectedIndex!=-1)
            {
                var itemdetails = _listBox2.SelectedItem as ReceiptModel;
                var itemsId = itemdetails.ItemId;

                foreach (ClothsModel _listBoxItem in _listBox1.Items)
                {
                    var _Container = _listBox1.ItemContainerGenerator.ContainerFromItem(_listBoxItem);
                    var _Children = GetChildren(_Container);

                    var productItemId = (Label)_Children.First(x => x.Name == "itemId");

                    if (itemsId == Convert.ToInt32(productItemId.Content))
                    {
                        //_listBox2.SelectedItem = _listBox1.Items[itemsId];
                        var listModel = _listBox1.Items.CurrentItem as ClothsModel;
                        int index = _listBox1.ItemContainerGenerator.IndexFromContainer(_Container);

                        //_listBox1.Items.CurrentItem.

                        //var itemOnLeftCurrentPosition = _listBox1.Items;
                        // var theindexofit =  _listBox2.Items.IndexOf(itemsId);
                        _listBox1.SelectedItem = _listBox1.Items[index];

                        //idx = 0;
                    }

                }
            }
        
        }

        private void SelectProductOnLeftGrid_Event(object sender, MouseButtonEventArgs e)
        {

           // var _listBox2 = listOfSelectedItemsReceipt as ListBox;
           // var _listBox1 = listboxofproduct as ListBox;

           //// var itemIndex = _listBox2.SelectedIndex;
           // //var itemIndex = (sender as ListBox).SelectedItem;
           // //var item = sender as ListBox;
           // //if (item != null && item.)
           // //_listBox1.SelectedItem = _listBox1.Items[itemIndex];

           // //get itemid
           // var itemdetails = _listBox2.SelectedItem as ReceiptModel;
           // var itemsId = itemdetails.ItemId;

           // int index = _listBox1.ItemContainerGenerator.IndexFromContainer(listBoxItem);


           // foreach (ClothsModel _listBoxItem in _listBox1.Items)
           // {
           //     var _Container = _listBox1.ItemContainerGenerator.ContainerFromItem(_listBoxItem);
           //     var _Children = GetChildren(_Container);

           //     var productItemId = (Label)_Children.First(x => x.Name == "itemId");

           //     if (itemsId == Convert.ToInt32(productItemId.Content))
           //     {
           //         //_listBox2.SelectedItem = _listBox1.Items[itemsId];
           //         var listModel = _listBox1.Items.CurrentItem as ClothsModel;
           //         int index = _listBox1.ItemContainerGenerator.IndexFromContainer(_Container);

           //         //_listBox1.Items.CurrentItem.

           //         //var itemOnLeftCurrentPosition = _listBox1.Items;
           //         // var theindexofit =  _listBox2.Items.IndexOf(itemsId);
           //         _listBox1.SelectedItem = _listBox1.Items[index];

           //         //idx = 0;
           //     }

           // }
        }

       

        

       
       
    }
}
