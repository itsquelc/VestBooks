using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Org.BouncyCastle.Asn1;
using QuelloStore.Models;

namespace VestBooks.Models;

[Table("livro")]

 public class Livro
 {
    [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Por favor, informe o Autor")]
        public int AutorId { get; set; }
        [ForeignKey(nameof(AutorId))]

        public Autor Autor { get; set; }
       [Required(ErrorMessage = "Por favor, informe o Nome")]
       [StringLength(60, ErrorMessage = "o nome deve possuir no máximo 60 caracteres")] 

        public string Nome { get; set; }
        [Display(Name = "Descrição", Prompt = "Descrição")]
        [StringLength(1000,ErrorMessage = "A descrição deve possuir no máximo 1000 caracteres")]
        public string Descricao { get; set; }

        public bool Destaque { get; set;  }

        public List<LivroFoto> Fotos { get; set; }  
 }
