using System.ComponentModel.DataAnnotations;

namespace VestBooks.Models;

public class Faculdade
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Por favor, informe o nome da faculdade")]
    [StringLength(100, ErrorMessage = "O nome da faculdade deve possuir no máximo 100 caracteres")]
    public string Nome { get; set; }

    [Display(Name = "Descrição", Prompt = "Descrição da faculdade")]
    [StringLength(1000, ErrorMessage = "A descrição deve possuir no máximo 1000 caracteres")]
    public string Descricao { get; set; }

}