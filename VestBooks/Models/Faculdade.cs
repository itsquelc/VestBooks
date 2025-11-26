using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VestBooks.Models;

[Table("faculdade")]
public class Faculdade
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Por favor, informe o nome da faculdade")]
    [StringLength(100, ErrorMessage = "O nome da faculdade deve possuir no máximo 100 caracteres")]
    public string Nome { get; set; }

    [Display(Name = "Descrição", Prompt = "Descrição da faculdade")]
    [StringLength(3000, ErrorMessage = "A descrição deve possuir no máximo 3000 caracteres")]
    public string Descricao { get; set; }

    [StringLength(300)]
    public string Foto { get; set; }

    public virtual List<FaculdadeLivro> Livros { get; set; }

    public virtual List<Pergunta> Perguntas { get; set; }

}