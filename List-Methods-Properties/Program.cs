using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Methods_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente oCliente1 = new Cliente("Moises", "Prueba1", "Prueba1", 12, "Prueba1"); 
            Cliente oCliente2 = new Cliente("Moises2", "Prueba2", "Prueba2", 12, "Prueba2"); 
            Cliente oCliente3 = new Cliente("Moises3", "Prueba3", "Prueba3", 12, "Prueba3"); 
            Cliente oCliente4 = new Cliente("Moises4", "Prueba4", "Prueba4", 12, "Prueba4"); 
            Cliente oCliente5 = new Cliente("Moises5", "Prueba5", "Prueba5", 12, "Prueba5");

            List<Cliente> listCliente = new List<Cliente>
            {
                oCliente1, oCliente2, oCliente3, oCliente4, oCliente5
            };

            listCliente.Add(new Cliente("Moises", "Prueba6", "Prueba6", 12, "Prueba6"));

            foreach(Cliente prueba in listCliente)
            { 
                Console.WriteLine(prueba.primerApe + "\n");
            }

            Console.ReadLine();
        }
    }
}
