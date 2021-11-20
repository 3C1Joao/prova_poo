using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3C1joaocosta21.CODE.DTO;
using _3C1joaocosta21.CODE.DTA;
using System.Data;

namespace _3C1joaocosta21.CODE.BLL
{
    class ProdutoBLL
    {
            AcessoBancoDados conexao = new AcessoBancoDados();
            string tabela = "produto";

            public void Inserir(ProdutoDTO medDto)
            {
                string inserir = $"insert into {tabela} values(null,'{medDto.Produto}','{medDto.Valor}')";
                conexao.ExecutarComando(inserir);
            }

            public void editar(ProdutoDTO medDto)
            {
                string editar = $"update {tabela} set nome_produto = '{medDto.Produto}', valor_produto = '{medDto.Valor}' where id='{medDto.ID}';";
                conexao.ExecutarComando(editar);
            }
            public void excluir(ProdutoDTO medDto)
            {
                string excluir = $"delete from {tabela} where id = '{medDto.ID}';";
                conexao.ExecutarComando(excluir);

            }

            public DataTable Listar()
            {
                string sql = $"select * from {tabela} order by id;";
                return conexao.ExecutarConsulta(sql);
            }
    }
}
