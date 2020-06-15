using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CTS.Musicas.Web.ViewModels.Musica
{
    public class MusicaViewModel
    {
        [Display(Name = "Id")]
        [Required(ErrorMessage = "O id é obrigatório")]
        public long Id { get; set; }

        [Display(Name = "Nome da música")]
        [Required(ErrorMessage = "O nome da música é obrigatório")]
        [MaxLength(50, ErrorMessage = "O nome da música pode ter no máximo 50 caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Album")]
        [Required(ErrorMessage = "Selecione um album")]
        public int IdAlbum { get; set; }
    }
}