using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VestBooks.Models;
[Table("autor")]

public class Autor
{
    [Key]
    public int AutorId { get; set; }
    [Required(ErrorMessage = "Por favor, informe o nome do Autor")]
    [StringLength(60, ErrorMessage = "O Nome deve possuir no máximo 60 caracteres")]
    public string Nome { get; set; }

    [StringLength(300)]
    public string Foto { get; set; }

    [StringLength(5000)]
    public string Biografia { get; set; }
}