using System;
using TP1.Ejercicio1;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");  
            Cuenta cuenta = new Cuenta();
            Banco banco = new Banco();
            Sucursal sucursal = new Sucursal();
            Cliente cliente = new Cliente();
            Console.WriteLine(cuenta);
            cuenta.Depositar(30M);
            cuenta.Extraer(40M);
            cuenta.Depositar(30M);
            banco.AgregarSucursal(sucursal,true);
            Console.WriteLine(cuenta.MostrarBalance());
        }
    }
}