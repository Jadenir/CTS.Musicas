using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS.Musicas.Dominio
{
    //Classe POCO
    public class Album
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Ano { get; set; }
        public string Observacoes { get; set; }
        public string Email { get; set; }
        public virtual List<Musica> Musicas { get; set; }
    }
}
