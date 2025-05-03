using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueVinheriaAgnello
{
    internal class Produto
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Safra { get; set; }
        public string Pais { get; set; }
        public decimal PrecoVenda { get; set; }
        public int Quantidade { get; set; }

        public Produto(string nome, string tipo, string safra, string pais, decimal precoVenda, int quantidade)
        {
            Nome = nome; Tipo = tipo; Safra = safra; Pais = pais; PrecoVenda = precoVenda; Quantidade = quantidade;
        }

        public Produto()
        {

        }

    }

    
}
