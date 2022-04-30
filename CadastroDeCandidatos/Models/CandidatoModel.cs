using System.ComponentModel.DataAnnotations;

namespace CadastroDeCandidatos.Models
{
    public class CandidatoModel
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Digite o Nome do Candidato")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o nº Celular do Candidato")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "Digite um Email para o Candidato")]
        [EmailAddress(ErrorMessage = "Informe um email válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe ao menos um Conhecimento para o Candidato")]
        public string Conhecimento { get; set; }

        [Required(ErrorMessage = "Digite uma Senha para o Cadastro")]
        public string Senha { get; set; }
        
        
    }
}
