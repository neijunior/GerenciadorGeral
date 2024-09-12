using GerenciadorGeral.domain.Entidades;

namespace GerenciadorGeral.application.DTO
{
    public class CompraDTO : BaseDTO
    {
        public Guid IdFornecedor { get; set; }
        public decimal Desconto { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime Data { get; set; }
        public string? Observacao { get; set; }
        public ICollection<CompraItemDTO> ListaItens { get; set; }
        public FornecedorDTO Fornecedor { get; set; }
    }
}
