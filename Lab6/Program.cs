using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Empresa> empresas = new List<Empresa>();
            int eleccion = 0;
            Console.WriteLine("Bienvenido !");
            while(eleccion != 3)
            {
                Console.WriteLine("Desea utilizar un archivo para cargar la información de la empresa?");
                Console.WriteLine("1.- Si");
                Console.WriteLine("2.- No");
                Console.WriteLine("3.- Salir");  
                
                eleccion = Convert.ToInt32(Console.ReadLine());

                switch (eleccion)
                {
                    case 1:
                        Console.Clear();
                        try
                        {
                            
                            empresas = Load();
                            showEmpresas(empresas);


                        }

                        catch(FileNotFoundException)
                        {
                            List<Division> divisiones2 = new List<Division>();
                            Console.WriteLine("No se ha encontrado un archivo para la informacion de la empresa.");
                            Console.Write("Ingrese el Nombre de la Empresa: ");
                            string nombreEmp2 = Console.ReadLine();
                            Console.Write("Ingrese el RUT de la Empresa: ");
                            string RUTEmp2 = Console.ReadLine();
                            Console.WriteLine("Se va a crear la empresa de forma automatica ...");

                            //AREA
                            Persona encargadoArea2 = new Persona("Cristiano", "Ronaldo", "20.074.782-8", "Engargado Area");
                            Area area2 = new Area("Area", encargadoArea2);
                            divisiones2.Add(area2);

                            //DEPARTAMENTO
                            Persona encargadoDepa2 = new Persona("Lionel", "Messi", "23.204.345-5", "Encargado Departamento");
                            Departamento departamento2 = new Departamento("Departamento", encargadoDepa2);
                            divisiones2.Add(departamento2);

                            //SECCION
                            Persona encargadoSec2 = new Persona("Elon", "Musk", "18.094.234-1", "Encargado Seccion");
                            Seccion seccion2 = new Seccion("Seccion", encargadoSec2);
                            divisiones2.Add(seccion2);

                            //BLOQUE1
                            Persona encargadoB1 = new Persona("Humberto", "Suazo", "15.657.778-2", "Encargado Bloque 1");
                            //Persona personal1B1 = new Persona("Juan", "Perez", "17.232.688-6", "Personal 1 ");
                            //Persona personal2B1 = new Persona("Diego", "Soto", "17.343.777-2", "Personal 2 ");
                            //Persona personal3B1 = new Persona("Pablo", "Poblete", "10.666.448-3", "Personal 3");
                            //Persona personal4B1 = new Persona("Sofia", "Alcalde", "20.074.788-9", "Personal 4");
                            //Persona personal5B1 = new Persona("Javier", "Coll", "19.346.448-8", "Personal 5");

                            Bloque bloque1 = new Bloque("Bloque 1", encargadoB1);
                            divisiones2.Add(bloque1);

                            //BLOQUE2
                            Persona encargadoB2 = new Persona("Alexis", "Sanchez", "18.343.566-7", "Encargado Bloque 2");
                            //Persona personal1B1 = new Persona("Juan", "Perez", "17.232.688-6", "Personal 1 ");
                            //Persona personal2B1 = new Persona("Diego", "Soto", "17.343.777-2", "Personal 2 ");
                            //Persona personal3B1 = new Persona("Pablo", "Poblete", "10.666.448-3", "Personal 3");
                            //Persona personal4B1 = new Persona("Sofia", "Alcalde", "20.074.788-9", "Personal 4");
                            //Persona personal5B1 = new Persona("Javier", "Coll", "19.346.448-8", "Personal 5");

                            Bloque bloque2 = new Bloque("Bloque 2", encargadoB2);
                            divisiones2.Add(bloque2);

                            Empresa empresa2 = new Empresa(nombreEmp2, RUTEmp2, divisiones2);
                            empresas.Add(empresa2);
                            Save(empresas);





                        }


                        break;
                    case 2:
                        Console.Clear();

                        List<Division> divisiones = new List<Division>();

                        Console.Write("Ingrese el Nombre de la Empresa: ");
                        string nombreEmp = Console.ReadLine();
                        Console.Write("Ingrese el RUT de la Empresa: ");
                        string RUTEmp = Console.ReadLine();

                        // AREA
                        Console.Clear();
                        string elec = "";
                        Console.WriteLine("Desea Agregar un Area? (s/n)");
                        elec = Console.ReadLine();
                        switch (elec)
                        {
                            case "s":
                                Console.WriteLine("Ingrese Nombre del encargado del Area: ");
                                string nombreEA = Console.ReadLine();
                                Console.WriteLine("Ingrese Apellido del encargado del Area: ");
                                string apellidoEA = Console.ReadLine();
                                Console.WriteLine("Ingrese RUT del encargado del Area: ");
                                string rutEA = Console.ReadLine();

                                Persona encargadoArea = new Persona(nombreEA, apellidoEA, rutEA, "Encargado Area");

                                Area area = new Area("Area",encargadoArea);
                                divisiones.Add(area);
                                break;
                            case "n":
                                break;
                            default:
                                Console.WriteLine("Opción no valida");
                                break;
                            }

                        // DEPARTAMENTO
                        Console.Clear();
                        string elec2 = "";
                        Console.WriteLine("Desea Agregar un Departamento? (s/n)");
                        elec2 = Console.ReadLine();
                        switch (elec2)
                        {
                            case "s":
                                Console.WriteLine("Ingrese Nombre del encargado del Departamento: ");
                                string nombreED = Console.ReadLine();
                                Console.WriteLine("Ingrese Apellido del encargado del Departamento: ");
                                string apellidoED = Console.ReadLine();
                                Console.WriteLine("Ingrese RUT del encargado del Departamento: ");
                                string rutED = Console.ReadLine();

                                Persona encargadoDepa = new Persona(nombreED, apellidoED, rutED, "Encargado Departamento");

                                Departamento departamento = new Departamento("Departamento", encargadoDepa);
                                divisiones.Add(departamento);
                                break;
                            case "n":
                                break;
                            default:
                                Console.WriteLine("Opción no valida");
                                break;
                        }

                        // SECCION
                        Console.Clear();
                        string elec3 = "";
                        Console.WriteLine("Desea Agregar una SECCION? (s/n)");
                        elec3 = Console.ReadLine();
                        switch (elec3)
                        {
                            case "s":
                                Console.WriteLine("Ingrese Nombre del encargado de la Seccion: ");
                                string nombreES = Console.ReadLine();
                                Console.WriteLine("Ingrese Apellido del encargado de la Seccion: ");
                                string apellidoES = Console.ReadLine();
                                Console.WriteLine("Ingrese RUT del encargado de la Seccion: ");
                                string rutES = Console.ReadLine();

                                Persona encargadoSec = new Persona(nombreES, apellidoES, rutES, "Encargado Seccion");

                                Seccion seccion = new Seccion("Seccion", encargadoSec);
                                divisiones.Add(seccion);
                                break;
                            case "n":
                                break;
                            default:
                                Console.WriteLine("Opción no valida");
                                break;
                        }

                        // BLOQUE
                        Console.Clear();
                        string elec4 = "";
                        Console.WriteLine("Desea Agregar una BLOQUE? (s/n)");
                        elec4 = Console.ReadLine();
                        switch (elec4)
                        {
                            case "s":
                                Console.WriteLine("Ingrese Nombre del encargado del Bloque: ");
                                string nombreEB = Console.ReadLine();
                                Console.WriteLine("Ingrese Apellido del encargado del Bloque: ");
                                string apellidoEB = Console.ReadLine();
                                Console.WriteLine("Ingrese RUT del encargado del Bloque: ");
                                string rutEB = Console.ReadLine();

                                Persona encargadoBloq = new Persona(nombreEB, apellidoEB, rutEB, "Encargado Bloque");

                                Bloque bloque = new Bloque("Bloque", encargadoBloq);
                                divisiones.Add(bloque);
                                break;
                            case "n":
                                break;
                            default:
                                Console.WriteLine("Opción no valida");
                                break;
                        }
                        Empresa empresa = new Empresa(nombreEmp, RUTEmp, divisiones);
                        empresas.Add(empresa);
                        Save(empresas);





                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Saliendo del programa ...");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opción no valida");
                        break;
                }

            }
            



        }

      

        static public void showEmpresas(List<Empresa> empresas)
        {
            foreach (Empresa empresa in empresas)
            {
                Console.WriteLine("Nombre Empresa: " + empresa.nombre);
                Console.WriteLine("RUT Empresa: " + empresa.RUT);
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("");
                foreach(Division division in empresa.divisiones)
                {
                    Console.WriteLine("Division: " + division.nombre);
                    Console.WriteLine("");
                    Console.WriteLine(division.encargado.cargo + " : " );
                    Console.WriteLine(division.encargado.nombre);
                    Console.WriteLine(division.encargado.apellido);
                    Console.WriteLine(division.encargado.RUT);
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------");

            }
            Console.WriteLine("");
        }

        static public void Save(List<Empresa> empresas)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, empresas);
            stream.Close();
        }
        static public List<Empresa> Load()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("empresa.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List<Empresa> empresas = (List<Empresa>)formatter.Deserialize(stream);
            stream.Close();
            return empresas;
        }
    }
}
