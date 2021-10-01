using MyClinicMed.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClinicMed.Modelo
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";

        public bool acessar(String nome, String senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.verificarLogin(nome, senha);

            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }

        public String cadastrar(String nome, String senha, String confirmarSenha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.cadastrar(nome, senha, confirmarSenha);
            if (loginDao.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
