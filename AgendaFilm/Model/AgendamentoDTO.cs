using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AgendaFilm.Model
{
    public class AgendamentoDTO
    {
        public int id { get; set; }
        public string nome_cliente { get; set; }
        public string modelo_veiculo { get; set; }
        public string placa_veiculo { get; set; }
        public DateTime dataHoraAgendamento { get; set; }
        public string observacoes { get; set; }
        public DateTime dataCriacao { get; set; }
        public DateTime dataAlteracao { get; set; }
        public string nome_funcionario { get; set; }
    }
}

