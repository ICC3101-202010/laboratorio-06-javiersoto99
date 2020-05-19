using System;
using System.Collections.Generic;

namespace Lab6
{
    [Serializable]
    public class Area : Division
    {
         
        public Area(string nombre , Persona encargado , List<Persona> personal) : base(nombre , encargado, personal)
        {
            this.nombre = nombre;
            this.encargado = encargado;
            this.personal = personal;
              
        }
    }
}
