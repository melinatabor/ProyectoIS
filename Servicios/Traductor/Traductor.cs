using Abstraccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Traductor
{
    public class Traductor
    {
        public int Idioma { get; set; }
        private List<ISubscriptor> Subscriptores { get; set; }

        public Traductor() { }

        public void AgregarSuscriptor(ISubscriptor sub)
        {
            Subscriptores.Add(sub);
        }

        private void Notificar()
        {
            foreach (ISubscriptor sub in Subscriptores)
                sub.Actualizar();
        }
    }
}
