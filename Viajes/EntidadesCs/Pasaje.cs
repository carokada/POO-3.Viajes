using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Pasaje : ICotizacion, IServicio
   {
      // ICotizacion
      public decimal PrecioPesos { get => PrecioDolar * Venta.CotizacionDolarPesos; }
      public decimal PrecioDolar { get => PrecioUnitario * Asientos; }

      // Iservicio
      public string Descripcion { get; set; }
      public DateTime FechaInicial { get; set; }

      public decimal PrecioUnitario { get; set; }
      public byte Asientos { get; set; }
      public Ciudad Origen { get; set; }
      public Ciudad Destino { get; set; }

      public Pasaje(string descripcion, DateTime fecha, decimal precioUnitario, byte asientos, Ciudad origen, Ciudad destino)
      {
         Descripcion = descripcion;
         FechaInicial = fecha;
         PrecioUnitario = precioUnitario;
         Asientos = asientos;
         Origen = origen;
         Destino = destino;
      }

      public override string ToString()
      {
         return $" pasaje: {Descripcion} desde {Origen} hasta {Destino} el dia {FechaInicial.ToString("dd/MM/yy")} \n\t cantidad: {Asientos} \t\t precio: {PrecioUnitario}";
      }
   }
}
