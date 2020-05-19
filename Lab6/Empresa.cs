using System;
using System.Collections.Generic;

namespace Lab6
{
    [Serializable]
    public class Empresa
    {
        public string nombre;
        public string RUT;
        public List<Division> divisiones;

        public Empresa(string nombre , string RUT, List<Division> divisiones)
        {
            this.nombre = nombre;
            this.RUT = RUT;
            this.divisiones = divisiones;
        }

        public override string ToString()
        {
            return "Nombre : " +nombre + " RUT: "+ RUT;
        }
    }
}
