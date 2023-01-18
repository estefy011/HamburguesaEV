using HamburguesaEV.Data;

namespace HamburguesaEV;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
        string dbPath = FileAccessHelper.GetLocalFilePath("burgers.db3");
        builder.Services.AddSingleton<EV_BurgerDatabase>(s => ActivatorUtilities.CreateInstance<EV_BurgerDatabase>(s, dbPath));
        return builder.Build();
	}
}
