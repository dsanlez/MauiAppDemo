using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiDemoDataBinding.Models
{
    public class Product : INotifyPropertyChanged
    {
        private string? productName;
        private decimal price;
        private int stock;

        public string? ProductName
        {
            get => productName;
            set
            {
                productName = value;
                OnPropertyChanged();
            }
        }
        public decimal Price
        {
            get => price;
            set
            {
                price = value;
                OnPropertyChanged();
            }
        }
        public int Stock
        {
            get => stock;
            set
            {
                stock = value;
                OnPropertyChanged();
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
