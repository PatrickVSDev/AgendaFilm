using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaFilm.Model.Repositories
{
    public class ConnectionDb : IDisposable
    {

        public NpgsqlConnection Connection { get; set; }

        public ConnectionDb()
        {
            Connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=agendafilmdb;User Id = postgres;Password=12345678;");
            Connection.Open();
        }

        public void Dispose()
        {
            Connection.Dispose();
        }
    }
}
