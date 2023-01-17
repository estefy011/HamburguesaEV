using HamburguesaEV.Data;
using HamburguesaEV.Views;

namespace HamburguesaEV;

public partial class App : Application
{
    public static BurgerDatabase BurgerRepo { get; private set; }

    public App(BurgerDatabase repo)
    {
        InitializeComponent();

        MainPage = new AppShell();

        BurgerRepo = repo;
    }
}
