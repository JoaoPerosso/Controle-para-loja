using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    internal class Item
    {
        public int codigo { get; private set; }
        public int codVenda { get; private set; }
        public int codProduto { get; private set; }
        public int qtde { get; private set; }
        public double precounit { get; private set; }


        public void setcodVenda(int cod)//Codigo Venda
        {
            this.codVenda = cod;
        }
        public void setcodVenda(string cod)
        {
            setcodVenda(Convert.ToInt32(cod));
        }

        public void setcodigoProduto(int codP)//Codigo Produto
        {
            this.codProduto = codP;
        }
        public void setcodigoProduto(string codP)
        {
            setcodigoProduto(Convert.ToInt32(codP));
        }

        public void setQtde(int q)//Set qtde
        {
            this.qtde = q;
        }
        public void setQtde(string q)
        {
            setQtde(Convert.ToInt32(q));
        }

        public void setPrecounit(double t)//set PrecoUnit
        {
            this.precounit = t;
        }
        public void setPrecounit(string t)
        {
            setPrecounit(Convert.ToDouble(t));
        }

        public void setCodigo(int c)//set codigo
        {
            this.codigo = c;
        }
        public void setCodigo(string c)
        {
            setCodigo(Convert.ToInt32(c));
        }



    }
}
