using System;

namespace Lab6
{
    [Serializable]
    public class Area : Division
    {
        
        public Area(string nombre , Persona encargado) : base(nombre , encargado)
        {
            this.nombre = nombre;
            this.encargado = encargado;
              
        }
    }
}
