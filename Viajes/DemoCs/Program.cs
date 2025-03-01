using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCs;

namespace DemoCs
{
   class Program
   {
      static void Main(string[] args)
      {
         string divisor = "----------------------------------------------------------";

         Console.WriteLine(divisor);
         Console.WriteLine(" estableciendo cotizacion dolar...");
         Venta.CotizacionDolarPesos = 1200;
         Console.WriteLine($" cotizacion dolar: AR${Venta.CotizacionDolarPesos}.~ \n");

         Console.WriteLine(divisor);
         Console.WriteLine(" creando ciudades...");
         Ciudad ciudad1 = new Ciudad("Buenos Aires");
         Ciudad ciudad2 = new Ciudad("Posadas");
         Ciudad ciudad3 = new Ciudad("Cordoba");
         Ciudad ciudad4 = new Ciudad("Bariloche");
         try
         {
            Ciudad ciudad5 = new Ciudad("");
         }
         catch (Exception e)
         {
            Console.WriteLine($" !! error: {e.Message}");
         }
         Console.WriteLine("\n ciudades cargadas:");
         Console.WriteLine(ciudad1);
         Console.WriteLine(ciudad2);
         Console.WriteLine(ciudad3);
         Console.WriteLine(ciudad4);

         Console.WriteLine("\n" + divisor);
         Console.WriteLine(" creando hoteles...");
         Hotel hotel1 = new Hotel("Hotel Sheraton", new DateTime(2025, 3, 15), ciudad1, 3, 300);
         Hotel hotel2 = new Hotel("Hotel Splendor", new DateTime(2025, 3, 15), ciudad2, 1, 180);
         Hotel hotel3 = new Hotel("Hotel Veracruz", new DateTime(2025, 3, 15), ciudad3, 2, 250);
         Hotel hotel4 = new Hotel("Hotel San Martin", new DateTime(2025, 3, 15), ciudad4, 4, 500);
         hotel1.Habitaciones = 2;
         hotel2.Habitaciones = 1;
         hotel3.Habitaciones = 2;
         hotel4.Habitaciones = 3;
         Console.WriteLine("\n hoteles cargados:");
         Console.WriteLine(hotel1 + $"\n\t precio final: US$D {hotel1.PrecioDolar}.~ (AR$ {hotel1.PrecioPesos}) \n");
         Console.WriteLine(hotel2 + $"\n\t precio final: US$D {hotel2.PrecioDolar}.~ (AR$ {hotel2.PrecioPesos}) \n");
         Console.WriteLine(hotel3 + $"\n\t precio final: US$D {hotel3.PrecioDolar}.~ (AR$ {hotel3.PrecioPesos}) \n");
         Console.WriteLine(hotel4 + $"\n\t precio final: US$D {hotel4.PrecioDolar}.~ (AR$ {hotel4.PrecioPesos}) \n");

         Console.WriteLine(divisor);
         Console.WriteLine(" creando pasajes...");
         Pasaje pasaje1 = new Pasaje("Via Bariloche", new DateTime(2025, 3, 14), 150, 4, ciudad2, ciudad1);
         Pasaje pasaje2 = new Pasaje("Rio Uruguay", new DateTime(2025, 3, 14), 180, 1, ciudad1, ciudad2);
         Pasaje pasaje3 = new Pasaje("Expreso Singer", new DateTime(2025, 3, 14), 200, 4, ciudad2, ciudad3);
         Pasaje pasaje4 = new Pasaje("Aerolineas Argentinas", new DateTime(2025, 3, 14), 350, 4, ciudad1, ciudad4);
         Console.WriteLine(" \n pasajes cargados:");
         Console.WriteLine(pasaje1 + $"\n\t precio final: US$D {pasaje1.PrecioDolar}.~ (AR$ {pasaje1.PrecioPesos}) \n");
         Console.WriteLine(pasaje2 + $"\n\t precio final: US$D {pasaje2.PrecioDolar}.~ (AR$ {pasaje2.PrecioPesos}) \n");
         Console.WriteLine(pasaje3 + $"\n\t precio final: US$D {pasaje3.PrecioDolar}.~ (AR$ {pasaje3.PrecioPesos}) \n");
         Console.WriteLine(pasaje4 + $"\n\t precio final: US$D {pasaje4.PrecioDolar}.~ (AR$ {pasaje4.PrecioPesos}) \n");

         Console.WriteLine(divisor);
         Console.WriteLine(" creando paquetes...");
         Paquete paquete1 = new Paquete("BsAs 5 noches", new DateTime(2025, 3, 14), new DateTime(2025, 3, 19));
         Paquete paquete2 = new Paquete("Pdas 3 noches", new DateTime(2025, 3, 14), new DateTime(2025, 3, 17));
         Paquete paquete3 = new Paquete("Cba 4 noches", new DateTime(2025, 3, 14), new DateTime(2025, 3, 18));
         Paquete paquete4 = new Paquete("Bariloche 6 noches", new DateTime(2025, 3, 14), new DateTime(2025, 3, 20));
         Console.WriteLine(" cargando servicios en paquetes...");
         paquete1.AddServicio(pasaje1);
         paquete1.AddServicio(hotel1);
         paquete2.AddServicio(pasaje2);
         paquete2.AddServicio(hotel2);
         paquete3.AddServicio(pasaje3);
         paquete3.AddServicio(hotel3);
         paquete4.AddServicio(pasaje4);
         paquete4.AddServicio(hotel4);
         Console.WriteLine("\n paquetes cargados:");
         MostrarPaquete(paquete1);
         MostrarPaquete(paquete2);
         MostrarPaquete(paquete3);
         MostrarPaquete(paquete4);

         Console.WriteLine(divisor);
         Console.WriteLine(" creando cliente/pasajero...");
         Cliente clientePasajero1 = new ClientePasajero("12345678912", 25169962, "Daniel Gomez", "Sta Fe 256", new DateTime(1995, 6, 19));
         Cliente clientePasajero2 = new ClientePasajero("12345678913", 29345187, "Raquel Portillo", "Cordoba 1224", new DateTime(1993, 10, 20));
         Cliente clientePasajero3 = new ClientePasajero("12345678914", 34169823, "Martin Machado", "Salta 994", new DateTime(1989, 12, 6), 34169823);
         Cliente clientePasajero4 = new ClientePasajero("12345678915", 38166622, "Fernanda Juarez", "La Rioja 111", new DateTime(1992, 4, 18), 38166622);
         Console.WriteLine("\n cliente/pasajeros cargados: ");
         Console.WriteLine(clientePasajero1);
         Console.WriteLine(clientePasajero2);
         Console.WriteLine(clientePasajero3);
         Console.WriteLine(clientePasajero4);

         Console.WriteLine("\n" + divisor);
         Console.WriteLine(" creando clientes...");
         Cliente cliente1 = new Cliente("12345678916", "Vera Fernandez", "Lavalle 2257");
         Cliente cliente2 = new Cliente("12345678917", "Hugo Dias", "Sta Catalina 996");
         Cliente cliente3 = new Cliente("12345678918", "Cintia Perez", "Urquiza 1684");
         Cliente cliente4 = new Cliente("12345678919", "Aimara Rodriguez", "Buenos Aires 8823");
         Console.WriteLine("\n clientes cargados: ");
         Console.WriteLine(cliente1);
         Console.WriteLine(cliente2);
         Console.WriteLine(cliente3);
         Console.WriteLine(cliente4);

         Console.WriteLine("\n" + divisor);
         Console.WriteLine(" creando pasajeros...");
         Pasajero pasajero1 = new Pasajero(25161454, "Gerardo Sofovich", "Rivadavia 884", new DateTime(1985, 10, 10));
         Pasajero pasajero2 = new Pasajero(33162152, "Liliana Veron", "3 de Febrero 1515", new DateTime(1988, 6, 19));
         Pasajero pasajero3 = new Pasajero(25161454, "Julian Veron", "Rivadavia 884", new DateTime(2015, 2, 28));
         Pasajero pasajero4 = new Pasajero(25161454, "Elisa Barrios", "Rivadavia 884", new DateTime(2010, 12, 6));
         Console.WriteLine("\n pasajeros cargados");
         Console.WriteLine(pasajero1 + $" (mayor: {pasajero1.IsMayorEdad()})");
         Console.WriteLine(pasajero2 + $" (mayor: {pasajero2.IsMayorEdad()})");
         Console.WriteLine(pasajero3 + $" (mayor: {pasajero3.IsMayorEdad()})");
         Console.WriteLine(pasajero4 + $" (mayor: {pasajero4.IsMayorEdad()})");
         Console.WriteLine("\n cargando tutores...");
         pasajero3.Tutor = pasajero1;
         pasajero4.Tutor = pasajero1;
         try
         {
            pasajero1.Tutor = pasajero1;
         }
         catch (Exception e)
         {
            Console.WriteLine($" !! error: {e.Message}");
         }
         Console.WriteLine("\n tutores cargados:");
         Console.WriteLine($" tutor de {pasajero3.Nombre}: {pasajero3.Tutor}");
         Console.WriteLine($" tutor de {pasajero4.Nombre}: {pasajero4.Tutor}");

         Console.WriteLine("\n" + divisor);
         Console.WriteLine(" creando ventas...");
         Venta venta1 = new Venta(DateTime.Today, cliente1);
         Venta venta2 = new Venta(DateTime.Today, cliente2);
         Console.WriteLine("\n ventas cargadas:");
         Console.WriteLine(venta1);
         Console.WriteLine(venta2);
         Console.WriteLine("\n cargando servicios en ventas");
         venta1.AddServicio(paquete1);
         venta2.AddServicio(paquete4);
         Console.WriteLine("\n ventas con totales:");
         Console.WriteLine(venta1);
         Console.WriteLine(venta2);
         Console.WriteLine();

         //Console.WriteLine("");
         Console.WriteLine(divisor);
         Console.WriteLine("\n presione una tecla para salir ");
         Console.ReadKey();
      }

      private static void MostrarPaquete(Paquete paquete)
      {
         Console.WriteLine($" -> servicios en paquete {paquete.Descripcion}");
         foreach (var servicio in paquete.GetAllServicios())
            Console.WriteLine($"\t - {servicio}");
         Console.WriteLine($"\t -> precio final: U$D {paquete.PrecioDolar} (AR$ {paquete.PrecioPesos})");
         Console.WriteLine();
      }
   }
}