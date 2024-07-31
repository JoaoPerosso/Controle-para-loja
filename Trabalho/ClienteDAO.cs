using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;


namespace Trabalho
{
    internal class ClienteDAO
    {
        
        //DAO - objeto de acesso aos dados
        public void gravar(Cliente obj)
        {
            Banco bb;
            
            try
            {
                bb = new Banco();
                bb.comando.CommandText = "Insert into cliente(nome,fone) values(@q,@p)";
                bb.comando.Parameters.Add("@q", NpgsqlDbType.Varchar).Value = obj.nome;
                bb.comando.Parameters.Add("@p", NpgsqlDbType.Varchar).Value = obj.fone;
                bb.comando.Prepare();  // junta os campos com o sql
                bb.comando.ExecuteNonQuery(); // executa insert,update e delete
                Banco.conexao.Close();
            
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao gravar: " + ex.Message);
            }

        }


    

        public void alterar(Cliente obj)
        {
            Banco bb;
            
            try
            {
                bb = new Banco();
                bb.comando.CommandText = "Update cliente set nome=@q, fone=@p where codigo=@c";
                bb.comando.Parameters.Add("@q", NpgsqlDbType.Varchar).Value = obj.nome;
                bb.comando.Parameters.Add("@p", NpgsqlDbType.Varchar).Value = obj.fone;
                bb.comando.Parameters.Add("@c", NpgsqlDbType.Integer).Value = obj.codigo;
                bb.comando.Prepare();  // junta os campos com o sql
                bb.comando.ExecuteNonQuery(); // executa insert,update e delete
                Banco.conexao.Close();
                
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao alterar: " + ex.Message);
            }

        }


        public void remover(Cliente obj)
        {
            Banco bb;
         
            try
            {
                bb = new Banco();
                bb.comando.CommandText = "Delete from cliente where codigo=@c";
                bb.comando.Parameters.Add("@c", NpgsqlDbType.Integer).Value = obj.codigo;
                bb.comando.Prepare();  // junta os campos com o sql
                bb.comando.ExecuteNonQuery(); // executa insert,update e delete
                Banco.conexao.Close();
                
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao remover: " + ex.Message);
            }

        }

        public DataTable listar()
        {
            Banco bb;
            try
            {
                bb = new Banco();
                bb.comando.CommandText = "Select * from cliente";
                bb.dreader = bb.comando.ExecuteReader(); //executa o sql e retorna uma tabela
                bb.tabela = new DataTable();
                bb.tabela.Load(bb.dreader);//carrega a tabela formato postgres 
                Banco.conexao.Close();
                return (bb.tabela);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar:" + ex.Message);
            }

        }

        public Cliente preencher(int cod)
        {
            Banco bb;
            Cliente obj = null;
            try
            {
                bb = new Banco();
                bb.comando.CommandText = "Select codigo,nome,fone from cliente where codigo=@c";
                bb.comando.Parameters.Add("@c", NpgsqlDbType.Integer).Value = cod;
                bb.comando.Prepare();
                bb.dreader = bb.comando.ExecuteReader();
                if (bb.dreader.Read()) //verifica a existência do próximo registro
                {
                    obj = new Cliente();
                    obj.setCodigo((int)bb.dreader[0]);
                    if (bb.dreader[1] != null)
                    obj.setNome(bb.dreader[1].ToString());
                    obj.setFone(bb.dreader[2].ToString());
                }
                bb.dreader.Close();
                Banco.conexao.Close();
                return (obj);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao preencher: " + ex.Message);
            }
        }



    }
}
