namespace AgendaFilm.Model.DTO
{
    public class VeiculoDTO
    {
        public int id { get; set; }
        public string placa { get; set; }
        public string modelo { get; set; }
        public int ano { get; set; }
        public string marca { get; set; }
        public string clienteNome { get; set; }
        public string nomeFuncionario { get; set; }
        public DateTime dataCriacao { get; set; }
        public DateTime dataAlteracao { get; set; }
    }
}
