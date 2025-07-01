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
    public class AgendamentoRepositorio
    {
        public bool Add(Agendamentos agendamento)
        {
            using var connection = new ConnectionDb();

            agendamento.observacoes = agendamento.observacoes?.ToUpper();
            string query = @"INSERT INTO public.agendamentos(
	                            id, cliente_fk, veiculo_fk, dataHoraAgendamento, observacoes, dataAlteracao, dataCriacao, funcionario_fk)
	                            VALUES (@id, @cliente_fk, @veiculo_fk, @dataHoraAgendamento, @observacoes, @dataAlteracao, @dataCriacao, @funcionario_fk);";

            var result = connection.Connection.Execute(sql: query, param: agendamento);

            if (result == 1)
            {
                Logger.Log($"Agendamento criado com ID {agendamento.id} para cliente {agendamento.cliente_fk}, veículo {agendamento.veiculo_fk} em {agendamento.dataHoraAgendamento}.", "INFO", Global.loginLogado);
            }

            return result == 1;
        }

        public List<AgendamentoDTO> getAll()
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT 
                        a.id, 
                        c.nome AS nome_cliente, 
                        v.placa AS placa_veiculo,
                        v.modelo AS modelo_veiculo, -- <<< Adicionado aqui
                        a.dataHoraAgendamento, 
                        a.observacoes, 
                        a.dataCriacao, 
                        a.dataAlteracao, 
                        f.nome AS nome_funcionario
                    FROM 
                        agendamentos a
                    JOIN 
                        clientes c ON a.cliente_fk = c.id
                    JOIN 
                        veiculos v ON a.veiculo_fk = v.id
                    JOIN 
                        funcionarios f ON a.funcionario_fk = f.id;";

            var agendamentos = connection.Connection.Query<AgendamentoDTO>(query);

            return agendamentos.ToList();
        }


        public int getHighestId()
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT MAX(id) AS maior_id FROM agendamentos;";

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

        public bool RemoveAgendamento(int id)
        {
            using var connection = new ConnectionDb();

            string query = @"DELETE FROM agendamentos WHERE id = @Id";

            var result = connection.Connection.Execute(sql: query, param: new { Id = id });

            if (result == 1)
            {
                Logger.Log($"Agendamento com ID {id} foi removido.", "WARNING", Global.loginLogado);
            }

            return result == 1;
        }

        public bool UpdateAgendamento(Agendamentos agendamento)
        {
            using var connection = new ConnectionDb();

            agendamento.observacoes = agendamento.observacoes?.ToUpper();
            agendamento.dataAlteracao = DateTime.Now;

            string query = @"
                UPDATE public.agendamentos
                SET 
                    cliente_fk = @cliente_fk,
                    veiculo_fk = @veiculo_fk,
                    dataHoraAgendamento = @dataHoraAgendamento,
                    observacoes = @observacoes,
                    funcionario_fk = @funcionario_fk,
                    dataAlteracao = @dataAlteracao
                WHERE id = @id;";

            var result = connection.Connection.Execute(sql: query, param: agendamento);

            if (result == 1)
            {
                Logger.Log($"Agendamento com ID {agendamento.id} foi atualizado.", "INFO", Global.loginLogado);
            }

            return result == 1;
        }

        public string getNameById(int id)
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT nome FROM agendamento WHERE id = @Id;";

            string nomeRetornado = connection.Connection.QuerySingleOrDefault<string>(query, new { Id = id });

            return nomeRetornado;
        }

        public Agendamentos getById(int id)
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT * FROM agendamentos WHERE id = @Id;";

            Agendamentos agendamentoRetornado = connection.Connection.QuerySingleOrDefault<Agendamentos>(query, new { Id = id });

            return agendamentoRetornado;
        }

        public AgendamentoDTO GetDTOById(int id)
        {
            using var connection = new ConnectionDb();

            string query = @"
                SELECT 
                    a.id,
                    c.nome AS nome_cliente,
                    v.modelo AS modelo_veiculo,
                    v.placa AS placa_veiculo,
                    a.dataHoraAgendamento,
                    a.observacoes,
                    a.dataCriacao,
                    a.dataAlteracao,
                    f.nome AS nome_funcionario
                FROM agendamentos a
                JOIN clientes c ON a.cliente_fk = c.id
                JOIN veiculos v ON a.veiculo_fk = v.id
                JOIN funcionarios f ON a.funcionario_fk = f.id
                WHERE a.id = @id;";

            return connection.Connection.QuerySingleOrDefault<AgendamentoDTO>(query, new { id });
        }
        public bool AgendamentoTemOrdemServico(int agendamentoId)
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT COUNT(*) FROM ordens_servico WHERE agendamento_fk = @agendamentoId;";
            int count = connection.Connection.QuerySingleOrDefault<int>(query, new { agendamentoId });

            return count > 0;
        }
    }
}
