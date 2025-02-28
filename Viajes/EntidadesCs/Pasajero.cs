using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Pasajero : Entidad, IPasajero
   {
      // IPasajero
      public uint Pasaporte { get; set; }
      public uint Dni { get; set; }
      public DateTime FechaNacimiento { get; set; }

      private Pasajero tutor = null;

      public Pasajero(uint dni, string nombre, string domicilio, DateTime fechaNacimiento) : base(nombre, domicilio)
      {
         Dni = dni;
         FechaNacimiento = fechaNacimiento;
         //Tutor = null; // el tutor null en constructor llama al procedimiento y tira error. bien implementado como default ??
      }

      public Pasajero(uint dni, string nombre, string domicilio, DateTime fechaNacimiento, uint pasaporte) : this(dni, nombre, domicilio, fechaNacimiento)
      {
         Pasaporte = pasaporte;
      }


      public Pasajero Tutor
      {
         get => tutor;
         set
         {
            if (IsMayorEdad())
               throw new ArgumentException(" no se puede asignar un tutor a un pasajero mayor de edad.");
            tutor = value;
         }
      }

      public bool IsMayorEdad()
      {
         int edad = DateTime.Now.Year - FechaNacimiento.Year;
         if (DateTime.Now.Month < FechaNacimiento.Month || 
            (DateTime.Now.Month == FechaNacimiento.Month && DateTime.Now.Day < FechaNacimiento.Day))
            edad--;
         return edad >= 18;
      }

      public override string ToString()
      {
         return $" pasajero: ({Dni}) {Nombre}";
      }
   }
}
