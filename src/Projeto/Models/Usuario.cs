using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome de usuário")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite um e-mail válido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Digite uma senha válida")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Digite um telefone para contato")]
        public int Telefone { get; set; }

        public Perfil Perfil { get; set; }
    }
    public enum Perfil
    {
        Admin,
        Funcionario,
        Cliente
    }
}
