﻿using AgendaFilm.Controller;
using Dapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaFilm.Model.Repositories
{
    public class FuncionarioRepositorio
    {
        public bool Add(Funcionario funcionario)
        {
            using var connection = new ConnectionDb();

            funcionario.nome = funcionario.nome?.ToUpper();
            funcionario.cargo = funcionario.cargo?.ToUpper();
            string query = @"INSERT INTO public.funcionarios(
	                        id, nome, telefone, login, senha, cargo, nivelAcesso, funcionarioAlteracao, dataAlteracao, dataCriacao)
	                        VALUES (@id, @nome, @telefone, @login, @senha, @cargo, @nivelAcesso, @funcionarioAlteracao, @dataAlteracao, @dataAlteracao);";

            var result = connection.Connection.Execute(sql: query, param: funcionario);

            if (result == 1)
            {
                Logger.Log($"Funcionário '{funcionario.nome}' cadastrado com sucesso.", "INFO", Global.loginLogado);
            }

            return result == 1; 
        }

        public List<Funcionario> GetAll()
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT * from public.funcionarios";

            var funcionarios = connection.Connection.Query<Funcionario>(sql: query);

            return funcionarios.ToList();
        }

        public int getHighestId()
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT MAX(id) AS maior_id FROM funcionarios;";

            int id = connection.Connection.QuerySingleOrDefault<int>(query);

            return id;
        }

        public bool RemoveFuncionario(Funcionario funcionario)
        {
            using var connection = new ConnectionDb();

            string query = @"DELETE FROM funcionarios WHERE id = @Id";

            var result = connection.Connection.Execute(sql: query, param: funcionario);

            if (result == 1)
            {
                Logger.Log($"Funcionário '{funcionario.nome}' (ID: {funcionario.id}) removido do sistema.", "WARNING", Global.loginLogado);
            }

            return result == 1;
        }

        public bool UpdateFuncionario(Funcionario funcionario)
        {
            using var connection = new ConnectionDb();

            funcionario.nome = funcionario.nome?.ToUpper();
            funcionario.cargo = funcionario.cargo?.ToUpper();
            string query = @"UPDATE public.funcionarios SET nome= @nome, cargo= @cargo, nivelAcesso= @nivelAcesso, funcionarioAlteracao= @funcionarioAlteracao, dataAlteracao= @dataAlteracao
	WHERE id = @id;";

            var result = connection.Connection.Execute(sql: query, param: funcionario);

            if (result == 1)
            {
                Logger.Log($"Funcionário '{funcionario.nome}' (ID: {funcionario.id}) atualizado com sucesso.", "INFO", Global.loginLogado);
            }

            return result == 1; 
        }

        public string getNameById(int id)
        {
            using var connection = new ConnectionDb();

            string query = @"SELECT nome FROM funcionarios WHERE id = @Id;";

            string nomeRetornado = connection.Connection.QuerySingleOrDefault<string>(query, new { Id = id });

            return nomeRetornado;
        }
    }
}
