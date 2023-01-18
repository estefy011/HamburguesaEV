using HamburguesaEV.Models;

namespace HamburguesaEV.Views;

public partial class BurgerListPage : ContentPage
{
   
    public BurgerListPage()
    {
        
        InitializeComponent();
        List<BurgerEV> burger = App.BurgerRepo.GetAllBurgers();
        burgerList.ItemsSource = burger;
        BindingContext = this;

    }
    public void OnItemAdded(object sender, EventArgs e)
    {
       Shell.Current.GoToAsync(nameof(BurgerItemPage),true,new Dictionary<string,object>
           {
           {"Item",new BurgerEV()}
       });

    }
    public void EVActualizarLista()
    {
        List<BurgerEV> burger = App.BurgerRepo.GetAllBurgers();
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
        BurgerEV burger = e.CurrentSelection.FirstOrDefault() as BurgerEV;
        if (burger == null)
            return;
        Shell.Current.GoToAsync(nameof(BurgerItemPage), true, new Dictionary<string, object>
        {
            {"Item",burger}
        });
        ((CollectionView)sender).SelectedItem = null;

       

    }
}