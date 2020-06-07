using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_comissao
{
    class Comissao //classe comissao criada para fazer o cálculo da comissao com a porcentagem definida no encapsulamento
    {
        private double porcentagem1 = 10; //criação do encapsulamento (onde a váriavel fica ocultada)
        private double porcentagem2 = 15;
        private double porcentagem3 = 20;

        //criação do método CalcularComissao onde ele tem dois parâmetros e com retorno
        public double CalcularComissao(double ValorDeVenda, double CategoriaVendedor)
        {
            double ValorFinal = 0;
            switch (CategoriaVendedor) //criação do switch pois tem 3 categorias de vendedor
            {
                case 1:
                    ValorFinal = ValorDeVenda * (porcentagem1 / 100);
                    break;

                case 2:
                    ValorFinal = ValorDeVenda * (porcentagem2 / 100);
                    break;

                case 3:
                    ValorFinal = ValorDeVenda * (porcentagem3 / 100);
                    break;
            }

            return ValorFinal; //retorna o valor final que é calculado nos cases
        }


    }
}
