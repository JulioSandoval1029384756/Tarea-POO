using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_POO
{
    public class Bebida
    {
        private string liquido = "";
        private string tamaño = "";
        private string cantidad = "";


        public string Liquido { get => liquido; set => liquido = value; }
        public string Tamaño { get => tamaño; set => tamaño = value; }
        public string Cantidad { get => cantidad; set => cantidad = value; }

        public void crearBebida(string _liquido, string _tamaño, string _cantidad)
        {
            liquido = _liquido;
            tamaño = _tamaño;
            Cantidad = _cantidad;
        }
        
    }
}

