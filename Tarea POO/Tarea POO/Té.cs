using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_POO
{
    public class Té : Bebida
    {
        private string tipo = "";
        private int valor;
        private string temperatura = "";

        public string Tipo { get => tipo; set => tipo = value; }
        public int Valor { get => valor; set => valor = value; }
        public string Temperatura { get => temperatura; set => temperatura = value; }
    }
}
