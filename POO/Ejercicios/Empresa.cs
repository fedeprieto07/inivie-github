using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Empresa
    {
        private string NombreEmpresa;
        private List<Vehiculo> ListadoVehiculos;

        public string _NombreEmpresa { get => NombreEmpresa; set => NombreEmpresa = value; }
        internal List<Vehiculo> ListadoVehiculos1 { get => ListadoVehiculos; set => ListadoVehiculos = value; }

        public Empresa(string nombreEmpresa)

        {
            this.NombreEmpresa = nombreEmpresa;
            ListadoVehiculos = new List<Vehiculo>();
        }
    }
}
