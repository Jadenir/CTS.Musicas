using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CTS.Musicas.Web.ViewModels.Musica
{
    public class MusicaViewModel
    {
        [Required(ErrorMessage = "O id é obrigatório")]
        public long Id { get; set; }

        [Required(ErrorMessage = "O nome da música é obrigatório")]
        [MaxLength(50, ErrorMessage = "O nome da música pode ter no máximo 50 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Seleciona uma album")]
        public int IdAlbum { get; set; }
    }
}