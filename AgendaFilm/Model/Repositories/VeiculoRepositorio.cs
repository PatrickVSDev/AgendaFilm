using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaFilm.Model.Repositories
{
    public class VeiculoRepositorio
    {
        public bool Add(Veiculo veiculo)
        {
            using var connection = new ConnectionDb();

            string query = @"INSERT INTO public.veiculos(
	                            id, placa, modelo, ano, marca, dataAlteracao, dataCriacao, funcionario_fk, cliente_fk)
	                            VALUES (@id, @placa, @modelo, @ano, @marca, @dataAlteracao, @dataCriacao, @funcionario_fk, @cliente_fk);";

            var result = connection.Connection.Execute(sql: query, param: veiculo);

            return result == 1;
        }

        public List<Veiculo> GetAll()
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT * from public.veiculos";

            var veiculos = connection.Connection.Query<Veiculo>(sql: query);

            return veiculos.ToList();
        }

        public int getHighestId()
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT MAX(id) AS maior_id FROM veiculos;";

            int id;

            try
            {
                id = connection.Connection.QuerySingleOrDefault<int>(query);
            }
            catch (System.Data.DataException ex)
            {
                return -1;
            }

            return id;
        }

        public bool RemoveVeiculo(Veiculo veiculo)
        {
            using var connection = new ConnectionDb();

            string query = @"DELETE FROM veiculos WHERE id = @Id";

            var result = connection.Connection.Execute(sql: query, param: veiculo);

            return result == 1;
        }

        public bool UpdateVeiculo(Veiculo veiculo)
        {
            using var connection = new ConnectionDb();

            string query = @"UPDATE public.veiculos
	                        SET id= @id, placa= @placa, modelo= @modelo, ano= @ano, marca= @marca, dataAlteracao= @dataAlteracao, dataCriacao= @dataCriacao, funcionario_fk= @funcionario_fk, cliente_fk= @cliente_fk
	                        WHERE id= @id;";

            var result = connection.Connection.Execute(sql: query, param: veiculo);

            return result == 1;
        }

        public string getNameById(int id)
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT nome FROM veiculos WHERE id = @Id;";

            string nomeRetornado = connection.Connection.QuerySingleOrDefault<string>(query, new { Id = id });

            return nomeRetornado;
        }

        public Veiculo getById(int id)
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT * FROM veiculos WHERE id = @Id;";

            Veiculo veiculoRetornado = connection.Connection.QuerySingleOrDefault<Veiculo>(query, new { Id = id });

            return veiculoRetornado;
        }
    }
}
