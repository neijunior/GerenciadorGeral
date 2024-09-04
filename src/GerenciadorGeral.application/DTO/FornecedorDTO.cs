using System.ComponentModel.DataAnnotations;

namespace GerenciadorGeral.application.DTO
{
    public class FornecedorDTO : BaseDTO
    {
        [Required(ErrorMessage = "O CpfCnpj é obrigatório")]        
        public string CpfCnpj { get; set; }
        [Required(ErrorMessage = "O RazaoSocial é obrigatório")]
        public string RazaoSocial { get; set; }
    }
}
