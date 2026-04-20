using System.ComponentModel.DataAnnotations;

namespace Inscricoes.Data.Models
{
    /*public class MyUser
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Requer inserir o nome de utilizador.")]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required]
        [StringLength(17)]
        public string CellPhone { get; set; } = string.Empty;

        [StringLength(50)]
        public string? UserID { get; set; }
    }*/

    /// <summary>
    /// Classe para representar os utilizadores da aplicação,
    /// ou seja, os dados que identificam cada utilizador.
    /// </summary>
    public class MyUser
    {

        [Key] // PK
        public int Id { get; set; }

        /// <summary>
        /// Nome do utilizador
        /// </summary>
        [StringLength(50)]
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório.")]
        [Display(Name = "Nome Completo")]
        public string Name { get; set; } = "";

        /// <summary>
        /// Data de nascimento
        /// </summary>
        [Display(Name = "Data Nascimento")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateOnly BirthDate { get; set; }

        /// <summary>
        /// Telemóvel do utilizador, 
        /// </summary>
        [Display(Name = "Telemóvel")]
        [StringLength(19)]
        public string? CellPhone { get; set; }

        /// <summary>
        /// atributo para funcionar como FK entre a tabela dos MyUser
        /// e a tabela da Autenticação
        /// </summary>
        //        public string UserID { get; set; } = null!;

    }
}
