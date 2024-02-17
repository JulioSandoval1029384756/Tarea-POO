using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Té objTé = new Té();
            objTé.Liquido = "Té";
            objTé.Tamaño = "Grande";
            objTé.Cantidad = "Lleno";
            objTé.Tipo = "Té de tilo";
            objTé.Valor = 15;
            objTé.Temperatura = "Caliente";

            Console.WriteLine("Té \nLiquido: " + objTé.Liquido + "\nTamaño: " + objTé.Tamaño + "\nCantidad: " + objTé.Cantidad + "\nTipo: " + objTé.Tipo + "\nValor: " + objTé.Valor + "\nTemperatura: " + objTé.Temperatura);
            

            Gaseosa objGas = new Gaseosa();
            objGas.crearBebida("Gaseosa", "Mediana", "Medio");
            objGas.Sabor = "Fanta";
            objGas.Azucar1 = "Sin azucar";
            objGas.Acompañamiento = "Hielo";

            Console.WriteLine("Gaseosa \nLiquido: " + objGas.Liquido + "\nTamaño: " + objGas.Tamaño + "\nCantidad: " + objGas.Cantidad + "\nSabor: " + objGas.Sabor + "\nAzucar: " + objGas.Azucar1 + "\nAconpañamiento: " + objGas.Acompañamiento);

            Console.WriteLine("Presiona Enter para salir...");
            Console.ReadLine();
        }
    }
}
