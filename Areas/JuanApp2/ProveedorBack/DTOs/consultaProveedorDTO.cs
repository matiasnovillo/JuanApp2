using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuanApp2.Areas.JuanApp2.ProveedorBack.DTOs
{
    public class consultaProveedorDTO
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int ProveedorId { get; set; }
        public string Referencia { get; set; }
        public string Descripcion { get; set; }
        public decimal Kilogramo { get; set; }
        public decimal Precio { get; set; }
        public decimal Debe { get; set; }
        public decimal Haber { get; set; }
        public decimal Saldo { get; set; }
        public DateTime Vencimiento { get; set; }

    }
}
