using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebPic.Models
{
    public class Usuario
    {
        [Key]
        public int IDUsuario { get; set; }
        [StringLength(50, ErrorMessage = "Somente 50 caracteres")]
        [Required]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [StringLength(50, ErrorMessage = "Somente 50 caracteres")]
        [Required]
        [Display(Name = "Sobrenome")]
        public string Sobrenome { get; set; }
        [StringLength(12, ErrorMessage = "Somente 12 caracteres")]
        [Required]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }
        [StringLength(50, ErrorMessage = "Somente 50 caracteres")]
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}