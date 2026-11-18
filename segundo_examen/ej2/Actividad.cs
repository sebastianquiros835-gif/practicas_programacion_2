using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace segundo_examen.ej2
{
    public class Actividad
    {
        public string Descripcion { get; set; }
        public string Responsable { get; set; }
        public DateTime Fecha { get; set; }

        public string Informacion
        {
            get
            {
                return Descripcion + " - " + Responsable + " - " + Fecha.ToString("dd/MM/yyyy");
            }
        }
    }
}
