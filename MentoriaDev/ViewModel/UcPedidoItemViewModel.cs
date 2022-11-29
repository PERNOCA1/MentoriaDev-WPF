using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentoriaDev.ViewModel
{
    public class UcPedidoItemViewModel
    {
        public string Nome { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorUnit { get; set; }
        public decimal ValorTotalItem { get; set; }
    }
}
