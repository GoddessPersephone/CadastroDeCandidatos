using System.ComponentModel.DataAnnotations;

namespace CadastroDeCandidatos.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Digite seu Login")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite sua Senha")]
        public string Senha { get; set; }
    }
}
