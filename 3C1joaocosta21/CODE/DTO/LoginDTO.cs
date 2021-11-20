using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C1joaocosta21.CODE.DTO
{
    class LoginDTO
    {
        private int _ID;
        private string _Usuario, _Senha;

        public int ID { get => _ID; set => _ID = value; }
        public string Usuario { get => _Usuario; set => _Usuario = value; }
        public string Senha { get => _Senha; set => _Senha = value; }
    }
}
