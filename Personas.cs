using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClases
{
    public class Personas
    {
        public long NoIdentificacion { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public long NoTelefono { get; set; }
        public string Correo { get; set; }
       
        public void Show()
        {
            Console.WriteLine($"{NoIdentificacion} {Nombre} {Direccion} {NoTelefono} {Correo}");

        }


    }
}
