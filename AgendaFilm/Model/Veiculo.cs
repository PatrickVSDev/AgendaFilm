using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AgendaFilm.Model
{
    public class Veiculo
    {
        public int id { get; set; }
        public string placa { get; set; }
        public string modelo { get; set; }
        public int ano { get; set; }
        public string marca { get; set; }
        public DateTime dataAlteracao { get; set; }
        public DateTime dataCriacao { get; set; }
        public int funcionario_fk { get; set; }
        public int cliente_fk { get; set; }

        public Veiculo() { }

        public Veiculo(int id, string placa, string modelo, int ano, string marca, DateTime dataAlteracao, DateTime dataCriacao ,int funcionario_fk, int cliente_fk)
        {
            this.id = id;
            this.placa = placa;
            this.modelo = modelo;
            this.ano = ano;
            this.marca = marca;
            this.dataAlteracao = dataAlteracao;
            this.dataCriacao = dataCriacao;
            this.funcionario_fk = funcionario_fk;
            this.cliente_fk = cliente_fk;
        }
    }
}
