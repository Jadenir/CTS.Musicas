using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CTS.Musicas.Web.ViewModels.Album
{
    //Esse ViewModel será usado nas telas de Index, ou seja somente para listar os dados
    //Dispensando as DataAnottations de validação, usando somente anottations para nome
    public class AlbumExibicaoViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Nome do Album:")]
        public string Nome { get; set; }

        [Display(Name = "Ano do Album:")]
        public int Ano { get; set; }

        [Display(Name = "Observações do Album:")]
        public string Observacoes { get; set; }

        [Display(Name = "Email de contato:")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}