using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VestBooks.Models;

[Table("Favoritos")]
public class Favorito
{
    [Key, Column(Order = 1)]
    public string UsuarioId { get; set; }
    [ForeignKey(nameof(UsuarioId))]
    public Usuario Usuario { get; set; }

    [Key, Column(Order = 2)]
    public int LivroId { get; set; }
    [ForeignKey(nameof(LivroId))]
    public Livro Livro { get; set; }

    public DateTime DataFavoritado { get; set; } = DateTime.Now;

}
