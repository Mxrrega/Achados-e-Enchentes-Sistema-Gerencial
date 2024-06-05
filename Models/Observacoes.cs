using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_MVC_Achados_e_Enchentes.Models
{
    [Table("Observacoes")]
    public class Observacoes
    {
        [Column("ObservacaoId")]
        [Display(Name = "Id da Observacao")]
        public int Id { get; set; }

        [Column("ObservacaoDescricao")]
        [Display(Name = "Descricao da Observacao")]
        public string ObservacaoDescricao { get; set; } = string.Empty;

        [Column("ObservacaoLocal")]
        [Display(Name = "Local da Observacao")]
        public string ObservacaoLocal { get; set; } = string.Empty;

        [Column("ObservacaoData")]
        [Display(Name = "Data da Observacao")]
        public DateTime ObservacaoData { get; set; }

        [ForeignKey("PessoaId")]
        [Display(Name = "Id Pessoa")]
        public int PessoaId { get; set; }
        public Pessoa? Pessoa { get; set; }

        [ForeignKey("UsuarioId")]
        [Display(Name = "Id Usuario")]
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
    }
}