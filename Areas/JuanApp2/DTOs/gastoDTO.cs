using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuanApp2.Areas.JuanApp2.DTOs
{
    public class gastoDTO
    {
        public int ID { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public decimal Importe { get; set; }
        public string Referencia { get; set; }
    }
}