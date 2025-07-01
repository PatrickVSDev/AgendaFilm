public class OrdemServicoDTO
{
    public int Id { get; set; }
    public string ClienteNome { get; set; }
    public string VeiculoModelo { get; set; }
    public string VeiculoPlaca { get; set; }
    public string Status { get; set; }
    public DateTime DataCriacao { get; set; }
    public DateTime DataAlteracao { get; set; }
    public DateTime DataHoraAgendada { get; set; }
    public string FuncionarioNome { get; set; }
    public string Produtos { get; set; }
    public decimal ValorTotal { get; set; }
}

