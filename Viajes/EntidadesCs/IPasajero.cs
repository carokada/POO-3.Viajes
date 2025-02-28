using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public interface IPasajero
   {
      uint Pasaporte { get; set; }
      uint Dni { get; set; }
      DateTime FechaNacimiento { get; set; }
   }
}
