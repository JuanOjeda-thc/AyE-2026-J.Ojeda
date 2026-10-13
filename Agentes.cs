using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacion_base_de_datos
{
    internal class Agentes
    {
        public class Agente
        {
            public int id { get; set; }
            public string nombre_agente { get; set; }
            public string tipo_agente { get; set; }
            public string nacionalidad { get; set; }
            public string fecha_lanzamiento { get; set; }
        }

    }
}
