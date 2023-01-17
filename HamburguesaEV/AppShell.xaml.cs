using HamburguesaEV.Views;

namespace HamburguesaEV;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(BurgerItemPage), typeof(BurgerItemPage));
    }
}
