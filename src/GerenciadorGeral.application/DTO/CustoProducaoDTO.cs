namespace GerenciadorGeral.application.DTO
{
  public class CustoProducaoDTO : BaseDTO
  {
    
    public Guid IdSKU { get; set; }
    public DateTime DataCalculo { get; set; }
    public Guid IdUsuario { get; set; }
    public string Observacao { get; set; }
    public UsuarioDTO Usuario { get; set; }
    public SKUDTO SKU { get; set; }
    public ICollection<CustoProducaoDetalheDTO> ListaProducaoDetalhe { get; set; }
  }
}
