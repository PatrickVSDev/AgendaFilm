using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaFilm.Model.Repositories
{
    public static class Logger
    {
        private static string _connectionString = "Host=localhost;Port=5432;Database=agendafilmdb;Username=postgres;Password=2746";

        public static void Log(string mensagem, string nivel = "INFO", string usuario = null)
        {
            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("INSERT INTO logs (nivel, mensagem, usuario) VALUES (@nivel, @mensagem, @usuario)", conn))
                    {
                        cmd.Parameters.AddWithValue("@nivel", nivel);
                        cmd.Parameters.AddWithValue("@mensagem", mensagem);
                        cmd.Parameters.AddWithValue("@usuario", (object)usuario ?? DBNull.Value);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao registrar log: {ex.Message}");
            }
        }
    }
}
