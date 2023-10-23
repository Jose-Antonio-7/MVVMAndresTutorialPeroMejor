using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndresTutorial.Models.ViewModels
{
    internal partial class PedidosViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Pedido> pedidos = new();

        [ObservableProperty]
        private Pedido pedido = new();

        //[ObservableProperty]
        //public bool blocked = false;


        [RelayCommand]
        private void Add()
        {
            //Pedido pedido = new Pedido { PedidoId = Pedido.PedidoId.Trim(), PedidoName = Pedido.PedidoName.Trim() };
            Pedidos.Add(pedido);
            Pedido = new();
        }
    }
}
