using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinproPressingApplication.Model
{
    public class ReceiptModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }


        private string _item;
        public string Item
        {
            get { return this._item; }
            set { this._item = value; OnPropertyChanged("Item"); }
        
        }
        private int _itemId;
        public int ItemId
        {
            get { return this._itemId; }
            set { this._itemId = value; OnPropertyChanged("ItemId"); }

        }
        private int _itemTotal;
        public int ItemTotal
        {
            get { return this._itemTotal; }
            set { this._itemTotal = value; OnPropertyChanged("ItemTotal"); }

        }

        private string _itemNotice;
        public string ItemNotice
        {
            get { return this._itemNotice; }
            set { this._itemNotice = value; OnPropertyChanged("ItemNotice"); }

        }

        private int _itemsCount;
        public int ItemsCount
        {
            get { return this._itemsCount; }
            set { this._itemsCount = value; OnPropertyChanged("ItemsCount"); }

        }

        private int _AllitemsTotal;
        public int AllitemsTotal
        {
            get { return this._AllitemsTotal; }
            set { this._AllitemsTotal = value; OnPropertyChanged("AllitemsTotal"); }

        }

       
    }
}
