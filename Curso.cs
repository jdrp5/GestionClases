using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClases
{
    class Curso //=grupo, corresponde a una sola asignatura
    {
        public int Año { get; set; }
        public int Periodo { get; set; }
        public int NoGrupo { get; set; }
        public Profesor Profesor { get; set; }
        public Asignatura Asignatura { get; set; }
        public List<Horario> HorarioClases { get; set; }
        public string LinkVideoconferencia { get; set; }
        public List<Estudiante> Estudiantes { get; set; }
        public int Capacidad { get; set; }



        private string Filename = "Curso.txt";


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

        public void Show()
        {

        }

    }
}
