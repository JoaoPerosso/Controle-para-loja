using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;

namespace Trabalho
{
    public class Cliente
    {
        public int codigo { get; private set; }
        public string nome { get; private set; }
        public string fone { get; private set; }


        public void setCodigo(int c)//Set Codigo
        {
            this.codigo = c;
        }
        public void setCodigo(string c)
        {
            try
            {
                setCodigo(Convert.ToInt32(c));

            }
            catch (Exception ex)
            {
                throw new Exception("Código inválido" + ex.Message);
            }
        }

        public void setNome(string n)//Setnome
        {
            this.nome = n;
        }

  
        public void setFone(string f)
        {
            try
            {
                this.fone = f;
            }
            catch (Exception ex)
            {

                throw new Exception("Fone inválido: " + ex.Message);
            }
        }






    }
}
