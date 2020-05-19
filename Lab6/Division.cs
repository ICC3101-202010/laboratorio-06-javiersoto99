using System;
using System.Collections.Generic;

namespace Lab6
{
    [Serializable]
    public class Division
    {
        public string nombre;
        public Persona encargado;


        public Division(string nombre , Persona encargado)
        {
            this.nombre = nombre;
            this.encargado = encargado;
        }

        

       
    }
}
