using System;

namespace Lab6
{
    [Serializable]
    public class Bloque : Division
    {
        
        public Bloque(string nombre , Persona encargado) : base(nombre , encargado)
        {
            this.nombre = nombre;
            this.encargado = encargado;
        }
    }
}
