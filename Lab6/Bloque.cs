using System;
using System.Collections.Generic;

namespace Lab6
{
    [Serializable]
    public class Bloque : Division
    {
        

        public Bloque(string nombre , Persona encargado , List<Persona> personal) : base(nombre , encargado , personal)
        {
            this.nombre = nombre;
            this.encargado = encargado;
            this.personal = personal;
        }
    }
}
