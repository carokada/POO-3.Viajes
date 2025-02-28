using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public abstract class Entidad
   {
      private string nombre;
      private string domicilio;

      public Entidad(string nombre, string domicilio)
      {
         Nombre = nombre;
         Domicilio = domicilio;
      }

      public string Nombre
      {
         get => nombre;
         set => nombre = (value.Length > 0 && value.Length <= 30) ? value : throw new ArgumentException(" el nombre no cumple con los requerimientos del campo.");
      }

      public string Domicilio
      {
         get => domicilio;
         set => domicilio = (value.Length > 0 && value.Length <= 50) ? value : throw new ArgumentException(" el domicilio no cumple con los requerimientos del campo.");
      }

      public override string ToString()
      {
         return $"{Nombre}";
      }
   }
}
