using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuanApp2.Areas.JuanApp2.DTOs
{
    public class fichaDeMovimientoDeCajaDTO
    {
        public int ID { get; set; }
        public DateTime Fecha { get; set; }
        public string Referencia { get; set; }
        public string Proveedor { get; set; }
        public string Descripcion { get; set; }
        public decimal Debe { get; set; }
        public decimal Haber { get; set; }
    }
}
