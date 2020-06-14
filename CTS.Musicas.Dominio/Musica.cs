using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS.Musicas.Dominio
{
    public class Musica
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public Album Album { get; set; }
        public virtual int IdAlbum { get; set; }
    }
}
