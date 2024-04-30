using Npgsql;
using System;
using System.Data;

namespace TotemPIMApresentacao.Servico
{
    public class Dbconexao : IDisposable
    {
        private NpgsqlConnection connection;

        public Dbconexao()
        {
            connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=DB_Museu;User Id=postgres;Password=4852;");
        }

        public NpgsqlConnection GetConnection()
        {
            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {
                    // Lidar com a exceção ou relançá-la, conforme necessário
                    throw new Exception("Erro ao abrir a conexão com o banco de dados.", ex);
                }
            }

            return connection;
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (connection != null)
                {
                    if (connection.State != ConnectionState.Closed)
                    {
                        connection.Close();
                    }
                    connection.Dispose();
                    connection = null;
                }
            }
        }
    }
}
