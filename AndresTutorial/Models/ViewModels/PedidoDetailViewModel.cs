using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndresTutorial.Models.ViewModels
{
    internal partial class PedidoDetailViewModel : ObservableObject
    {
        [ObservableProperty]
        public Pedido pedido;
    }
}
