using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    public class Produto
    {


        public int codigo { private set; get; }
        public string descr { private set; get; }
        public int qtde { private set; get; }
        public double preco { private set; get; }

        public void setCodigo(int c)//Set codigo
        {
            this.codigo = c;
        }

        public void setCodigo(string c)
        {
            try
            {
                setCodigo(Convert.ToInt32(c));
                //this.codigo = Convert.ToInt32(c);
            }
            catch (Exception ex)
            {

                throw new Exception("Códigio inválido: " + ex.Message);
            }
        }

        public void setDescr(string d) //Set descr
        {
            this.descr = d;
        }

        public void setPreco(double p)//Set preco
        {
            this.preco=p;
        }
        public void setPreco(string p)
        {
            try
            {
                setPreco(Convert.ToInt32(p)); 
            }
            catch (Exception ex)
            {

                throw new Exception("Preço inválido: " + ex.Message);
            }
        }

        public void setQtde(int q)//Set QTDE
        {
            this.qtde = q;
        }
        public void setQtde(string q)
        {
            try
            {
                setQtde(Convert.ToInt32(q));
            }
            catch (Exception ex)
            {

                throw new Exception("Quantidade inválida: " + ex.Message);
            }
        }




    }
}
