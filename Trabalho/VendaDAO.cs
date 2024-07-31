using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    public class VendaDAO
    {
        public void gravar()
        {
            Banco bb;
            Venda obj;
            try
            {
                bb = new Banco();
                obj = new Venda();
                bb.comando.CommandText = "insert into venda (codcli, datavenda, total) values(@cc,@tt)";
                bb.comando.Parameters.Add("@cc", NpgsqlDbType.Integer).Value = obj.codigoCli;
                
                bb.comando.Parameters.Add("@dd", NpgsqlDbType.Date).Value = obj.data;
                bb.comando.Parameters.Add("@tt", NpgsqlDbType.Double).Value = obj.total;

               
                bb.comando.Prepare();  // junta os campos com o sql
                bb.comando.ExecuteNonQuery(); // executa insert,update e delete
                Banco.conexao.Close();
                
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao gravar: " + ex.Message);
            }

        }
        public int gravarGetCodigo(Venda obj)
        {
            Banco bb;
            int codigo;
            try
            {
                bb = new Banco();
                bb.comando.CommandText = "Insert into venda(total, datavenda, codcli) values (@t, @d, @cc) returning codigo";
                bb.comando.Parameters.Add("@t", NpgsqlDbType.Double).Value = obj.total;
                bb.comando.Parameters.Add("@d", NpgsqlDbType.Date).Value = obj.data;
                bb.comando.Parameters.Add("@cc", NpgsqlDbType.Integer).Value = obj.codigoCli;
                bb.comando.Prepare();  // junta os campos com o sql
                //qtde = bb.comando.ExecuteNonQuery(); // executa insert,update e delete
                codigo = (int)bb.comando.ExecuteScalar();
                obj.setCodigo(codigo);
                Banco.conexao.Close();
                return (codigo);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao gravar: " + ex.Message);
            }
        }
    }

}
