namespace AndresTutorial.Pages;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AppShell());

        //await Shell.Current.GoToAsync("BienvenidaPage");

    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ListadoPedidosPage());

    }
}