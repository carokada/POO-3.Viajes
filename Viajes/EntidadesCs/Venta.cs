using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Venta : ICotizacion
   {
      // ICotizacion
      public decimal PrecioPesos { get => PrecioDolar * CotizacionDolarPesos; }
      public decimal PrecioDolar { get => PrecioTotal(); }

      private Cliente cliente; // asoc bidireccional cliente (1 venta 1 cliente)

      private List<IServicio> servicios; // asoc multiple servicios (1 venta muchos servicios)
      private List<Pasajero> pasajeros; // asoc multiple a pasajero o a IPasajero ?? 

      public static decimal CotizacionDolarPesos { get; set; }
      public DateTime Fecha { get; set; }

      public Venta (DateTime fecha, Cliente cliente)
      {
         servicios = new List<IServicio>();

         Fecha = fecha;
         Cliente = cliente;

         Agencia.AddVenta(this);
      }

      public Cliente Cliente
      {
         get => cliente;
         set
         {
            cliente = value ?? throw new ArgumentException(" el cliente no puede estar vacio.");
            cliente.AddVenta(this); // agrega venta a lista ventas cliente (internal)
         } 
      }

      public void AddServicio(IServicio servicio)
      {
         if (servicio == null)
            throw new ArgumentException(" el pasajero no puede ser nulo.");
         if (servicios.Contains(servicio))
            throw new ArgumentException($" el pasajero {servicio} ya se encuentra en la lista ");
         servicios.Add(servicio);
      }

      public List<IServicio> GetAllServicios()
      {
         return servicios;
      }

      private decimal PrecioTotal()
      {
         decimal totalVenta = 0;
         foreach (ICotizacion servicio in servicios)
            totalVenta += servicio.PrecioDolar;
         return totalVenta;
      }

      public void AddPasajero(Pasajero pasajero)
      {
         if (pasajero == null)
            throw new ArgumentException(" el pasajero no puede ser nulo.");
         if (pasajeros.Contains(pasajero))
            throw new ArgumentException($" el pasajero {pasajero} ya se encuentra en la lista ");
         pasajeros.Add(pasajero);
      }

      public void RemovePasajero(Pasajero pasajero)
      {
         if (pasajero == null)
            throw new ArgumentException(" el pasajero no puede ser nulo.");
         if (!pasajeros.Contains(pasajero))
            throw new ArgumentException($" el pasajero {pasajero} no se encuentra en la lista ");
         pasajeros.Remove(pasajero);
      }

      public List<Pasajero> GetAllPasajeros()
      {
         return pasajeros;
      }

      public override string ToString()
      {
         return $" venta: cliente: {cliente.Nombre} \n\t fecha: {Fecha.ToString("dd/MM/yy")} \n\t precio total: ${PrecioDolar} ";
      }
   }
}
