using System;
using System.Collections.Generic;


namespace TP1.Ejercicio1
{
    public class Banco
    {
        private String _nombre { get; set; }
        private List<Sucursal> _sucursals = new List<Sucursal>();
        private Sucursal _casaMatriz;

        public void AgregarSucursal(Sucursal sucursal, bool esCasaMatriz = false)
        {
            _sucursals.Add(sucursal);
            if (esCasaMatriz)
                _casaMatriz = sucursal;
                Console.WriteLine("Es matriz");
        }
    }
    
    
}