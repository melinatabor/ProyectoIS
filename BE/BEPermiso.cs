
using System.Collections.Generic;

namespace BE
{
    public class BEPermiso
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool EsPadre { get; set; }
        public List<BEPermiso> Hijos { get; set; }

        public BEPermiso()
        {
            Hijos = new List<BEPermiso>();
        }
    }
}
