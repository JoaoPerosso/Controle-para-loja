using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    internal class ItemDAO
    {


        public void gravar(Item obj)
        {
            Banco bb;
            //int codigo;
            try
            {
                bb = new Banco();
                bb.comando.CommandText = "Insert into item(codvenda, codproduto, qtde, precounit) values (@cd, @cp, @q, @p)";
                bb.comando.Parameters.Add("@cd", NpgsqlDbType.Integer).Value = obj.codVenda;
                bb.comando.Parameters.Add("@cp", NpgsqlDbType.Integer).Value = obj.codProduto;
                bb.comando.Parameters.Add("@q", NpgsqlDbType.Integer).Value = obj.qtde;
                bb.comando.Parameters.Add("@p", NpgsqlDbType.Double).Value = obj.precounit;

                bb.comando.Prepare();  // junta os campos com o sql
                                       //qtde = bb.comando.ExecuteNonQuery(); // executa insert,update e delete
                bb.comando.ExecuteNonQuery();
                //obj.setCodigo(codigo);
                Banco.conexao.Close();
                //return (codigo);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao gravar no item: " + ex.Message);
            }
        }
    }
}
