using HamburguesaEV.Data;
using HamburguesaEV.Views;

namespace HamburguesaEV;

public partial class App : Application
{
    public static EV_BurgerDatabase BurgerRepo { get; private set; }

    public App(EV_BurgerDatabase repoEV)
    {
        InitializeComponent();

        MainPage = new AppShell();

        BurgerRepo = repoEV;
    }
}
