using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuelloStore.Models;

[Table("LivroFoto")]
    public class LivroFoto
    {
        [Key]
        public int Id { get; set; }
        [Display (Name = "Livro")]
        [Required(ErrorMessage = "Por favor, informe o livro")]
        public int ProdutoId { get; set; }
        [ForeignKey("LivroId")]
        
        public Livro Livro { get; set; }

        [StringLength(200)]
        [Display(Name = "Foto")]
        [Required(ErrorMessage = "Por favor, selecione a Foto")]
        public string ArquivoFoto { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
    } 