using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClases
{

    public class Profesor:Personas
    {

        public List<Estudios> EstudiosRealizados { get; set; }

        private string Filename = "Profesor.txt";
        static private string Path = "Profesor.txt";
        public int NoMiembros { get => 5; }
            
        static List<Profesor> Profesores { get; }


        public Profesor()
        {
            if(EstudiosRealizados==null)EstudiosRealizados = new List<Estudios>();
            
            for (int i = 0; i < NoMiembros; i++)
            {
                SetItem(i);
            }

            bool ok;
            do
            {
                ok = false;

                Console.WriteLine("Desea agregar estudios\nSi => Y\nNo => N");
                string yn = Console.ReadLine();

                if (yn.ToLower() == "y")
                {
                    Estudios estudios = new Estudios(NoIdentificacion);

                    for (int i = 0; i < estudios.NoMiembros; i++)
                    {
                        estudios.SetItem(i);
                    }

                    EstudiosRealizados.Add(estudios);
                    ok = true;
                }

            } while (ok);

            Add();
        }

        public void SetItem(int item)
        {
            switch (item)
            {
                case 0:

                    Console.WriteLine("Digite un valor para No de Identificacion");
                    NoIdentificacion = Convert.ToInt64(Console.ReadLine());

                    break;
                case 1:
                    Console.WriteLine("Digite un valor para Nombre");
                    Nombre = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Digite un valor para Direccion");
                    Direccion = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Digite un valor para No Telefono");
                    NoTelefono = Convert.ToInt64(Console.ReadLine());
                    break;
                case 4:
                    Console.WriteLine("Digite un valor para Correo");
                    Correo = Console.ReadLine();
                    break;
            }
        }

        public void SetItem(int item, string value)
        {
            switch (item)
            {
                case 0:

                    NoIdentificacion = Convert.ToInt64(value);
                    break;
                case 1:
                    
                    Nombre = value;
                    break;
                case 2:
                   
                    Direccion = value;
                    break;
                case 3:
                   
                    NoTelefono = Convert.ToInt64(value);
                    break;
                case 4:
                    
                    Correo = value;
                    break;
            }
        }


        public string GetItem(int item)
        {
            switch (item)
            {
                case 0: return NoIdentificacion.ToString();

                case 1:return Nombre;
                   
                case 2: return Direccion;
                
                case 3: return NoTelefono.ToString();
                  
                case 4: return Correo;

                default: return string.Empty;
              
            }
        }


        public void Add()
        {
            
            System.IO.StreamWriter writer = new System.IO.StreamWriter(Filename,true);
           
            writer.WriteLine(GetLineaCSV());
           
            writer.Close();

            foreach (var item in EstudiosRealizados)
            {
                item.Add();
            }


        }


        public void Update()
        {
            System.IO.StreamReader reader = new System.IO.StreamReader(Filename);
            string filas = "";
            while (!reader.EndOfStream)
            {
                string fila = reader.ReadLine();
                string[] vs = fila.Split(',');
                if (vs[0] != NoIdentificacion.ToString())
                {
                    filas += fila + "\n";
                }
                else
                {
                    filas += GetLineaCSV() + "\n";
                }

            }
            reader.Close();

            System.IO.StreamWriter writer = new System.IO.StreamWriter(Filename, false);

            writer.Write(filas);

            writer.Close();
        }

        public void Delete()
        {
            System.IO.StreamReader reader = new System.IO.StreamReader(Filename);
            string filas = "";
            while (!reader.EndOfStream)
            {
                string fila = reader.ReadLine();
                string[] vs = fila.Split(',');
                if (vs[0] != NoIdentificacion.ToString())
                {
                    filas += fila + "\n";
                }
                
            }
            reader.Close();

            System.IO.StreamWriter writer = new System.IO.StreamWriter(Filename, false);
           
            writer.Write(filas);
           
            writer.Close();

        }

        public Profesor Find(long NoIdentificacion)
        {
            System.IO.StreamReader reader = new System.IO.StreamReader(Filename);

            while (!reader.EndOfStream)
            {
                string fila = reader.ReadLine();
                string[] vs = fila.Split(',');

                if (vs[0] == NoIdentificacion.ToString())
                {
                    Profesor p = new Profesor();
                    for (int i = 0; i < NoMiembros; i++)
                    {
                        p.SetItem(i, vs[i]);
                    }

                    reader.Close();

                    return p;
                    
                }
            }

            reader.Close();
            
            return null;

        }


        public bool Search(long NoIdentificacion)
        {
            System.IO.StreamReader reader = new System.IO.StreamReader(Filename);
           
            while (!reader.EndOfStream)
            {
                string fila = reader.ReadLine();
                string[] vs = fila.Split(',');

                if (vs[0]==NoIdentificacion.ToString())
                {
                    reader.Close();
                    return true;
                }
            }

            reader.Close();
            return false;
 
        }

        static public void ToList()
        {
           
            System.IO.StreamReader reader = new System.IO.StreamReader(Path);
           
            while (!reader.EndOfStream)
            {
                string fila = reader.ReadLine();
               
                Console.WriteLine(fila);

                System.IO.StreamReader readerEst = new System.IO.StreamReader("Estudios.txt");

                string estu = "";
                Console.WriteLine("Estudios:");
                while (!readerEst.EndOfStream)
                {
                    estu = readerEst.ReadLine();
                    if (fila.Substring(0, fila.IndexOf(','))== estu.Substring(0, fila.IndexOf(',')))
                    {
                        Console.WriteLine(estu);
                    }
                    
                }

                readerEst.Close();

                Console.WriteLine();
            }

            //Cerrar el archivo
            reader.Close();
        }

        public new void Show()
        {
            Console.WriteLine(GetLineaCSV());
            
            foreach (var item in EstudiosRealizados)
            {
                item.Show();
            }

        }

        private string GetLineaCSV()
        {
            string s = string.Empty;

            for (int i = 0; i < NoMiembros; i++)
            {
                s += (i < NoMiembros-1)? GetItem(i) + ",": GetItem(i) ;
            }

            return s;
        }
    }
}
