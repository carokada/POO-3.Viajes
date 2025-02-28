using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class ClientePasajero : Cliente, IPasajero
   {
      // IPasajero
      public uint Pasaporte { get; set; }
      public uint Dni { get; set; }
      public DateTime FechaNacimiento { get; set; }

      public ClientePasajero(string cuitCuil, uint dni, string nombre, string domicilio, DateTime fechaNacimiento) : base(cuitCuil, nombre, domicilio)
      {
         Dni = dni;
         FechaNacimiento = fechaNacimiento;
      }

      public ClientePasajero(string cuitCuil, uint dni, string nombre, string domicilio, DateTime fechaNacimiento, uint pasaporte) : this(cuitCuil, dni, nombre, domicilio, fechaNacimiento)
      {
         Pasaporte = pasaporte;
      }

      public override string ToString()
      {
         return $" cliente pasajero: {Nombre} ({FechaNacimiento.ToString("dd/MM/yy")}) \n\t\t dni: {Dni} \t\t cuit/cuil: {CuitCuil}";
      }
   }
}
