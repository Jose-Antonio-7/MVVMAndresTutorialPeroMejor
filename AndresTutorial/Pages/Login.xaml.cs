namespace AndresTutorial.Pages;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        //Navegacion NavigationPage
        //await Navigation.PushAsync(new AppShell());

        //Navegacion Shell/Flyout
        //No tiene el boton flyout al entrar
        //await Shell.Current.GoToAsync("BienvenidaPage");

        //Si tiene boton flyout al entrar checar sin nameof ("//BienvenidaPage")
        await Shell.Current.GoToAsync($"//{nameof(BienvenidaPage)}");


    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ListadoPedidosPage());

    }
}