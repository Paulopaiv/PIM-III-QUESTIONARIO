using Npgsql;
using System;
using Dapper;

using TotemPIMApresentacao.Controller;

namespace TotemPIMApresentacao.Servico
{
    public class PessoaServico
    {
        private readonly Dbconexao dbconexao;

        public PessoaServico(Dbconexao conexao)
        {
            this.dbconexao = conexao;
        }

        public PessoaControle BuscarPorCodigo(PessoaControle pessoa)
        {
            using (var conexao = new Dbconexao())
            {
                var connection = conexao.GetConnection();

                var resultado = connection.QueryFirstOrDefault(
                   "SELECT * FROM visitante WHERE Codigo = @codigo ",
                    new { Codigo = pessoa.Codigo });

                if (resultado == null)
                {
                    return null;
                }
                pessoa.Codigo = resultado.codigo;
                pessoa.Nome = resultado.nome;
                return pessoa;
            }
        }
    }
}
