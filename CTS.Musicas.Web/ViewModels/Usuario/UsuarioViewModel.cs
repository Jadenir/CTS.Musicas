using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CTS.Musicas.Web.ViewModels.Usuario
{
    public class UsuarioViewModel
    {
        [Required(ErrorMessage ="O e-mail é obrigatório")]
        [MaxLength(50,ErrorMessage ="O e-mail não pode ter mas que 30 caracteres")]
        public string Email { get; set; }

        [Required(ErrorMessage ="A senha é obrigratória")]
        [MaxLength(20, ErrorMessage = "A senha não pode ter mas que 20 caracteres")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}