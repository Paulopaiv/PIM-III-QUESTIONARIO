using TotemPIMApresentacao.View;
using TotemPIMApresentacao.Model;

namespace TotemPIMApresentacao.Controller
{
    public class PessoaController
    {
        private string nome;
        private string codigo;


        public PessoaController()
        {

        }

        public PessoaController(string nome, string codigo)
        {
            this.nome = nome;
            this.codigo = codigo;

        }

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public string Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }

        public LoginFotos LoginFotos
        {
            get => default;
            set
            {
            }
        }

        public LoginEquip LoginEquip
        {
            get => default;
            set
            {
            }
        }

        public LoginDocumentos LoginDocumentos
        {
            get => default;
            set
            {
            }
        }

        public LoginApollo_11 LoginApollo_11
        {
            get => default;
            set
            {
            }
        }

        public LoginHistoria LoginHistoria
        {
            get => default;
            set
            {
            }
        }

        public LoginReplica LoginReplica
        {
            get => default;
            set
            {
            }
        }

        public LoginSuits LoginSuits
        {
            get => default;
            set
            {
            }
        }

        public PessoaModel PessoaModel
        {
            get => default;
            set
            {
            }
        }
    }
}
