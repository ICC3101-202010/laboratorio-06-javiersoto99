using System;

namespace Lab6
{
    [Serializable]
    public class Seccion : Division
    {
        
        public Seccion(string nombre , Persona encargado) : base(nombre , encargado)
        {
            this.nombre = nombre;
            this.encargado = encargado;
        }
    }
}
