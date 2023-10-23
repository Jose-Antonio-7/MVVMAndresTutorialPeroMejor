using AndresTutorial.Models;
using AndresTutorial.Models.ViewModels;
using System.Collections.ObjectModel;
using System.Text.Json;

namespace AndresTutorial.Pages;

public partial class ListadoPedidosPage : ContentPage
{
	ObservableCollection<Pedido> pedidos;
	public ListadoPedidosPage()
	{
		InitializeComponent();
		IniciarLista();
        //BindingContext = new PedidosViewModel();
    }

	private async void IniciarLista()
	{
		HttpClient cliente = new HttpClient();
		JsonSerializerOptions _opciones = new JsonSerializerOptions
		{
			PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
			WriteIndented = true
		};

		HttpResponseMessage response = await cliente.GetAsync("https://b22a28fe-f597-4718-add8-58f325173be1.mock.pstmn.io/EjemploMaui");
		string json = await response.Content.ReadAsStringAsync();
		pedidos = JsonSerializer.Deserialize<ObservableCollection<Pedido>>(json,_opciones);
        CollectionViwsPedidos.ItemsSource = pedidos;	

	}
    private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
		Pedido pedido = (Pedido)e.Item;
		PedidoDetailViewModel detalles = new PedidoDetailViewModel { Pedido = pedido };
		PedidoDetailPage pedidoDetalles = new PedidoDetailPage();
		pedidoDetalles.BindingContext = detalles;
		await Navigation.PushAsync(pedidoDetalles);
    }

    private void Agregar_Clicked(object sender, EventArgs e)
    {
		Pedido pedido = new Pedido { PedidoId = ID.Text, PedidoName = Name.Text };
		pedidos.Add(pedido);

	}

	private void BorrarProducto(object sender, EventArgs e)
	{
        var item = sender as SwipeItem;
        if (item is null)
            return;

        var pedido = item.BindingContext as Pedido;
        if (pedido is null)
            return;

        if (pedido.Blocked == false)
            pedidos.Remove(pedido);
    }

    private void BloquearProducto(object sender, EventArgs e)
    {
        var item = sender as SwipeItem;
        if (item is null)
            return;

        var pedido = item.BindingContext as Pedido;
        if (pedido is null)
            return;

		if (pedido.Blocked == true)
			pedido.Blocked = false;
        else
			pedido.Blocked = true;


    }

    private void Switch_BindingContextChanged(object sender, EventArgs e)
    {

    }
}