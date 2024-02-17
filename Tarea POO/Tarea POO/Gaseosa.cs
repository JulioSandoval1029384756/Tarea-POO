using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_POO
{
    public class Gaseosa : Bebida
    {
        private string sabor = "";
        private string Azucar = "";
        private string acompañamiento = "";

        public string Sabor { get => sabor; set => sabor = value; }
        public string Azucar1 { get => Azucar; set => Azucar = value; }
        public string Acompañamiento { get => acompañamiento; set => acompañamiento = value; }
        
    }
}
