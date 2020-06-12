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

        [Display(Name = "Nome:")]
        public string Nome { get; set; }

        [Display(Name = "Ano:")]
        public int Ano { get; set; }

        [Display(Name = "Observações:")]
        public string Observacoes { get; set; }

        [Display(Name = "E-mail de contato:")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}