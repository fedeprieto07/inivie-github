using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Vehiculo
    {
        private int codigo;
        private string tipo;
        private string marca;
        private string modelo;
        private int kilometraje;

        public int _Codigo { get => codigo; set => codigo = value; }
        public string _Tipo { get => tipo; set => tipo = value; }
        public string _Marca { get => marca; set => marca = value; }
        public string _Modelo { get => modelo; set => modelo = value; }
        public int _Kilometraje { get => kilometraje; set => kilometraje = value; }

        public Vehiculo(int codigo, string tipo, string marca, string modelo, int kilometraje)
        {
            this.codigo = codigo;
            this.tipo = tipo;
            this.marca = marca;
            this.modelo = modelo;
            this.kilometraje = kilometraje;
        }
    }
}
