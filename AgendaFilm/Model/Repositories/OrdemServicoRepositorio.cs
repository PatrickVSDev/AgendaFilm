using AgendaFilm.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AgendaFilm.Model.Repositories
{
    public class OrdemServicoRepositorio
    {
        public bool Add(OrdemServico ordem, List<OrdemProduto> produtos)
        {
            using var connection = new ConnectionDb();
            using var transaction = connection.Connection.BeginTransaction();

            try
            {
                string queryOrdem = @"
                    INSERT INTO ordens_servico (
                        agendamento_fk, observacoes, status, dataCriacao, dataAlteracao, funcionario_fk
                    ) VALUES (
                        @AgendamentoId, @Observacoes, @Status, @DataCriacao, @DataAlteracao, @FuncionarioId
                    ) RETURNING id;";

                // Insere ordem e obtém ID gerado
                int ordemId = connection.Connection.ExecuteScalar<int>(queryOrdem, ordem, transaction);

                // Insere os produtos da ordem
                foreach (var produto in produtos)
                {
                    produto.OrdemServicoId = ordemId;

                    string queryProduto = @"
                        INSERT INTO ordem_produtos (
                            ordem_servico_fk, produto_fk, preco_unitario, quantidade
                        ) VALUES (
                            @OrdemServicoId, @ProdutoId, @PrecoUnitario, @Quantidade
                        );";

                    connection.Connection.Execute(queryProduto, produto, transaction);
                }

                transaction.Commit();
                return true;
            }
            catch
            {
                transaction.Rollback();
                return false;
            }
        }

        public List<OrdemServicoDTO> GetAll()
        {
            using var connection = new ConnectionDb();

            string query = @"
                SELECT 
                    os.id, 
                    c.nome AS ClienteNome,
                    v.modelo AS VeiculoModelo,
                    os.status,
                    os.dataCriacao,
                    os.dataAlteracao,
                    f.nome AS FuncionarioNome,
                    COALESCE(SUM(op.preco_unitario * op.quantidade), 0) AS ValorTotal
                FROM 
                    ordens_servico os
                JOIN 
                    agendamentos a ON os.agendamento_fk = a.id
                JOIN 
                    clientes c ON a.cliente_fk = c.id
                JOIN 
                    veiculos v ON a.veiculo_fk = v.id
                JOIN 
                    funcionarios f ON os.funcionario_fk = f.id
                LEFT JOIN 
                    ordem_produtos op ON os.id = op.ordem_servico_fk
                GROUP BY 
                    os.id, c.nome, v.modelo, f.nome, os.status, os.dataCriacao, os.dataAlteracao;";

            return connection.Connection.Query<OrdemServicoDTO>(query).ToList();
        }

        public OrdemServico GetById(int id)
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT * FROM ordens_servico WHERE id = @Id;";
            return connection.Connection.QuerySingleOrDefault<OrdemServico>(query, new { Id = id });
        }

        public List<OrdemProduto> GetProdutosByOrdemId(int ordemId)
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT * FROM ordem_produtos WHERE ordem_servico_fk = @ordemId;";
            return connection.Connection.Query<OrdemProduto>(query, new { ordemId }).ToList();
        }

        public bool Delete(int id)
        {
            using var connection = new ConnectionDb();
            using var transaction = connection.Connection.BeginTransaction();

            try
            {
                connection.Connection.Execute("DELETE FROM ordem_produtos WHERE ordem_servico_fk = @Id", new { Id = id }, transaction);
                connection.Connection.Execute("DELETE FROM ordens_servico WHERE id = @Id", new { Id = id }, transaction);

                transaction.Commit();
                return true;
            }
            catch
            {
                transaction.Rollback();
                return false;
            }
        }
    }
}
