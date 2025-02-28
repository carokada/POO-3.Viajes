using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Hotel : ICotizacion, IServicio
   {
      // ICotizacion
      public decimal PrecioPesos { get => PrecioDolar * Venta.CotizacionDolarPesos; }
      public decimal PrecioDolar { get => PrecioDiaria * Noches * Habitaciones; }

      // Iservicio
      public string Descripcion { get; set; }
      public DateTime FechaInicial { get; set; }

      public byte Habitaciones { get; set; }
      public byte Noches { get; set; }
      public decimal PrecioDiaria { get; set; }
      public Ciudad Ciudad { get; set; }

      public Hotel(string descripcion, DateTime fecha, Ciudad ciudad, byte noches, decimal precioDiaria)
      {
         Descripcion = descripcion;
         FechaInicial = fecha;
         Ciudad = ciudad;
         Noches = noches;
         PrecioDiaria = precioDiaria;
      }

      public override string ToString()
      {
         return $" hotel: {Descripcion} en {Ciudad} ({FechaInicial.ToString("dd/MM/yy")}) \n\t precio por noche: {PrecioDiaria} \t\t habitaciones: {Habitaciones}";
      }
   }
}
