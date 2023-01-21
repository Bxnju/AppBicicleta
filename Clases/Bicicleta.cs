using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBicicleta.Clases
{
    internal class Bicicleta
    {
        public string marca;
        public string color;
        public string material;
        public byte nro_cambios = 5;
        public char tam_marco;
       
        //Atributos de Comportamiento

        public byte cambio_actual = 1;
        public float velocidad_actual = 0;
        
        public bool subir_Cambio()
        {
            try
            {

                if (cambio_actual == nro_cambios)
                {
                    return false;
                }else
                {
                    cambio_actual++;
                    return true;
                }

            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool bajar_Cambio()
        {
            try
            {

                if (cambio_actual == 1) return false;
                else
                {
                    cambio_actual--;
                    return true;
                }

            }
            catch (Exception)
            {
                return false;
            }
        }
        public void acelerar(float vel_objetivo)
        {
            try
            {
                Console.Write("Acelerando bicicleta...");

                using (var progress = new ProgressBar())
                {
                    for (int i = 0; i <= 100; i++)
                    {
                        progress.Report((double)i / 100);
                        Thread.Sleep(60);
                    }
                }

                while (velocidad_actual < vel_objetivo)
                {
                    velocidad_actual++;
                }

                if (vel_objetivo == velocidad_actual)
                {
                    Console.WriteLine("\nLa bicicleta ha sido acelerada. Su nueva velocidad es: " + velocidad_actual);
                }
                
            }
            catch (Exception)
            {
                Console.WriteLine("Hubo un error acelerando la cicla");
            }
        }

        public void frenar(float vel_objetivo)
        {
            try
            {
                if(!(vel_objetivo < 0))
                {

                    Console.Write("Frenando bicicleta...");

                    using (var progress = new ProgressBar())
                    {
                        for (int i = 0; i <= 100; i++)
                        {
                            progress.Report((double)i / 100);
                            Thread.Sleep(20);
                        }
                    }

                    while (velocidad_actual > vel_objetivo)
                    {
                        velocidad_actual--;
                    }

                    if (vel_objetivo == velocidad_actual)
                    {
                        Console.WriteLine("\nLa bicicleta ha sido frenada. Su nueva velocidad es: " + velocidad_actual);
                    }

                }
                else
                {
                    Console.WriteLine("La velocidad a la que se puede frenar no puede estar por debajo de cero.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Hubo un error frenando la cicla");
            }
        }

        public void parar()
        {
            try
            {
                if (velocidad_actual != 0)
                {
                    Console.Write("Parando bicicleta... ");
                    velocidad_actual = 0;

                    using (var progress = new ProgressBar())
                    {
                        for (int i = 0; i <= 100; i++)
                        {
                            progress.Report((double)i / 100);
                            Thread.Sleep(20);
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("La bicicleta ha sido parada en su totalidad.");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("La bicicleta ya esta en reposo.");
                    Console.ResetColor();
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Hubo un error acelerando la cicla");
            }
        }


    }
}
