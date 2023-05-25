using System.ComponentModel.DataAnnotations;

namespace Barbearia.Models
{
    public class Agendamentos
    {
        public int Id { get; set; }
        [Display(Name = "Nome do cliente")]
        public string NomeCliente { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        [Display(Name = "Data de Agendamento")]
        public DateTime DataAgendamento { get; set; }
        public TipoProfissional Profissional { get; set; }
    }

    public enum TipoProfissional
    {
        Cabeleireiro = 1,
        Barbeiro =2
    }
}
