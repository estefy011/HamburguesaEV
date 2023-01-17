using HamburguesaEV.Models;
using Microsoft.Maui.Controls;

namespace HamburguesaEV.Views;
[QueryProperty("Item", "Item")]

public partial class BurgerItemPage : ContentPage
{
   // Burger Item = new Burger();
    //bool _flag;

    public Burger Item
    {
        get => BindingContext as Burger;
        set => BindingContext = value;

    }
   
    public BurgerItemPage()
    {
        InitializeComponent();
        BurgerListPage EVburgerListPage = new BurgerListPage();
        EVburgerListPage.EVActualizarLista();
       
    }
    
    
    private void EVOnSaveClicked(object sender, EventArgs e)
    {
     //   Item.Name = nameB.Text;
       // Item.Description = descB.Text;
        //Item.WithExtraCheese = _flag;
        App.BurgerRepo.AddNewBurger(Item);
       
        Shell.Current.GoToAsync("///BurgerListPage");

    }
    private void EVOnCancelClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("///BurgerListPage");
    }

    private void EVOnBorrarClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("///BurgerListPage");
    }

   
    //private void EVOnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
    //{
    //  _flag = e.Value;
    //}
}
