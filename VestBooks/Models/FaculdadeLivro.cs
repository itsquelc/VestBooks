using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VestBooks.Models;

[Table("faculdadeLivro")]
public class FaculdadeLivro
{
    [Key]
    public int FaculdadeLivroId { get; set; }

    [Required(ErrorMessage = "Por favor, informe a Faculdade")]
    public int FaculdadeId { get; set; }
    
    [ForeignKey(nameof(FaculdadeId))]
    public Faculdade Faculdade { get; set; }

    [Required(ErrorMessage = "Por favor, informe o Livro")]
    public int LivroId { get; set; }
    
    [ForeignKey(nameof(LivroId))]
    public Livro Livro { get; set; }
}