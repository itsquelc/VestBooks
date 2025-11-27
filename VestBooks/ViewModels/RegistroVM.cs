using System.ComponentModel.DataAnnotations;

namespace VestBooks.ViewModels;
    public class RegistroVM
    {
       [Display(Name = "Nome Completo", Prompt = "Informe seu Nome Completo")]
       [Required(ErrorMessage = "Por favor, informe seu nome")]
       [StringLength(60, ErrorMessage = "O nome deve possuir no máximo 60 caracteres")]
       public string Nome { get; set; }      

       [Display(Name="E-mail", Prompt = "Informe seu E-mail")]
       [Required(ErrorMessage = "Por favor, informe seu Email")]
       [EmailAddress(ErrorMessage = "Por favor, informe um Email válido!")]
       [StringLength(100, ErrorMessage = "O Email deve possuir no máximo 100 caracteres")]
       public string Email { get; set; }

       [DataType(DataType.Password)]
       [Display(Name = "Senha de acesso", Prompt = "Informe sua Senha de Acesso")]
       [Required(ErrorMessage = "Por favor, informe uma senha")]
       [StringLength(20, MinimumLength = 6, ErrorMessage = "A senha de acesso deve possuir no mínimo 6 e no máximo 20 caracteres")]
       public string Senha { get; set; }

       [DataType(DataType.Password)]
       [Display(Name = "Confirmar a senha de acesso", Prompt = "Confirme sua senha de acesso")]
       [Compare("Senha", ErrorMessage = "As senhas não se conferem.")]
       public string ConfirmacaoSenha { get; set; }

       public IFormFile Foto { get; set; }
    }