using BE;
using DAL;
using MPP.StoredProcedures;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP
{
    public class MPPTraduccion
    {
        public static bool Agregar(int idioma, int tag, string traduccion)
        {
            Hashtable parametros = new Hashtable
                {
                    { "@Idioma", idioma },
                    { "@Tag", tag },
                    { "@Traduccion", traduccion }
                };

            return Acceso.ExecuteNonQuery(IdiomaStoredProcedures.SP_AgregarTraduccion, parametros, true);
        }

        public static List<BETraduccion> Listar(int idIdioma)
        {
            try
            {
                Hashtable parametro = new Hashtable
                {
                    { "@IdIdioma", idIdioma }
                };

                List<BETraduccion> traducciones = new List<BETraduccion>();

                DataTable table = Acceso.ExecuteDataTable(IdiomaStoredProcedures.SP_ListarTraducciones, parametro, true);

                if (table.Rows.Count > 0)
                {
                    foreach (DataRow fila in table.Rows)
                    {
                        BETraduccion traduccion = new BETraduccion()
                        {
                            Id = Convert.ToInt32(fila["Id"].ToString()),
                            Tag = fila["Tag"].ToString(),
                            Neutro = fila["Neutro"].ToString(),
                            Traduccion = fila["Traduccion"].ToString()
                        };
                        traducciones.Add(traduccion);
                    }
                }

                return traducciones;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool Modificar(int idioma, int tag, string traduccion)
        {
            Hashtable parametros = new Hashtable
                {
                    { "@Idioma", idioma },
                    { "@Tag", tag },
                    { "@NuevaTraduccion", traduccion }
                };

            return Acceso.ExecuteNonQuery(IdiomaStoredProcedures.SP_ModificarTraduccion, parametros, true);
        }
    }
}
