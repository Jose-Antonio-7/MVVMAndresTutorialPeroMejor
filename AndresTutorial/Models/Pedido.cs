using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndresTutorial.Models
{

    internal class Pedido : ObservableObject
    {
        private string _PedidoId;
        private string _PedidoName;
        private bool _Blocked;


        public string PedidoId { get => _PedidoId; set => SetProperty(ref _PedidoId, value); }
        public string PedidoName { get => _PedidoName; set => SetProperty(ref _PedidoName, value); }
        public bool Blocked { get => _Blocked; set => SetProperty(ref _Blocked, value); }
    }
}
