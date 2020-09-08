using System;
using System.ComponentModel.DataAnnotations;
namespace blazorApp.Shared
{
    public class User
    {
        [Required (ErrorMessage = "Título Obrigatório")]
        public string titulo { get; set; }
        [Required (ErrorMessage = "Nome Obrigatório")]
        public string nome { get; set; }
        [Required (ErrorMessage = "Sobrenome Obrigatório")]
        public string sobrenome { get; set; }
        
        [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        public DateTime data_nasc { get; set; }
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage="Digite um e-mail válido")]
        public string email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(30,MinimumLength=6)]
        [Display(Name = "senha")]    
        public string senha { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(30,MinimumLength=6)]
        [Display(Name = "senha")]  
        public string confSenha { get; set; }
        [Required]
        public bool confirmacao { get; set; }
    }
}