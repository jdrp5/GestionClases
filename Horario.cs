using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClases
{
    public class Horario
    {
        public string Curso { get; set; } //
        public string DiaSemana { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFin { get; set; }

        private string Filename = "Horario.txt";
        //ojo se debe saber para que curso se guarda un horario 2021_1_1


        public void Show()
        {
            Console.WriteLine($"{DiaSemana} de {HoraFin} hasta las {HoraFin}");
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
