using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aptitus
{
    public class CProceso
    {
        public static List<CEmpresa> lempresas { get; set; }
        public static List<CAnuncio> lanuncios { get; set; }
        public static List<CPostulante> lpostulantes { get; set; }

        public CProceso()
        {
            if (lempresas == null) 
            {
                lempresas = new List<CEmpresa>();
            }
            if (lanuncios == null)
            {
                lanuncios = new List<CAnuncio>();
            }
        }
        public bool existeDNI(int DNI)
        {
            return lpostulantes.Exists(delegate (CPostulante value)
            {
                return value.dni == DNI;
            });
        }
        public bool existeRUC(int ruc)
        {
            return lempresas.Exists(delegate (CEmpresa value)
            {
                return value.ruc == ruc;
            });
        }
    }
}
