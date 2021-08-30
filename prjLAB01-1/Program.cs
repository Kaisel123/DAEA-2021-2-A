using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjLAB01_1
{
    class Program
    {
        static int Suma(int a, int b)
        {
            return a + b;
        }

        static int Resta(int a, int b)
        {
            return a - b;
        }
        static int Multiplicacion(int a, int b)
        {
            return a * b;
        }
        static String Division(int a, int b)
        {
            if (b == 0)
            {
                string rpta = "ERROR: no se pueden dividir numeros entre 0";
                return rpta;
            }
            else
            {
                return Convert.ToString(a / b);
            }

        }

        //Procedimiento que imprime la raíz cuadrada de los 10 primeros números
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raíz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }

        static void NumerosPrimos(){
            int cont = 0;
            for (int i = 2; i <= 30; i++){
                for (int j = 1; j <= i; j++){  
                    if (i % j == 0){
                        cont = cont + 1;
                    }
                }

                if (cont <= 2){
                    Console.WriteLine(i);
                }
                cont = 0;
            }
        }

        //Funcion para convertir de Fahrenheit a Celsius
        static int FarenheitACelcius(int a)
        {
            int rpta = (5 * (a - 32)) / 9;
            return rpta;
        }
        //Funcion para convertir de Celsius a Fahrenheit
        static int CelciusAFarenheit(int a)
        {
            int rpta = ((9 * a) / 5) + 32;
            return rpta;
        }

        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Resta de dos números");
                Console.WriteLine("[3] Multiplicacion de dos números");
                Console.WriteLine("[4] Division de dos números");
                Console.WriteLine("[5] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[6] Imprimir los 10 primeros numeros primos");
                Console.WriteLine("[7] Conversion de temperaturas");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Ingrese el primer número");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es {2}", c, d, Resta(c, d));
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        int e = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int f = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La multiplicacion de de {0} y {1} es {2}", e, f, Multiplicacion(e, f));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el primer número");
                        int g = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int h = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La division de {0} y {1} es {2}:", g, h, Division(g, h));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Calculando...");
                        NumerosPrimos();
                        Console.ReadKey();
                        break;
                    case "7":
                        string opcionTemperatura;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("[1] Transformar de Farenheit a celcius");
                            Console.WriteLine("[2] Transformar de Celcius a farenheit");
                            Console.WriteLine("[0] Volver al menu principal");
                            Console.WriteLine("Ingrese una opción y presione ENTER");
                            opcionTemperatura = Console.ReadLine();
                            switch (opcionTemperatura)
                            {
                                case "1":
                                    Console.WriteLine("Ingrese el numero en Farenheit para convertir a Celcius:");
                                    int i = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("La transformacion de {0} Fahrenheit a Celcius es: {1} C°", i, FarenheitACelcius(i));
                                    Console.ReadKey();
                                    break;
                                case "2":
                                    Console.WriteLine("Ingrese el numero en Celcius para convertir a Farenheit:");
                                    int j = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("La transformacion de {0} Celsius a Fahrenheit es: {1} F°", j, CelciusAFarenheit(j));
                                    Console.ReadKey();
                                    break;
                            }

                        } while (!opcionTemperatura.Equals("0"));
                        break;
                }
            } while (!opcion.Equals("0"));

        }
    }
}
