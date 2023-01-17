using HamburguesaEV.Models;

namespace HamburguesaEV.Views;

public partial class BurgerListPage : ContentPage
{
   
    public BurgerListPage()
    {
        
        InitializeComponent();
        List<Burger> burger = App.BurgerRepo.GetAllBurgers();
        burgerList.ItemsSource = burger;
       
    }
    async void OnItemAdded(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(BurgerItemPage));
       
    }
    public void EVActualizarLista()
    {
        List<Burger> burger = App.BurgerRepo.GetAllBurgers();
        burgerList.ItemsSource = burger;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        {
            EVActualizarLista();
        }
    }
}