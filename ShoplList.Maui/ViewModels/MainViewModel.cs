using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShoplList.Maui.Models;
using ShoplList.Maui.Views;
using System.Collections.ObjectModel;

namespace ShoplList.Maui.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<ShopListItem> _items;

        public MainViewModel()
        {
            Items = new ObservableCollection<ShopListItem>();
            LoadItems();
        }

        private void LoadItems()
        {
            Items.Add(new ShopListItem{Nombre = "Leche", Cantidad = 2, Comprado = false});
            Items.Add(new ShopListItem { Nombre = "Pan", Cantidad = 1, Comprado = true });
            Items.Add(new ShopListItem { Nombre = "Harina", Cantidad = 3, Comprado = false });
        }
        [RelayCommand]
        private async Task ShopNewtItemFormAsync()
        {
            await Shell.Current.GoToAsync(nameof(EditShopListItemPage));
        }
    }
}
