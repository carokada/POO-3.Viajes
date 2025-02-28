using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public interface ICotizacion
   {
      decimal PrecioPesos { get; }
      decimal PrecioDolar { get; }
   }
}
