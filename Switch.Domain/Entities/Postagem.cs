using System;
using System.Collections.Generic;
using System.Text;

namespace Switch.Domain.Entities
{
    public class Postagem
    {
        public int Id { get; private set; }
        public DateTime DataPublicacao { get; private set; }
        public string Texto { get; private set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
