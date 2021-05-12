using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClases
{
    public class Asignatura
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int NoCreditos { get; set; }
        public int Semestre { get; set; }

        private string Filename = "Estudiante.txt";


        public void Show()
        {
            Console.WriteLine($"{Codigo} {Nombre} {NoCreditos}");
        }

        public void Add()
        {

        }

        public void Update()
        {

        }

        public void Delete()
        {

        }

        public void Search()
        {

        }

        public void ToList()
        {

        }

    }
}
