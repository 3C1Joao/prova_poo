using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3C1joaocosta21.CODE.DTA;
using _3C1joaocosta21.CODE.DTO;



namespace _3C1joaocosta21.CODE.BLL
{
    class LoginBLL
    {
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "login";

        public bool Logar(LoginDTO Login)
        {
            string sql = $"select * from {tabela} where usuario='{Login.Usuario}' and senha='{Login.Senha}'";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public string RSenha(LoginDTO login)
        {
            string sql = $"select * from {tabela} where email='{login.Usuario}'";
            DataTable dt = conexao.ExecutarConsulta(sql);


            if (dt.Rows.Count > 0)
                return dt.Rows[0]["senha"].ToString();
            else
                return "false";
        }

    }
}
