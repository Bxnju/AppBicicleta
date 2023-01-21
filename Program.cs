using AppBicicleta.Clases;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {

		try
		{

            byte vel_objetivo;
            byte opcion = 0;
            Bicicleta bicicleta = new Bicicleta();
            

            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.ResetColor();
                Console.WriteLine("\nSimulador de Bicicleta hecho por Benju.");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nVelocidad actual de la bicicleta: " + bicicleta.velocidad_actual + "\nCambio actual de la bicicleta: " + bicicleta.cambio_actual);
                Console.ResetColor();
                Console.Write("\n\nSeleccione una de las siguientes opciones:\n1. Acelerar Bicicleta\n2. Frenar Bicicleta\n3. Subir cambio.\n4. Bajar cambio.\n5. Parar Bicicleta\n6. Salir del programa.");
                Console.WriteLine();
                opcion = Byte.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: acelerar(); break;
                    case 2: frenar(); break;
                    case 3: subir(); break;
                    case 4: bajar(); break;
                    case 5: parar(); break;
                    case 6:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nGracias por utilizar el programa.");
                        Console.ResetColor();
                    break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nSeleccione una de las opciones disponibles.");
                        Console.ResetColor();
                        break;
                }


            } while (opcion != 6);


            void acelerar()
            {
                Console.WriteLine("Ingrese la velocidad hasta la cual desea acelerar.");
                vel_objetivo = Byte.Parse(Console.ReadLine());
                bicicleta.acelerar(vel_objetivo);
            }

            void frenar()
            {
                Console.WriteLine("Ingrese la velocidad hasta la que quiere frenar.");
                vel_objetivo = Byte.Parse(Console.ReadLine());
                bicicleta.frenar(vel_objetivo);
            }

            void subir()
            {
                if (bicicleta.subir_Cambio())
                {
                    Console.WriteLine("El cambio ha subido. En este momento esta en el cambio " + bicicleta.cambio_actual);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No ha sido posible subir el cambio ya que se encuentra en el " + bicicleta.cambio_actual);
                    Console.ResetColor();
                }
            }

            void bajar()
            {
                if (bicicleta.bajar_Cambio())
                {
                    Console.WriteLine("El cambio ha bajado. En este momento esta en el cambio " + bicicleta.cambio_actual);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nNo ha sido posible bajar el cambio ya que se encuentra en primera");
                    Console.ResetColor();
                }
            }

            void parar()
            {
                bicicleta.parar();
            }


        }
        catch (Exception)
		{
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nOcurrio un error inesperado.");
            Console.ResetColor();
		}

    }
}