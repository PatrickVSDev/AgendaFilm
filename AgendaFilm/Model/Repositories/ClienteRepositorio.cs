﻿using AgendaFilm.Controller;
using AgendaFilm.Model.DTO;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaFilm.Model.Repositories
{
    public class ClienteRepositorio
    {
        public bool Add(Cliente cliente)
        {
            using var connection = new ConnectionDb();

            cliente.nome = cliente.nome?.ToUpper();
            string query = @"INSERT INTO public.clientes(
	                            id, tipo_cliente, documento, nome, telefone, funcionario_fk, dataAlteracao, dataCriacao)
	                            VALUES (@id, @tipo_cliente, @documento, @nome, @telefone, @funcionario_fk, @dataAlteracao, @dataCriacao);";

            var result = connection.Connection.Execute(sql: query, param: cliente);

            if (result == 1)
            {
                Logger.Log($"Cliente '{cliente.nome}' cadastrado com sucesso.", "INFO", Global.loginLogado);
            }

            return result == 1;
        }

        public List<Cliente> GetAll()
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT * from public.clientes";

            var clientes = connection.Connection.Query<Cliente>(sql: query);

            return clientes.ToList();
        }

        public int getHighestId()
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT MAX(id) AS maior_id FROM clientes;";

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

        public bool RemoveCliente(Cliente cliente)
        {
            using var connection = new ConnectionDb();

            string query = @"DELETE FROM clientes WHERE id = @Id";

            var result = connection.Connection.Execute(sql: query, param: cliente);

            if (result == 1)
            {
                Logger.Log($"Cliente '{cliente.nome}' (ID: {cliente.id}) foi excluído.", "WARNING", Global.loginLogado);
            }

            return result == 1;
        }

        public bool UpdateCliente(Cliente cliente)
        {
            using var connection = new ConnectionDb();

            cliente.tipo_cliente = cliente.tipo_cliente?.ToUpper();
            cliente.nome = cliente.nome?.ToUpper();
            string query = @"UPDATE public.clientes
	                        SET id= @id, tipo_cliente= @tipo_cliente, documento= @documento, nome= @nome, telefone= @telefone, funcionario_fk= @funcionario_fk, dataAlteracao= @dataAlteracao, dataCriacao= @dataCriacao
	                        WHERE id= @id;";

            var result = connection.Connection.Execute(sql: query, param: cliente);

            if (result == 1)
            {
                Logger.Log($"Cliente '{cliente.nome}' (ID: {cliente.id}) foi atualizado.", "INFO", Global.loginLogado);
            }

            return result == 1;
        }

        public string getNameById(int id)
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT nome FROM clientes WHERE id = @Id;";

            string nomeRetornado = connection.Connection.QuerySingleOrDefault<string>(query, new { Id = id });

            return nomeRetornado;
        }

        public Cliente getById(int id)
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT * FROM clientes WHERE id = @Id;";

            Cliente clienteRetornado = connection.Connection.QuerySingleOrDefault<Cliente>(query, new { Id = id });

            return clienteRetornado;
        }

        public bool ClienteTemRelacionamentos(int clienteId)
        {
            using var connection = new ConnectionDb();

            string query = @"
                SELECT EXISTS (
                    SELECT 1 FROM veiculos WHERE cliente_fk = @Id
                    UNION
                    SELECT 1 FROM agendamentos WHERE cliente_fk = @Id
                    UNION
                    SELECT 1 FROM ordens_servico os 
                        INNER JOIN agendamentos a ON os.agendamento_fk = a.id 
                        WHERE a.cliente_fk = @Id
                );";

            return connection.Connection.ExecuteScalar<bool>(query, new { Id = clienteId });
        }

        public List<ClienteRelatorioDTO> ObterClientesComNomeFuncionario()
        {
            using var connection = new ConnectionDb();

            string query = @"
                SELECT 
                    c.id AS Id,
                    c.tipo_cliente AS TipoCliente,
                    c.documento AS Documento,
                    c.nome AS Nome,
                    c.telefone AS Telefone,
                    f.nome AS NomeFuncionario,
                    c.dataAlteracao AS DataAlteracao,
                    c.dataCriacao AS DataCriacao
                FROM clientes c
                INNER JOIN funcionarios f ON f.id = c.funcionario_fk
                ORDER BY c.id;
            ";

            var clientesDTO = connection.Connection.Query<ClienteRelatorioDTO>(query).ToList();

            return clientesDTO;
        }

    }
}
