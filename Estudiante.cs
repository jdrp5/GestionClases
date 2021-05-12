using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClases
{
    public class Estudiante:Personas
    {

        public List<AsignaturaEstudiante> ListaAsignaturas { get; set; }
        private string Filename = "Estudiante.txt";

        public void Add()
        {

        }

        public void Update()
        {

        }

        public void Delete()
        {

        }

        public bool Search(long NoIdentificacion)
        {
            System.IO.StreamReader reader = new System.IO.StreamReader(Filename);

            while (!reader.EndOfStream)
            {
                string fila = reader.ReadLine();
                string[] vs = fila.Split(',');

                if (vs[0] == NoIdentificacion.ToString())
                {
                    reader.Close();
                    return true;
                }
            }

            reader.Close();
            return false;

        }

        public void ToList()
        {
            
        }

        public new void  Show()
        {

        }
    }
}
