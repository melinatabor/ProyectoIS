using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEPermiso
    {
        public int Id { get; set; }
        public string Permiso { get; set; }
        public List<BEPermiso> Permisos { get; set; }
    }
}
