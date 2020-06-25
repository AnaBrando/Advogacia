using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advogacia.Models
{
    public class Artigo
    {
        public long Id { get; set; }

        public DateTime Data { get; set; }
        public byte[] PhotoFile { get; set; }
        public string ImageName { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
    }
}
