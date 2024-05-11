using Npgsql;
using TotemPIMApresentacao.Servico;

namespace TotemPIMApresentacao.Service
{
    internal class QuestionarioService
    {
        private Dbconexao dbconexao = new Dbconexao();
        private NpgsqlConnection conexao;
        
        internal QuestionarioService()
        {
            conexao = dbconexao.GetConnection() as NpgsqlConnection;
        }

        internal void RegistrarPontos(int acertos,string codigoUsuario,string obraAtual)
        {
            
            using (NpgsqlCommand command = new NpgsqlCommand(@"INSERT INTO public.tbl_questionario (codigo, acertos,obra, data)
                                                       VALUES (@CodigoPessoa, @acertos,@obra, @Data)", conexao))
            {
                command.Parameters.AddWithValue("@CodigoPessoa", codigoUsuario);
                command.Parameters.AddWithValue("@acertos", acertos);
                command.Parameters.AddWithValue("@obra", obraAtual);
                command.Parameters.AddWithValue("@Data", DateTime.Now);

                int linhasAfetadas = command.ExecuteNonQuery();

                if (linhasAfetadas < 0)
                {
                    MessageBox.Show("Falha ao registrar o voto.");
                }
            }
        }
     
        internal (int, int) ObterInformacoesPorObra(string nomeObra)
        {
            int quantidadeAcertos = 0;
            int totalPessoas = 0;

            using (NpgsqlCommand command = new NpgsqlCommand
                (@"SELECT SUM(acertos), COUNT(DISTINCT codigo) FROM public.tbl_questionario WHERE obra = @NomeObra", conexao))
            {
                command.Parameters.AddWithValue("@NomeObra", nomeObra);

                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if (!reader.IsDBNull(0))
                    {
                        quantidadeAcertos = reader.GetInt32(0);
                    }
                    if (!reader.IsDBNull(1))
                    {
                        totalPessoas = reader.GetInt32(1);
                    }
                }
            }

            return (quantidadeAcertos, totalPessoas);
        }
    }
}

