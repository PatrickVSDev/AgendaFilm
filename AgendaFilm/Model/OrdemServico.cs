namespace AgendaFilm.Model
{
    public class OrdemServico
    {
        public int Id { get; set; }
        public int AgendamentoId { get; set; }
        public string Observacoes { get; set; }
        public string Status { get; set; } // a fazer, em andamento, finalizado
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public int FuncionarioId { get; set; }

        public Agendamentos Agendamento { get; set; }
        public Funcionario Funcionario { get; set; }
        public List<OrdemProduto> Produtos { get; set; }
    }
}
