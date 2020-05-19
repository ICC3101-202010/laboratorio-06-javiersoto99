using System;

namespace Lab6
{
    [Serializable]
    public class Persona
    {
        public string nombre;
        public string apellido;
        public string RUT;
        public string cargo;

        public Persona(string nombre, string apellido, string RUT, string cargo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.RUT = RUT;
            this.cargo = cargo;
        }

        public override string ToString()
        {
            return "Nombre: " + nombre + " Apellido: " + apellido + " RUT: " + RUT + " Cargo: " + cargo;
        }
    }
}
