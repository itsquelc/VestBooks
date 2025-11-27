using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VestBooks.Models;

[Table("pergunta")]
public class Pergunta
{
    [Key]
    public int PerguntaId { get; set; }

    [Required(ErrorMessage = "Por favor, informe o enunciado")]
    [StringLength(5000, ErrorMessage = "O nome da faculdade deve possuir no máximo 5000 caracteres")]
    public string Enunciado { get; set; }

    [Required(ErrorMessage = "Por favor, informe a Faculdade")]
    public int FaculdadeId { get; set; }
    [ForeignKey(nameof(FaculdadeId))]
    public Faculdade Faculdade { get; set; }

    public virtual List<PerguntaAlternativa> PerguntaAlternativas { get; set; }
}