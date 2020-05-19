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
                            Area area2 = new Area("Area", encargadoArea2 , null);
                            divisiones2.Add(area2);

                            //DEPARTAMENTO
                            Persona encargadoDepa2 = new Persona("Lionel", "Messi", "23.204.345-5", "Encargado Departamento");
                            Departamento departamento2 = new Departamento("Departamento", encargadoDepa2 , null);
                            divisiones2.Add(departamento2);

                            //SECCION
                            Persona encargadoSec2 = new Persona("Elon", "Musk", "18.094.234-1", "Encargado Seccion");
                            Seccion seccion2 = new Seccion("Seccion", encargadoSec2,null);
                            divisiones2.Add(seccion2);

                            //BLOQUE1

                            List<Persona> personalB1 = new List<Persona>();
                            Persona encargadoB1 = new Persona("Humberto", "Suazo", "15.657.778-2", "Encargado Bloque 1");
                            Persona personal1B1 = new Persona("Juan", "Perez", "17.232.688-6", "Personal 1 ");
                            Persona personal2B1 = new Persona("Diego", "Soto", "17.343.777-2", "Personal 2 ");
                            Persona personal3B1 = new Persona("Pablo", "Poblete", "10.666.448-3", "Personal 3");
                            Persona personal4B1 = new Persona("Sofia", "Alcalde", "20.074.788-9", "Personal 4");
                            Persona personal5B1 = new Persona("Javier", "Coll", "19.346.448-8", "Personal 5");
                            personalB1.Add(personal1B1);
                            personalB1.Add(personal2B1);
                            personalB1.Add(personal3B1);
                            personalB1.Add(personal4B1);
                            personalB1.Add(personal5B1);

                            Bloque bloque1 = new Bloque("Bloque 1", encargadoB1 , personalB1);
                            divisiones2.Add(bloque1);

                            //BLOQUE2
                            Persona encargadoB2 = new Persona("Alexis", "Sanchez", "18.343.566-7", "Encargado Bloque 2");
                            List<Persona> personalB2 = new List<Persona>();
                            Persona personal1B2 = new Persona("Vicente", "Perez", "20.999.688-6", "Personal 1 ");
                            Persona personal2B2 = new Persona("Rodrigo", "Olguin", "23.455.788-K", "Personal 2 ");
                            Persona personal3B2 = new Persona("Nicolas", "Valencia", "24.666.666-5", "Personal 3");
                            Persona personal4B2 = new Persona("Emilia", "Segura", "22.899.056-9", "Personal 4");
                            Persona personal5B2 = new Persona("Vicente", "Poblete", "20.346.448-8", "Personal 5");
                            personalB2.Add(personal1B2);
                            personalB2.Add(personal2B2);
                            personalB2.Add(personal3B2);
                            personalB2.Add(personal4B2);
                            personalB2.Add(personal5B2);

                            Bloque bloque2 = new Bloque("Bloque 2", encargadoB2 , personalB2);
                            divisiones2.Add(bloque2);

                            Empresa empresa2 = new Empresa(nombreEmp2, RUTEmp2, divisiones2);
                            empresas.Add(empresa2);
                            Save(empresas);
                            Console.WriteLine("Empresa creada correctamente");




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

                                Area area = new Area("Area",encargadoArea,null);
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

                                Departamento departamento = new Departamento("Departamento", encargadoDepa,null);
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

                                Seccion seccion = new Seccion("Seccion", encargadoSec,null);
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
                                int cantb = 0;
                                Console.WriteLine("Cuantos Bloques desdea agregar?");
                                cantb = Convert.ToInt32(Console.ReadLine());

                                for(int i = 0; i < cantb; i++)
                                {
                                    List<Persona> personalBloq = new List<Persona>();
                                    Console.WriteLine("Ingrese Nombre del encargado del Bloque " + (i + 1) +" : ");
                                    string nombreEB = Console.ReadLine();
                                    Console.WriteLine("Ingrese Apellido del encargado del Bloque " + (i + 1) + " : ");
                                    string apellidoEB = Console.ReadLine();
                                    Console.WriteLine("Ingrese RUT del encargado del Bloque " + (i + 1) + " : ");
                                    string rutEB = Console.ReadLine();
                                    Persona encargadoBloq = new Persona(nombreEB, apellidoEB, rutEB, "Encargado Bloque" + (i + 1));

                                    Console.WriteLine("");
                                    Console.WriteLine("Cuanto personal desea agregar? ");
                                    int cantp = Convert.ToInt32(Console.ReadLine());
                                    for(int j = 0; j < cantp; j++)
                                    {
                                        Console.WriteLine("Ingrese nombre del Personal "+(j+1)+" : ");
                                        string nombrePer = Console.ReadLine();
                                        Console.WriteLine("Ingrese apellido del Personal " + (j + 1) + " : ");
                                        string apellidoPer = Console.ReadLine();
                                        Console.WriteLine("Ingrese RUT del Personal " + (j + 1) + " : ");
                                        string rutPer = Console.ReadLine();
                                        Persona personalB = new Persona(nombrePer, apellidoPer, rutPer, "Personal" + (j+1));
                                        personalBloq.Add(personalB);
                                    }

                                    

                                    Bloque bloque = new Bloque("Bloque" + (i + 1), encargadoBloq , personalBloq);
                                    divisiones.Add(bloque);
                                }
                                
                                break;
                            case "n":
                                break;
                            default:
                                Console.WriteLine("Opción no valida");
                                break;
                        }

                        Console.WriteLine("Empresa creada correctamente");
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
                    Console.WriteLine(division.encargado.nombre + " " + division.encargado.apellido + " " + division.encargado.RUT);
                    Console.WriteLine("");
                    Console.WriteLine("");
                    if(division.personal != null)
                    {
                        Console.WriteLine("Personal "+division.nombre + " : ");
                        foreach (Persona personal in division.personal)
                        {
                            Console.WriteLine(personal.nombre + " " + personal.apellido + " " + personal.RUT);
                        }
                    }
                    
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
