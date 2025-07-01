using AgendaFilm.Controller;
using AgendaFilm.Model.DTO;
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

            veiculo.modelo = veiculo.modelo?.ToUpper();
            veiculo.marca = veiculo.marca?.ToUpper();
            string query = @"INSERT INTO public.veiculos(
	                            id, placa, modelo, ano, marca, dataAlteracao, dataCriacao, funcionario_fk, cliente_fk)
	                            VALUES (@id, @placa, @modelo, @ano, @marca, @dataAlteracao, @dataCriacao, @funcionario_fk, @cliente_fk);";

            var result = connection.Connection.Execute(sql: query, param: veiculo);

            if (result == 1)
                Logger.Log($"Veículo cadastrado: {veiculo.placa} - {veiculo.modelo} (ID: {veiculo.id})", "INFO", Global.loginLogado);
            else
                Logger.Log($"Falha ao cadastrar veículo: {veiculo.placa} (ID: {veiculo.id})", "ERROR", Global.loginLogado);

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

            if (result == 1)
                Logger.Log($"Veículo removido: {veiculo.placa} - {veiculo.modelo} (ID: {veiculo.id})", "WARNING", Global.loginLogado);
            else
                Logger.Log($"Falha ao remover veículo: {veiculo.placa} (ID: {veiculo.id})", "ERROR", Global.loginLogado);

            return result == 1;
        }

        public bool UpdateVeiculo(Veiculo veiculo)
        {
            using var connection = new ConnectionDb();

            veiculo.modelo = veiculo.modelo?.ToUpper();
            veiculo.marca = veiculo.marca?.ToUpper();
            string query = @"UPDATE public.veiculos
	                        SET id= @id, placa= @placa, modelo= @modelo, ano= @ano, marca= @marca, dataAlteracao= @dataAlteracao, dataCriacao= @dataCriacao, funcionario_fk= @funcionario_fk, cliente_fk= @cliente_fk
	                        WHERE id= @id;";

            var result = connection.Connection.Execute(sql: query, param: veiculo);

            if (result == 1)
                Logger.Log($"Veículo atualizado: {veiculo.placa} - {veiculo.modelo} (ID: {veiculo.id})", "INFO", Global.loginLogado);
            else
                Logger.Log($"Falha ao atualizar veículo: {veiculo.placa} (ID: {veiculo.id})", "ERROR", Global.loginLogado);

            return result == 1;
        }

        public string getNameById(int id)
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT nome FROM veiculos WHERE id = @Id;";

            string nomeRetornado = connection.Connection.QuerySingleOrDefault<string>(query, new { Id = id });

            return nomeRetornado;
        }

        public string getPlacaById(int id)
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT placa FROM veiculos WHERE id = @Id;";

            string placaRetornada = connection.Connection.QuerySingleOrDefault<string>(query, new { Id = id });

            return placaRetornada;
        }

        public Veiculo getById(int id)
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT * FROM veiculos WHERE id = @Id;";

            Veiculo veiculoRetornado = connection.Connection.QuerySingleOrDefault<Veiculo>(query, new { Id = id });

            return veiculoRetornado;
        }

        public bool VeiculoTemRelacionamentos(int veiculoId)
        {
            using var connection = new ConnectionDb();

            string query = @"
                SELECT COUNT(*) 
                FROM agendamentos 
                WHERE veiculo_fk = @Id";

            int total = connection.Connection.QuerySingleOrDefault<int>(query, new { Id = veiculoId });

            return total > 0;
        }

        public List<VeiculoDTO> ObterVeiculosComNomes()
        {
            using var connection = new ConnectionDb();
            string query = @"
                SELECT 
                    v.id,
                    v.placa,
                    v.modelo,
                    v.ano,
                    v.marca,
                    c.nome AS clienteNome,
                    f.nome AS nomeFuncionario,
                    v.dataCriacao,
                    v.dataAlteracao
                FROM veiculos v
                INNER JOIN clientes c ON c.id = v.cliente_fk
                INNER JOIN funcionarios f ON f.id = v.funcionario_fk
                ORDER BY v.id;
            ";
            return connection.Connection.Query<VeiculoDTO>(query).ToList();
        }

    }
    }
