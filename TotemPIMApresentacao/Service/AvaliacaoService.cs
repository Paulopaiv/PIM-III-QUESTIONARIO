using Npgsql;
using TotemPIMApresentacao.Servico;

namespace TotemPIMApresentacao.Service
{
    internal class AvaliacaoService
    {
        private Dbconexao dbconexao = new Dbconexao();
        private NpgsqlConnection conexao;
        
        internal AvaliacaoService()
        {
            conexao = dbconexao.GetConnection() as NpgsqlConnection;
        }

        internal void RegistrarPontos(int acertos,string codigoUsuario,string obraAtual)
        {
            
            using (NpgsqlCommand command = new NpgsqlCommand(@"INSERT INTO public.questionario (codigo, acertos, data)
                                                       VALUES (@CodigoPessoa, @acertos, @Data)", conexao))
            {
                command.Parameters.AddWithValue("@CodigoPessoa", codigoUsuario);
                command.Parameters.AddWithValue("@acertos", acertos);
                command.Parameters.AddWithValue("@Data", DateTime.Now);

                int linhasAfetadas = command.ExecuteNonQuery();

                if (linhasAfetadas < 0)
                {
                    MessageBox.Show("Falha ao registrar o voto.");
                }
            }
        }
    }

}

