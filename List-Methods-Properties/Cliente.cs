using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Methods_Properties
{
    public class Cliente
    {

        public Cliente(string nombre, string primerApe, string segundoApe, int edad, string direccion)
        {
            this.nombre = nombre;
            this.primerApe = primerApe;
            this.segundoApe = segundoApe;
            this.edad = edad;
            this.direccion = direccion; 
        }

        public string nombre { get; set; }
        public string primerApe { get; set; }
        public string segundoApe { get; set; }
        public int edad { get; set; }
        public string direccion { get; set; }



    }
}
