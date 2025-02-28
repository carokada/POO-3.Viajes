using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Paquete
   {
      private List<IServicio> servicios; // asoc multiple IServicios

      // ICotizacion
      public decimal PrecioPesos { get => PrecioDolar * Venta.CotizacionDolarPesos; }
      public decimal PrecioDolar { get => SumatoriaPreciosServicios(); }

      // Iservicio
      public string Descripcion { get; set; }
      public DateTime FechaInicial { get; set; }

      public DateTime FechaFinal { get; set; }
      public ushort NumeroDias { get => CalcularDias(); } // calcular dias con fecha final ??
      public ushort NumeroPasajeros { get; } // sale de asientos de pasaje ?? si no tiene pasaje ??

      public Paquete(string descripcion, DateTime fechaInicial, DateTime fechaFinal)
      {
         servicios = new List<IServicio>();

         Descripcion = descripcion;
         FechaInicial = fechaInicial;
         FechaFinal = fechaFinal;
      }

      public ushort CalcularDias()
      {
         TimeSpan diasPaquete = FechaFinal.Date - FechaInicial.Date;
         return (ushort)diasPaquete.Days;
      }

      // public ushort CalcularPasajeros ?? 

      public void AddServicio(IServicio servicio)
      {
         if (servicios.Contains(servicio))
            throw new ArgumentException(" el servicio ya se encuentra en la lista de servicios.");
         servicios.Add(servicio);
      }

      public List<IServicio> GetAllServicios()
      {
         return servicios;
      }

      public void RemoveServicio(IServicio servicio)
      {
         if (!servicios.Contains(servicio))
            throw new ArgumentException(" el servicio no se encuentra en la lista de servicios.");
         servicios.Remove(servicio);
      }

      public decimal SumatoriaPreciosServicios()
      {
         decimal total = 0;
         foreach (ICotizacion cotizacion in servicios)
         {
            total += cotizacion.PrecioDolar;  // casting a icotizacion aca para acceder a los precios
         }
         return total;
      }

      public override string ToString()
      {
         return $" paquete: {Descripcion} \n desde: {FechaInicial} \t\t hasta: {FechaFinal} \n dias: {NumeroDias} \t\t pasajeros: {NumeroPasajeros}";
      }
   }
}
