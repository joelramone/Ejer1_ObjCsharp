using System;
using System.Collections.Generic;

namespace TP1.Ejercicio1
{
    public class Cliente 
    {
        private String _nombre { get; set; }
        private String _apellido { get; set; }
        private String _dni { get; set; }
        private String _fechaDeNacimiento { get; set; }
        private List<Cuenta> _cuentasBancarias;

        public Cliente()
        {
            
        }
        public Cliente(String nombre, String apellido, String dni, String fechaDeNacimiento)
        {
            _nombre = nombre;
            _apellido = apellido;
            _dni = dni;
            _fechaDeNacimiento = fechaDeNacimiento;
            _cuentasBancarias = new List<Cuenta>();
        }



        public void AsignarCuenta(Cuenta cuenta)
        {
            cuenta._cliente = this;
            _cuentasBancarias.Add(cuenta);
        }
        
        
    
    }



    

}


    