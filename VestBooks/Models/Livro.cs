using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VestBooks.Models;

[Table("livro")]
public class Livro
{
  [Key]
  public int LivroId { get; set; }

  //autor 
  [Required(ErrorMessage = "Por favor, informe o Autor")]
  public int AutorId { get; set; }
  [ForeignKey(nameof(AutorId))]
  public virtual Autor Autor { get; set; }

  // nome do livro
  [Required(ErrorMessage = "Por favor, informe o Nome ")]
  [StringLength(60, ErrorMessage = "O Nome deve possuir no máximo 60 caracteres")]
  public string Nome { get; set; }

  //descrição
  [Display(Name = "Descrição", Prompt = "Descrição")]
  [StringLength(5000, ErrorMessage = "A Descrição deve possuir no máximo 5000 caracteres")]
  public string Descricao { get; set; }

  //publicação
  [Display(Name = "Publicação", Prompt = "Publicação")]
  [StringLength(4, ErrorMessage = "A data da publicação deve possuir no máximo 4 caracteres")]
  public string Publicacao { get; set; }

  //Avaliação
  [Display(Name = "Avaliação", Prompt = "Avaliação")]
  [StringLength(3, ErrorMessage = "A nota da Avaliação deve possuir no máximo 3 caracteres")]
  public string Avaliacao { get; set; }

 //Número de páginas
  [Display(Name = "Número de Páginas", Prompt = "Número de Páginas")]
  public int NumeroPaginas { get; set; }

  //resumo
  [Display(Name = "Resumo", Prompt = "Resumo")]
  [DataType(DataType.MultilineText)]
  [StringLength(50000, ErrorMessage = "O Resumo deve possuir no máximo 50000 caracteres")]
  public string Resumo { get; set; }

  public bool Destaque { get; set; }

  [StringLength(300)]
  public string Foto { get; set; }

  [StringLength(300)]
  [Display(Name = "Vídeo")]
  public string Video { get; set; }

  [StringLength(300)]
  public string Pdf { get; set; }

  public virtual List<FaculdadeLivro> Faculdades { get; set; }
}