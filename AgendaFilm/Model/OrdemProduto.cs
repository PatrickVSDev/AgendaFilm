namespace AgendaFilm.Model
{
    public class OrdemProduto
    {
        public int Id { get; set; }
        public int OrdemServicoId { get; set; }
        public int ProdutoId { get; set; }
        public decimal PrecoUnitario { get; set; }
        public int Quantidade { get; set; }

        public Produto Produto { get; set; }
    }
}
