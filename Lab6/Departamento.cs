using System;

namespace Lab6
{
    [Serializable]
    public class Departamento : Division
    {
        
        public Departamento(string nombre, Persona encargado) : base(nombre , encargado)
        {
            this.nombre = nombre;
            this.encargado = encargado;
        }
    }
}
