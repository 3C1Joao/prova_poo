using _3C1joaocosta21.CODE.BLL;
using _3C1joaocosta21.CODE.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3C1joaocosta21.UI
{
    public partial class frm_Produto : Form
    {
        ProdutoBLL medbll = new ProdutoBLL();
        ProdutoDTO meddto = new ProdutoDTO();
        public frm_Produto()
        {
            InitializeComponent();
            dgv_mostrar.DataSource = medbll.Listar();

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            meddto.Produto = txt_produto.Text;
            meddto.Valor = txt_valor.Text;

            medbll.Inserir(meddto);

            MessageBox.Show("Cadastrado com sucesso!", "produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv_mostrar.DataSource = medbll.Listar();
            txt_valor.Clear();
            txt_produto.Clear();

        }
        private void btn_editar_Click(object sender, EventArgs e)
        {
            meddto.ID = int.Parse(txt_id.Text);
            meddto.Produto = txt_produto.Text;
            meddto.Valor = txt_valor.Text;

            medbll.editar(meddto);

            MessageBox.Show("Editado com sucesso!", "produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv_mostrar.DataSource = medbll.Listar();

            txt_id.Clear();
            txt_produto.Clear();
            txt_valor.Clear();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {

            meddto.ID = int.Parse(txt_id.Text);
            meddto.Produto = txt_produto.Text;
            meddto.Valor = txt_valor.Text;

            medbll.excluir(meddto);

            MessageBox.Show("Excluido com sucesso!", "produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv_mostrar.DataSource = medbll.Listar();

            txt_id.Clear();
            txt_produto.Clear();
            txt_valor.Clear();
        }

        private void dgv_mostrar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dgv_mostrar.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_produto.Text = dgv_mostrar.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_valor.Text = dgv_mostrar.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btn_editar_Click_1(object sender, EventArgs e)
        {
            meddto.ID = int.Parse(txt_id.Text);
            meddto.Produto = txt_produto.Text;
            meddto.Valor = txt_valor.Text;

            medbll.editar(meddto);

            MessageBox.Show("Editado com sucesso!", "produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv_mostrar.DataSource = medbll.Listar();

            txt_id.Clear();
            txt_produto.Clear();
            txt_valor.Clear();
        }

        private void btn_excluir_Click_1(object sender, EventArgs e)
        {
            meddto.ID = int.Parse(txt_id.Text);
            meddto.Produto = txt_produto.Text;
            meddto.Valor = txt_valor.Text;

            medbll.excluir(meddto);

            MessageBox.Show("Excluido com sucesso!", "produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv_mostrar.DataSource = medbll.Listar();

            txt_id.Clear();
            txt_produto.Clear();
            txt_valor.Clear();
        }

        private void dgv_mostrar_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dgv_mostrar.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_produto.Text = dgv_mostrar.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_valor.Text = dgv_mostrar.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
