using BE;
using MPP;
using Servicios.Encriptador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLPermiso
    {
        public static bool AgregarFamilia(BEPermiso permiso)
        {
            try
            {
                permiso.EsPadre = true;
                return MPPPermiso.AgregarPermiso(permiso);
            }
            catch (Exception ex) { throw ex; }
        }

        public static bool AgregarPermisoSimple(BEPermiso permiso)
        {
            try
            {
                permiso.EsPadre = false;
                return MPPPermiso.AgregarPermiso(permiso);
            }
            catch (Exception ex) { throw ex; }
        }

        public static object ListarPermisos()
        {
            try
            {
                return MPPPermiso.ListarPermisos();
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
