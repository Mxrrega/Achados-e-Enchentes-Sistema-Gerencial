using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_MVC_Achados_e_Enchentes.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Column("UsuarioId")]
        [Display(Name = "Id do Usuário")]
        public int Id { get; set; }

        [Column("UsuarioNome")]
        [Display(Name = "Nome do Usuário")]
        public string UsuarioNome { get; set; } = string.Empty;

        [Column("UsuarioTelefone")]
        [Display(Name = "Telefone do Usuário")]
        public string UsuarioTelefone { get; set; } = string.Empty;

        [Column("UsuarioEmail")]
        [Display(Name = "Email do Usuário")]
        public string UsuarioEmail { get; set; } = string.Empty;

        [Column("UsuarioSenha")]
        [Display(Name = "Senha do Usuário")]
        public string UsuarioSenha { get; set; } = string.Empty;
    }
}
