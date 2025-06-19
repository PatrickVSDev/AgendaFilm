using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AgendaFilm.Model
{
    public class Agendamentos
    {
        public int id { get; set; }
        public int cliente_fk { get; set; }
        public int veiculo_fk { get; set; }
        public DateTime dataHoraAgendamento { get; set; }
        public string observacoes { get; set; }
        public DateTime dataAlteracao { get; set; }
        public DateTime dataCriacao { get; set; }
        public int funcionario_fk { get; set; }

        public Agendamentos() { }

        public Agendamentos(int id, int cliente_fk, int veiculo_fk, DateTime dataHoraAgendamento, string observacoes, DateTime dataAlteracao, DateTime dataCriacao ,int funcionario_fk)
        {
            this.id = id;
            this.cliente_fk = cliente_fk;
            this.veiculo_fk = veiculo_fk;
            this.dataHoraAgendamento = dataHoraAgendamento;
            this.observacoes = observacoes;
            this.dataAlteracao = dataAlteracao;
            this.dataCriacao = dataCriacao;
            this.funcionario_fk = funcionario_fk;
        }
    }
}
