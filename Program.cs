using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClases
{
    class Program
    {

        static void Raya(string name,char cr)
        {
           
            Console.CursorLeft = ((50 - name.Length)/2);
            Console.WriteLine(name);
            for (int i = 1; i < 50; i++)
            {
                Console.Write(cr);
            }

            Console.WriteLine();
        }

        static string CompletarPuntos(string opcion, int index)
        {
            string s = opcion + " opcion";
            int upper = 49 - (opcion + " opcion").Length;
            
            for (int i = 1; i < upper; i++)
                 s += ".";

            return s + index;
        }


        static int MenuAutomatico(string name,string[] opciones)
        {
            Raya(name,'-');
            for (int i = 1; i < opciones.GetLength(0); i++)
            {
                Console.WriteLine(CompletarPuntos(opciones[i], i));
               
            }

            Console.WriteLine(CompletarPuntos(opciones[0], 0));
            
            Raya("",'-');



            Console.CursorLeft = "Digite una opcion ".Length + 4;
            Console.WriteLine("╔════════╗");
            Console.Write("Digite una opcion     "); Console.WriteLine("║        ║");
            Console.CursorLeft = "Digite una opcion ".Length + 4;
            Console.WriteLine("╚════════╝");
            
            Console.CursorLeft = "Digite una opcion ".Length + 8;
            Console.CursorTop = Console.CursorTop-2;

            
            int op = Convert.ToInt32( Console.ReadLine());


            return op;
        }


        static void Casos(int op)
        {
            Console.Clear();
            int op1 = 0;

            switch (op)
            {
                case 1:
                    
                    op1 = MenuAutomatico("Cursos",new string[] { "Salir", "Add", "Update", "Delete", "ToList" });
                    CasosCurso(op1);

                    break;

                case 2:

                    op1 = MenuAutomatico("Profesores", new string[] { "Salir", "Add", "Update", "Delete", "ToList" });
                    CasosProfesor(op1);

                    break;

                case 3:
                    MenuAutomatico("Estudiantes", new string[] { "Salir", "Add", "Update", "Delete", "ToList" });
                    break;
                case 4:
                    MenuAutomatico("ToList",new string[] { "Salir", "Add", "Update", "Delete", "ToList" });
                    break;
                
                default:
                    break;
            }
        }

        static void CasosProfesor(int op)
        {
            Console.Clear();

            switch (op)
            {
                case 1://Add

                    Profesor p = new Profesor();

                    p.Show();

                    break;
                case 2://Update
                    
                    break;
                case 3://Delete
                   
                    break;
                case 4://ToList
                   
                   
                case 5:
                    Profesor.ToList();
                    Console.ReadKey();
                    break;
                default:
                    break;
            }
        }

        static void CasosEstudiante(int op)
        {
            Console.Clear();

            switch (op)
            {
                case 1://Add--ojo el profesor puede agregar estudios

                    break;
                case 2://Update

                    break;
                case 3:

                    break;
                case 4://Delete

                    break;
                case 5://ToList

                    break;

                default:
                    break;
            }
        }

        static void CasosCurso(int op)
        {
            Console.Clear();

            switch (op)
            {
                case 1://Add

                    break;
                case 2://Update

                    break;
                case 3:

                    break;
                case 4://Delete

                    break;
                case 5://ToList

                    break;

                default:
                    break;
            }
        }

        static void Main(string[] args)
        {
            Console.SetWindowSize(120,36);

           
            Console.WriteLine("estoy escribiendo aqui");



            int op = 0;

            do
            {
                Console.Clear();

                op=MenuAutomatico("Menu Principal",new string[] { "Salir", "Cursos", "Profesores", "Estudiantes", "ToList" });
                
                Console.WriteLine();

                Casos(op);

            } while (op > 0);
           




            //Profesor p = new Profesor
            //{
            //    NoIdentificacion = 123455,
            //    Nombre = "Juanito",
            //    NoTelefono = 5655092,
            //    Direccion = "No me la se",
            //    Correo = "juanito@hotmail.com"
            //};

            //p.Show();

            //Estudios estudios = new Estudios(p.NoIdentificacion);

            //estudios.TipoEstudios = EEstudios.Pregrado;
            //estudios.Titulo = "Ingeniero de Sistemas";
            //estudios.Universidad = "Universidad Popular del Cesar";
            //estudios.Año = 2007;

            ////estudios.Add();

            //p.EstudiosRealizados.Add(estudios);

            //Estudios estudios1 = new Estudios(p.NoIdentificacion);

            //estudios.TipoEstudios = EEstudios.Pregrado;
            //estudios.Titulo = "Ingeniero de Sistemas";
            //estudios.Universidad = "Universidad Popular del Cesar";
            //estudios.Año = 2007;

            ////estudios.Add();

            //p.EstudiosRealizados.Add(estudios1);

            //Estudios estudios2 = new Estudios(p.NoIdentificacion);

            //estudios.TipoEstudios = EEstudios.Pregrado;
            //estudios.Titulo = "Ingeniero de Sistemas";
            //estudios.Universidad = "Universidad Popular del Cesar";
            //estudios.Año = 2007;

            ////estudios.Add();

            //p.EstudiosRealizados.Add(estudios2);

            //estudios.Show();

            //p.Add();
            

            //p.ToList();



            //Console.Read();
        }
    }
}
