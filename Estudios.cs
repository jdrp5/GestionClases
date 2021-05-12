using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClases
{
    public class Estudios
    {
        public long Propietario { get; set; }
        public EEstudios TipoEstudios { get; set; }
        public string Titulo { get; set; }
        public string Universidad { get; set; }
        public int Año { get; set; }

        public int NoMiembros { get => 5; }


        private readonly string Filename = "Estudios.txt";


        public Estudios(long propietario)
        {
            Propietario = propietario;
        }


        public void SetItem(int item)
        {
            switch (item)
            {
                //case 0:

                //    Console.WriteLine("Digite un valor para No de Identificacion");
                //    Propietario = Convert.ToInt64(Console.ReadLine());

                //    break;
                case 1:
                    Console.WriteLine("Digite un Tipo de estudio \nPregrado\nPosgrado");
                    TipoEstudios = (EEstudios)Enum.Parse(typeof(EEstudios),Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("Digite un valor Titulo");
                    Titulo = Console.ReadLine();
                    break;
                case 3:
                   Console.WriteLine("Digite un valor para universidad");
                    Universidad = Console.ReadLine();
                    break;
                case 4:
                     Console.WriteLine("Digite un valor para el año");
                    Año = Convert.ToInt32(Console.ReadLine());
                    break;
            }
        }

        public void SetItem(int item, string value)
        {
            switch (item)
            {
                //case 0:

                //    Propietario = Convert.ToInt64(value);
                //    break;
                case 1:

                    TipoEstudios = (EEstudios)Enum.Parse(typeof(EEstudios), value);
                    break;
                case 2:

                    Titulo = value;
                    break;
                case 3:

                    Universidad =value;
                    break;
                case 4:

                    Año = Convert.ToInt32(value); 
                    break;
            }
        }


        public string GetItem(int item)
        {
            switch (item)
            {
                case 0: return Propietario.ToString();

                case 1: return TipoEstudios.ToString();

                case 2: return Titulo;

                case 3: return Universidad;

                case 4: return Año.ToString();

                default: return string.Empty;

            }
        }



        public void Add()
        {
           
            System.IO.StreamWriter writer = new System.IO.StreamWriter(Filename, true);
           
            writer.WriteLine(GetLineaCSV());
           
            writer.Close();

        }

        public void Update()
        {
            System.IO.StreamReader reader = new System.IO.StreamReader(Filename);
            string filas = "";
            while (!reader.EndOfStream)
            {
                string fila = reader.ReadLine();
                string[] vs = fila.Split(',');
                if (vs[0] != Propietario.ToString())
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
                if (vs[0] != Propietario.ToString())
                {
                    filas += fila + "\n";
                }

            }
            reader.Close();

            System.IO.StreamWriter writer = new System.IO.StreamWriter(Filename, false);

            writer.Write(filas);

            writer.Close();
        }

        public bool Search(long propietario)
        {
            System.IO.StreamReader reader = new System.IO.StreamReader(Filename);

            while (!reader.EndOfStream)
            {
                string fila = reader.ReadLine();
                string[] vs = fila.Split(',');

                if (vs[0] == propietario.ToString())
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

        public void Show()
        {
            Console.WriteLine(GetLineaCSV());
        }

        private string GetLineaCSV()
        {
            string s = string.Empty;

            for (int i = 0; i < NoMiembros; i++)
            {
                s += (i < NoMiembros - 1) ? GetItem(i) + "," : GetItem(i);
            }

            return s;
        }


    }
}
