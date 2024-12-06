using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AgendaFilm.Model
{
    public class Produto
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int fornecedor_fk { get; set; }
        public string marca { get; set; }
        public int garantia { get; set; }
        public int funcionario_fk { get; set; }
        public DateTime dataAlteracao { get; set; }
        public DateTime dataCriacao { get; set; }

        public Produto() { }

        public Produto(int id, string nome, int fornecedor_fk, string marca, int garantia, DateTime dataAlteracao, DateTime dataCriacao ,int funcionario_fk)
        {
            this.id = id;
            this.nome = nome;
            this.fornecedor_fk = fornecedor_fk;
            this.marca = marca;
            this.garantia = garantia;
            this.funcionario_fk = funcionario_fk;
            this.dataAlteracao = dataAlteracao;
            this.dataCriacao = dataCriacao;
        }
    }
}
