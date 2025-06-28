using AgendaFilm.Controller;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaFilm.Model.Repositories
{
    public class FornecedorRepositorio
    {
        public bool Add(Fornecedor fornecedor)
        {
            using var connection = new ConnectionDb();

            fornecedor.nome = fornecedor.nome?.ToUpper();
            fornecedor.nome = fornecedor.email?.ToUpper();
            string query = @"INSERT INTO public.fornecedores(
	                            id, nome, documento, telefone, email, funcionario_fk, dataAlteracao, dataCriacao)
	                            VALUES (@id, @nome, @documento, @telefone, @email, @funcionario_fk, @dataAlteracao, @dataCriacao);";

            var result = connection.Connection.Execute(sql: query, param: fornecedor);

            if (result == 1)
            {
                Logger.Log($"Fornecedor '{fornecedor.nome}' cadastrado com sucesso.", "INFO", Global.loginLogado);
            }

            return result == 1;
        }

        public List<Fornecedor> GetAll()
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT * from public.fornecedores";

            var fornecedores = connection.Connection.Query<Fornecedor>(sql: query);

            return fornecedores.ToList();
        }

        public int getHighestId()
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT MAX(id) AS maior_id FROM fornecedores;";

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

        public bool RemoveFornecedor(Fornecedor fornecedor)
        {
            using var connection = new ConnectionDb();

            string query = @"DELETE FROM fornecedores WHERE id = @Id";

            var result = connection.Connection.Execute(sql: query, param: fornecedor);

            if (result == 1)
            {
                Logger.Log($"Fornecedor '{fornecedor.nome}' (ID: {fornecedor.id}) foi removido.", "WARNING", Global.loginLogado);
            }

            return result == 1;
        }

        public bool UpdateFornecedor(Fornecedor fornecedor)
        {
            using var connection = new ConnectionDb();

            fornecedor.nome = fornecedor.nome?.ToUpper();
            fornecedor.nome = fornecedor.email?.ToUpper();
            string query = @"UPDATE public.fornecedores
	                        SET id= @id, nome= @nome, documento= @documento, telefone= @telefone, email= @email, funcionario_fk= @funcionario_fk, dataAlteracao= @dataAlteracao, dataCriacao= @dataCriacao
	                        WHERE id= @id;";

            var result = connection.Connection.Execute(sql: query, param: fornecedor);

            if (result == 1)
            {
                Logger.Log($"Fornecedor '{fornecedor.nome}' (ID: {fornecedor.id}) foi atualizado.", "INFO", Global.loginLogado);
            }

            return result == 1;
        }

        public string getNameById(int id)
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT nome FROM fornecedores WHERE id = @Id;";

            string nomeRetornado = connection.Connection.QuerySingleOrDefault<string>(query, new { Id = id });

            return nomeRetornado;
        }

        public Fornecedor getById(int id)
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT * FROM fornecedores WHERE id = @Id;";

            Fornecedor fornecedorRetornado = connection.Connection.QuerySingleOrDefault<Fornecedor>(query, new { Id = id });

            return fornecedorRetornado;
        }
    }
}
