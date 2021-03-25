using System;
using System.Collections;

namespace TP1.Ejercicio1
{
    public class Classes
    {
        public static void Banco()
        {
            Cuenta cuenta = new Cuenta();
            
            Console.WriteLine(cuenta.MostrarBalance());
        }
    }
}