using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public interface IServicio
   {
      string Descripcion { get; set; }
      DateTime FechaInicial { get; set; }
   }
}
