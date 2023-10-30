namespace AndresTutorial.Pages;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(BienvenidaPage),typeof(BienvenidaPage));
	}
}