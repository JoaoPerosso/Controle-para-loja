using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    public class Venda
    {
        public int codigoCli { get; private set; }
        public int codigoProduto { get; private set; }
        public double total { get; private set; }
        public DateTime data { get; private set; }
        public int codigo { get; private set; }

        public void setcodigoCli(int cod)//Codigo cliente
        {
            this.codigoCli = cod;
        }
        public void setcodigoCli(string cod)
        {
            setcodigoCli(Convert.ToInt32(cod));
        }

        public void setcodigoProduto(int codP)//Codigo Produto
        {
            this.codigoProduto = codP;
        }
        public void setcodigoProduto(string codP)
        {
            setcodigoProduto(Convert.ToInt32(codP));
        }

        public void setdata(DateTime d)
        {
            this.data = d;
            
        }
        
        public void setTotal(double t)
        {
            this.total = t;
        }

        public void setCodigo(int c)
        {
            this.codigo = c;
        }


    }
}
