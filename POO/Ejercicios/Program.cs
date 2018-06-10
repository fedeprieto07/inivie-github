using System;

namespace ConsoleApp4
{
    class Program
    {

        static void Main(string[] args)
        {


            Empresa empresa = new Empresa("Pipo");

            Menu();
            void Menu()
            {
                Console.WriteLine("Seleccionar codigo de menu");
                Console.WriteLine("1 Crear Vehiculo");
                Console.WriteLine("2 Listar Vehiculos de la empresa");
                Console.WriteLine("3 Instanciar vehiculos");
                Console.WriteLine("4 Vehiculos con mas de 120000km");

                int codigoMenu = int.Parse(Console.ReadLine());

                if (codigoMenu == 1)
                {
                    Console.Clear();
                    CrearVEhiculo();

                }
                if (codigoMenu == 2)
                {
                    Console.Clear();
                    listarVehiculos();

                }
                if (codigoMenu == 3)
                {
                    Console.Clear();
                    instanciarVehiculos();

                }

                if (codigoMenu == 4)
                {
                    Console.Clear();
                    reporte120();

                }

            }

            void reporte120()
            {
                Console.WriteLine("Vehiculos con mas de 120000Km");
                foreach (var v in empresa.ListadoVehiculos1)
                {



                    

                    if (v._Kilometraje>=120000)
                    {



                        Console.WriteLine(v._Codigo);
                        Console.WriteLine(v._Marca);
                        Console.WriteLine(v._Modelo);
                        Console.WriteLine(v._Kilometraje);
                        Console.WriteLine(" ");

                    }



                }

                Menu();


            }


            void instanciarVehiculos()
            {
                Vehiculo vehiculo1 = new Vehiculo(1, "utilitario", "reno", "kanguu", 166000);
                Vehiculo vehiculo2 = new Vehiculo(2, "utilitario", "reno", "Duster", 0);
                Vehiculo vehiculo3 = new Vehiculo(3, "automovil", "audi", "a2", 10000);
                Vehiculo vehiculo4 = new Vehiculo(3, "automovil", "reno", "sandero", 190000);

                empresa.ListadoVehiculos1.Add(vehiculo1);
                empresa.ListadoVehiculos1.Add(vehiculo2);
                empresa.ListadoVehiculos1.Add(vehiculo3);
                empresa.ListadoVehiculos1.Add(vehiculo4);
                Menu();
            }
            void CrearVEhiculo()
            {
                Console.WriteLine("Seleccionar Codigo del Vehiculo");
                int CodigoV = int.Parse(Console.ReadLine());

                Console.WriteLine("Seleccionar Tipo del Vehiculo");
                string TipoV = Console.ReadLine();

                Console.WriteLine("Seleccionar Marca del Vehiculo");
                string MarcaV = Console.ReadLine();

                Console.WriteLine("Seleccionar Modelo del Vehiculo");
                string ModeloV = Console.ReadLine();

                Console.WriteLine("Seleccionar KM del Vehiculo");
                int KmV = int.Parse(Console.ReadLine());

                Vehiculo vehiculo = new Vehiculo(CodigoV, TipoV, MarcaV, ModeloV, KmV);

                empresa.ListadoVehiculos1.Add(vehiculo);
                Menu();
            }

            void listarVehiculos() { 
            foreach (var v in empresa.ListadoVehiculos1)
            {
                    

                    Console.WriteLine(v._Codigo);
                    Console.WriteLine(v._Marca);
                    Console.WriteLine(v._Modelo);
                    Console.WriteLine(v._Kilometraje);




                }

                Menu();
            }
        }
    }
}
