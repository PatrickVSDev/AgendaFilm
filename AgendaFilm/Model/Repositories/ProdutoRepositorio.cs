using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace AgendaFilm.Model.Repositories
{
    public class ProdutoRepositorio
    {
        public bool Add(Produto produto)
        {
            using var connection = new ConnectionDb();

            produto.nome = produto.nome?.ToUpper();
            produto.marca = produto.marca?.ToUpper();
            string query = @"INSERT INTO public.produtos(
	                            id, nome, fornecedor_fk, marca, garantia, funcionario_fk, dataAlteracao, dataCriacao)
	                            VALUES (@id, @nome, @fornecedor_fk, @marca, @garantia, @funcionario_fk, @dataAlteracao, @dataCriacao);";

            var result = connection.Connection.Execute(sql: query, param: produto);

            return result == 1;
        }

        public List<Produto> GetAll()
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT * from public.produtos";

            var produtos = connection.Connection.Query<Produto>(sql: query);

            return produtos.ToList();
        }

        public int getHighestId()
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT MAX(id) AS maior_id FROM produtos;";

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

        public bool RemoveProduto(Produto produto)
        {
            using var connection = new ConnectionDb();

            string query = @"DELETE FROM produtos WHERE id = @Id";

            var result = connection.Connection.Execute(sql: query, param: produto);

            return result == 1;
        }

        public bool UpdateProduto(Produto produto)
        {
            using var connection = new ConnectionDb();

            produto.nome = produto.nome?.ToUpper();
            produto.marca = produto.marca?.ToUpper();
            string query = @"UPDATE public.produtos
	                        SET id= @id, nome= @nome, fornecedor_fk= @fornecedor_fk, marca= @marca, garantia= @garantia, funcionario_fk= @funcionario_fk, dataAlteracao= @dataAlteracao, dataCriacao= @dataCriacao
	                        WHERE id= @id;";

            var result = connection.Connection.Execute(sql: query, param: produto);

            return result == 1;
        }

        public string getNameById(int id)
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT nome FROM produtos WHERE id = @Id;";

            string nomeRetornado = connection.Connection.QuerySingleOrDefault<string>(query, new { Id = id });

            return nomeRetornado;
        }

        public Produto getById(int id)
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT * FROM produtos WHERE id = @Id;";

            Produto produtoRetornado = connection.Connection.QuerySingleOrDefault<Produto>(query, new { Id = id });

            return produtoRetornado;
        }
    }
}
