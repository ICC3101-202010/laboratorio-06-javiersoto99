using System;
using System.Collections.Generic;

namespace Lab6
{
    [Serializable]
    public class Division
    {
        public string nombre;
        public Persona encargado;
        public List<Persona> personal;



        public Division(string nombre , Persona encargado , List<Persona> personal)
        {
            this.nombre = nombre;
            this.encargado = encargado;
            this.personal = personal;
        }

        

       
    }
}
