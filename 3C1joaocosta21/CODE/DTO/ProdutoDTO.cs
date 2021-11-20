using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C1joaocosta21.CODE.DTO
{
    class ProdutoDTO
    {
        private int _ID;
        private string _Produto, _Valor;

        public int ID { get => _ID; set => _ID = value; }
        public string Produto { get => _Produto; set => _Produto = value; }
        public string Valor { get => _Valor; set => _Valor = value; }
    }
}
