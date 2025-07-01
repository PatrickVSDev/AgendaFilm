using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaFilm.Model.DTO
{
    public class ClienteRelatorioDTO
    {
        public int Id { get; set; }
        public string TipoCliente { get; set; }
        public string Documento { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string NomeFuncionario { get; set; }
        public DateTime DataAlteracao { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
