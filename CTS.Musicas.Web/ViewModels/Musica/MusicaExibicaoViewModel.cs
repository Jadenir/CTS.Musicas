using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CTS.Musicas.Web.ViewModels.Musica
{
    public class MusicaExibicaoViewModel
    {
        [Display(Name = "Id")]
        public long Id { get; set; }

        [Display(Name = "Nome da música")]
        public string Nome { get; set; }

        [Display(Name = "Album")]
        public string NomeAlbum { get; set; }
    }
}