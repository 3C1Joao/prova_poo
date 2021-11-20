using _3C1joaocosta21.CODE.BLL;
using _3C1joaocosta21.CODE.DTO;
using _3C1joaocosta21.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace _3C1joaocosta21
{
    public partial class Form1 : Form
    {
        LoginBLL loginBLL = new LoginBLL();
        LoginDTO loginDTO = new LoginDTO();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            loginDTO.Usuario = txt_usuario.Text;
            loginDTO.Senha = txt_senha.Text;

            if (loginBLL.Logar(loginDTO) == true)
            {
                frm_Produto Produto = new frm_Produto();
                Produto.ShowDialog();
            }
            else
            {
                MessageBox.Show("Verifique o e-mail e senha.", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
