using System.ComponentModel.DataAnnotations;

namespace CadastroDeCandidatos.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Digite seu Login")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite sua Senha")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Digite seu Email")]
        [EmailAddress(ErrorMessage = "Informe um email válido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Informe ao menos um Conhecimento para o Candidato")]
        public string Conhecimento { get; set; }
        public string Perfil { get; set; }
        [Required(ErrorMessage = "Digite o Nome do Candidato")]
        public string Nome { get; set; }
    }

}
