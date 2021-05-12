using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClases
{
    public class AsignaturaEstudiante:Asignatura
    {
        public string Curso { get; set; } 
        public Notas Notas { get; set; }

        private string Filename = "Notas.txt";
        //ojo se debe saber para que curso se guarda un horario 2021_1_1

        public new void Add()
        {

        }

        public new void Update()
        {

        }

        public new void Delete()
        {


        }

        public new void Search()
        {

        }

        public new void ToList()
        {

        }

    }
}
