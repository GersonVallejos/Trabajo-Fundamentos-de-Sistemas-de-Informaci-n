using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aptitus
{
    public class CAnuncio
    {
        public string tipo_anun { get; set; }
        public string tipo_puest { get; set; }
        public string nombre_puest { get; set; }
        public string nivel_puest { get; set; }
        public string area { get; set; }
        public string funcion { get; set; }
        public int salario { get; set; }
        public string metodo_pago { get; set; }
            
        public List<CPostulante> postulantes { get; set; }
        public CAnuncio()
        {
            postulantes = new List<CPostulante>();
        }
    }
}
