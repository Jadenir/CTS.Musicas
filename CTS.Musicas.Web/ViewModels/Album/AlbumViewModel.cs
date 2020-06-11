using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CTS.Musicas.Web.ViewModels.Album
{
    //Esse ViewModel será usado nas telas de Gravação, Edição e Exclusão
    //Necessitando das DataAnottations de validação
    public class AlbumViewModel
    {
        [Required(ErrorMessage = "O ID do album é obraigatório")]
        public int Id { get; set; }

        [Display(Name = "Nome do lbum:")]
        [Required(ErrorMessage = "O nome é obrigatório")]
        [MaxLength(100, ErrorMessage = "O nome do album poderá ter no máximo 100 caracteres")]
        public string Nome { get; set; }
                
        [Display(Name = "Ano do album:")]
        [Required(ErrorMessage = "O ano é obrigatório")]
        public int Ano { get; set; }

                [Display(Name = "Observações do album:")]
        [MaxLength(1000, ErrorMessage = "Quantidade de caracteres excedida. Limte de 1000 caracteres")]
        public string Observacoes { get; set; }

        [Display(Name = "E-mail de contato:")]
        [DataType(DataType.EmailAddress, ErrorMessageResourceName ="Informe um e-mail válido")]
        [Required(ErrorMessage = "O e-mail é obrigatório")]
        [MaxLength(50, ErrorMessage = "Quantidade de caracteres excedida. Limte de 50 caracteres")]
        public string Email { get; set; }
    }
}