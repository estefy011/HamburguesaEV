using HamburguesaEV.Models;

namespace HamburguesaEV.Views;

public partial class BurgerListPage : ContentPage
{
   
    public BurgerListPage()
    {
        
        InitializeComponent();
        List<Burger> burger = App.BurgerRepo.GetAllBurgers();
        burgerList.ItemsSource = burger;
        BindingContext = this;

    }
    public void OnItemAdded(object sender, EventArgs e)
    {
       Shell.Current.GoToAsync(nameof(BurgerItemPage),true,new Dictionary<string,object>
           {
           {"Item",new Burger()}
       });

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
    private void EVOnCollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }
}