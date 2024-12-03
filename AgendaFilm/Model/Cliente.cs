using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AgendaFilm.Model
{
    public class Cliente
    {
        public int id { get; set; }
        public string tipo_cliente { get; set; }
        public string documento { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public int funcionario_fk { get; set; }
        public DateTime dataAlteracao { get; set; }
        public DateTime dataCriacao { get; set; }

        public Cliente() { }

        public Cliente(int id, string tipo_cliente, string documento, string nome, string telefone, DateTime dataAlteracao, DateTime dataCriacao ,int funcionario_fk)
        {
            this.id = id;
            this.tipo_cliente = tipo_cliente;
            this.documento = documento;
            this.nome = nome;
            this.telefone = telefone;
            this.funcionario_fk = funcionario_fk;
            this.dataAlteracao = dataAlteracao;
            this.dataCriacao = dataCriacao;
        }
    }
}
