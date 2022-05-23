using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoPI
{
    public class Pedido
    {
        public int codigoPedido { get; set; }
        public DateTime data { get; set; }
        public double total { get; set; }
        public int qntProdutos { get; set; }

        public int qntitems { get; set; }
        public double ValorProd { get; set; }


    }
}
