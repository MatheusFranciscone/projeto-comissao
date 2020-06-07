using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_comissao
{
    public partial class frm_Comissao : Form
    {
        public frm_Comissao()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {

            if (txt_ValorVenda.Text == "") //criacao de um if caso o usuario nao digite nada no textbox
            {

                MessageBox.Show("Digite todos o valor de sua venda!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_ValorVenda.Focus();

            } 
            else if (rdb_A.Checked == false && rdb_B.Checked == false && rdb_C.Checked == false) //criacao de um if caso o usuario nao escolha nenhuma categoria
            {

                MessageBox.Show("Selecione uma categoria!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gpb_Categoria.Focus();

            }
            else
            {

                Comissao com = new Comissao(); //chamada da classe para poder utilizar o metodo

                double preco_venda = Convert.ToDouble(txt_ValorVenda.Text); //atribuicao de variavel para dizer que o valor da compra esta na textbox

                double categoria = 0; //atribuicao de variavel para contar o case chamado

                if (rdb_A.Checked)
                {

                    categoria = 1; //escolha de case

                }
                else if (rdb_B.Checked)
                {

                    categoria = 2;

                }
                else
                {

                    categoria = 3;

                }

                double resultado = com.CalcularComissao(preco_venda, categoria); //chamada do metodo com os parametros criados nesse formulario

                txt_ValorCom.Text = resultado.ToString(); //mostra o resultado do metodo que foi atribuido na variavel resultado

            }

        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close(); //botao sair vai fechar o formulario
        }

        private void txt_ValorVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08) //o usuario nao consegue digitar letra no textbox do valor da vendo
            {
                e.Handled = true;
            }
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_ValorVenda.Clear();
            txt_ValorCom.Clear();
            rdb_A.Checked = false;
            rdb_B.Checked = false;
            rdb_C.Checked = false;
            txt_ValorVenda.Focus();
        }
    }
}
