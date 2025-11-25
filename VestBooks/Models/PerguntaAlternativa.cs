using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VestBooks.Models;

[Table("perguntaAlternativa")]
public class PerguntaAlternativa
{
    [Key]
    public int PerguntaAlternativaId { get; set; }

    [Required(ErrorMessage = "Por favor, informe a Descricao")]
    [StringLength(5000, ErrorMessage = "A Descricao deve possuir no máximo 5000 caracteres")]
    public string Descricao { get; set; }

    [Required(ErrorMessage = "Por favor, informe a pergunta")]
    public int PerguntaId { get; set; }
    [ForeignKey(nameof(PerguntaId))]
    public Pergunta Pergunta { get; set; }

    public bool Correta { get; set; }
}