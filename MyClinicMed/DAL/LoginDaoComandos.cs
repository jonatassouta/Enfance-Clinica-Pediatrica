using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClinicMed.DAL
{
    public class LoginDaoComandos
    {
        public bool tem = false;
        public String mensagem = "";//tudo ok

        public SqlCommand cmd = new SqlCommand();
        public Conexao con = new Conexao();
        public SqlDataReader dr;//Classe sql para guardar as informaçoes

        public bool verificarLogin(String nome, String senha)
        {
            //Procurar no banco esse usuario e senha
            cmd.CommandText = "select * from Usuarios where nome = @nome and senha = @senha";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();//ExecuteReader é para quando vc pega informaçoes do banco de dados para ser guardado
               
                if (dr.HasRows)//tem linhas? se foi encontrado
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();
            }
            catch (SqlException e)
            {
                //Erro com Banco de Dados!
                this.mensagem = e.Message;
            }

            return tem;
        }

        public String cadastrar(String nome, String senha, String confirmarSenha)
        {
            tem = false;

            //comandos sql para inserir no banco
            if (senha.Equals(confirmarSenha))
            {
                cmd.CommandText = "insert into Usuarios values (@e, @s)";
                cmd.Parameters.AddWithValue("@e", nome);
                cmd.Parameters.AddWithValue("@s", senha);

                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();

                    this.mensagem = "Cadastrado com sucesso";

                    tem = true;
                }
                catch (SqlException)
                {
                    this.mensagem = "Erro com Banco de Dados";
                }
            }
            else
            {
                this.mensagem = "Senhas não correpondem";
            }

            return mensagem;
        }
    }
}
