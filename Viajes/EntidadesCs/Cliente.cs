using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Cliente : Entidad
   {
      private string cuitCuil;

      private List<Venta> ventas; // asoc bidireccional venta (1 cliente muchas ventas)

      public Cliente(string cuitCuil, string nombre, string domicilio) : base(nombre, domicilio)
      {
         ventas = new List<Venta>();

         CuitCuil = cuitCuil;
      }

      public string CuitCuil
      {
         get => cuitCuil;
         set => cuitCuil = (value.Length > 0 || value.Length <= 13) ? value : throw new ArgumentException(" el cuit/cuil no cumple con los requerimientos del campo.");
      }

      internal void AddVenta(Venta venta)
      {
         if (venta == null)
            throw new ArgumentException(" la venta no puede ser nula.");
         if (ventas.Contains(venta))
            throw new ArgumentException($" la venta {venta} ya se encuentra en la lista ");
         ventas.Add(venta);
      }

      public List<Venta> GetAllVentas()
      {
         return ventas;
      }

      public override string ToString()
      {
         return $" cliente: {Nombre} ({CuitCuil})";
      }
   }
}
