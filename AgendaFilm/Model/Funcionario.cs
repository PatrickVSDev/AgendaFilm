using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaFilm.Model
{
    public class Funcionario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public string cargo { get; set; }
        public int nivelAcesso { get; set; }
        public DateTime dataCriacao { get; set; }
        public DateTime dataAlteracao { get; set; }
        public int funcionarioAlteracao { get; set; }


        public Funcionario() { }

        public Funcionario(int id, string nome, string telefone, string login, string senha, string cargo, int nivelAcesso, DateTime dataCriacao, DateTime dataAlteracao, int funcionarioAlteracao)
        {
            this.id = id;
            this.nome = nome;
            this.telefone = telefone;
            this.login = login;
            this.senha = senha;
            this.cargo = cargo;
            this.nivelAcesso = nivelAcesso;
            this.dataCriacao = dataCriacao;
            this.dataAlteracao = dataAlteracao;
            this.funcionarioAlteracao = funcionarioAlteracao;
        }
    }
}
