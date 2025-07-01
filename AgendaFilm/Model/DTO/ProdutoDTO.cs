namespace AgendaFilm.Model.DTO
{
    public class ProdutoDTO
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string marca { get; set; }
        public int garantia { get; set; }
        public string fornecedorNome { get; set; }
        public DateTime dataCriacao { get; set; }
        public DateTime dataAlteracao { get; set; }
        public int funcionario_fk { get; set; }
        public string funcionarioNome { get; set; }
    }
}
