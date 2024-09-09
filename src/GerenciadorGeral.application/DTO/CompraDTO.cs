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
        //public virtual ICollection<CompraItem> ListaItens { get; set; }
        public FornecedorDTO Fornecedor { get; set; }
    }
}
