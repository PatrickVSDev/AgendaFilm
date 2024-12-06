using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AgendaFilm.Model
{
    public class Fornecedor
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string documento { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public int funcionario_fk { get; set; }
        public DateTime dataAlteracao { get; set; }
        public DateTime dataCriacao { get; set; }

        public Fornecedor() { }

        public Fornecedor(int id, string nome, string documento, string telefone, string email, DateTime dataAlteracao, DateTime dataCriacao ,int funcionario_fk)
        {
            this.id = id;
            this.nome = nome;
            this.documento = documento;
            this.telefone = telefone;
            this.email = email;
            this.funcionario_fk = funcionario_fk;
            this.dataAlteracao = dataAlteracao;
            this.dataCriacao = dataCriacao;
        }
    }
}
