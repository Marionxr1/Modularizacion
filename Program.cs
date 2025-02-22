using System;

class Programa2
{
    static void Main()
    {
        int opcion;

        // Bucle para que el programa siga mostrando el menú hasta que el usuario elija salir
        do
        {
            // Mostrar el menú
            Console.Clear();
            Console.WriteLine("------ Menú de Opciones ------");
            Console.WriteLine("1. Calculadora Básica");
            Console.WriteLine("2. Validacion de contraseña");
            Console.WriteLine("3. Numeros primos");
            Console.WriteLine("4. Suma de numeros pares");
            Console.WriteLine("5. Conversion de temperatura");
            Console.WriteLine("6. Contador de vocales");
            Console.WriteLine("7. Cálculo de factorial");
            Console.WriteLine("8. Juego de adivinanza");
            Console.WriteLine("9. Paso por referencia");
            Console.WriteLine("10. Tabla de multiplicar");
            Console.WriteLine("11. Cerrar programa");
            Console.Write("Elige una opción (1-10): ");
            opcion = int.Parse(Console.ReadLine());

            // Ejecutar el código dependiendo de la opción seleccionada
            switch (opcion)
            {
                case 1:
                    CalculadoraBasica();
                    break;
                case 2:
                    ValidacionContraseña();
                    break;
                case 3:
                    NumerosPrimos();
                    break;
                case 4:
                    SumaPares();
                    break;
                case 5:
                    ConverTemperatura();
                    break;
                case 6:
                    ContadorVocales();
                    break;
                case 7:
                    CalculoFactorial();
                    break;
                case 8:
                    Adivinanza();
                    break;
                case 9:
                    Referencia();
                    break;
                case 10:
                    TablaMulti();
                    break;
                case 11:
                    Console.WriteLine("¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción no válida, por favor elige una opción entre 1 y 11.");
                    break;
            }

            // Esperar a que el usuario presione una tecla antes de volver a mostrar el menú
            if (opcion != 11)
            {
                Console.WriteLine("\nPresiona cualquier tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 11); // El bucle se repite hasta que el usuario elige salir (opción 11)
    }

    static void CalculadoraBasica()
    {
            double num1, num2;
            int opcion;

            // Pedir al usuario los números e intentar convertirlos a números válidos
            Console.Write("Ingresa el primer número: ");
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("Por favor ingresa un número válido: ");
            }

            Console.Write("Ingresa el segundo número: ");
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("Por favor ingresa un número válido: ");
            }

            // Mostrar el menú de operaciones
            Console.Clear();
            Console.WriteLine("----- Menú de Operaciones -----");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.Write("Elige una operación (1-4): ");

            // Obtener la opción de operación del usuario
            while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 4)
            {
                Console.Write("Por favor elige una opción válida (1-4): ");
            }

            // Realizar la operación seleccionada
            double resultado = 0;
            switch (opcion)
            {
                case 1:
                    resultado = Sumar(num1, num2);
                    break;
                case 2:
                    resultado = Restar(num1, num2);
                    break;
                case 3:
                    resultado = Multiplicar(num1, num2);
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("No se puede dividir por cero.");
                        return;
                    }
                    resultado = Dividir(num1, num2);
                    break;
            }

            // Mostrar el resultado
            Console.WriteLine($"El resultado de la operación es: {resultado}");
        

        // Función para sumar
        static double Sumar(double a, double b)
        {
            return a + b;
        }

        // Función para restar
        static double Restar(double a, double b)
        {
            return a - b;
        }

        // Función para multiplicar
        static double Multiplicar(double a, double b)
        {
            return a * b;
        }

        // Función para dividir
        static double Dividir(double a, double b)
        {
            return a / b;
        }
    }


    static void ValidacionContraseña()
    {
        string contraseña;

        // Ciclo do-while para seguir pidiendo la contraseña hasta que sea correcta
        do
        {
            Console.Write("Introduce la contraseña: ");
            contraseña = Console.ReadLine();

            // Verificar si la contraseña es correcta
            if (contraseña == "1234")
            {
                Console.WriteLine("Acceso concedido.");
                break;  // Si la contraseña es correcta, salimos del ciclo
            }
            else
            {
                Console.WriteLine("Contraseña incorrecta, intenta nuevamente.");
            }

        } while (true);  // El ciclo sigue hasta que la contraseña sea correcta
    }

    static void NumerosPrimos()
    {
        int numero;

        // Pedir al usuario un número
        Console.Write("Ingresa un número para verificar si es primo: ");
        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.Write("Por favor ingresa un número válido: ");
        }

        // Verificar si el número es primo usando la función IsPrimo
        if (EsPrimo(numero))
        {
            Console.WriteLine($"El número {numero} es primo.");
        }
        else
        {
            Console.WriteLine($"El número {numero} no es primo.");
        }
    }

    //verificar si el número es primo
    static bool EsPrimo(int n)
    {
        // Casos especiales
        if (n <= 1) return false;  // Los números menores o iguales a 1 no son primos
        if (n == 2) return true;   // El 2 es el único número primo par

        // Verificar divisores de 2 hasta la raíz cuadrada del número
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) // Si el número es divisible por algún número entre 2 y su raíz cuadrada, no es primo
            {
                return false;
            }
        }

        return true; // Si no se encontró un divisor, el número es primo
    }

    static void SumaPares()
    {
        int numero;
        int sumaPares = 0;

        // Ciclo while que pide números hasta que se ingresa 0
        while (true)
        {
            Console.Write("Ingresa un número entero (0 para terminar): ");
            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("Por favor ingresa un número válido: ");
            }

            // Si el número es 0, terminamos el ciclo
            if (numero == 0)
            {
                break;
            }

            // Si el número es par, lo sumamos
            if (numero % 2 == 0)
            {
                sumaPares += numero;
            }
        }

        // Mostrar la suma de los números pares ingresados
        Console.WriteLine($"La suma de los números pares ingresados es: {sumaPares}");
    }

    static void ConverTemperatura()
    {
        int opcion;
        double temperatura;

        // Mostrar el menú de opciones
        Console.WriteLine("------ Conversor de Temperaturas ------");
        Console.WriteLine("1. Convertir de Celsius a Fahrenheit");
        Console.WriteLine("2. Convertir de Fahrenheit a Celsius");
        Console.Write("Elige una opción (1-2): ");

        // Validar la opción seleccionada
        while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 2)
        {
            Console.Write("Por favor, ingresa una opción válida (1-2): ");
        }

        // Pedir la temperatura a convertir
        Console.Write("Ingresa la temperatura: ");
        while (!double.TryParse(Console.ReadLine(), out temperatura))
        {
            Console.Write("Por favor ingresa un valor numérico válido para la temperatura: ");
        }

        // Convertir y mostrar el resultado dependiendo de la opción elegida
        if (opcion == 1)
        {
            double fahrenheit = CelsiusAFahrenheit(temperatura);
            Console.WriteLine($"{temperatura} grados Celsius son {fahrenheit} grados Fahrenheit.");
        }
        else if (opcion == 2)
        {
            double celsius = FahrenheitACelsius(temperatura);
            Console.WriteLine($"{temperatura} grados Fahrenheit son {celsius} grados Celsius.");
        }
    }

    //convertir Celsius a Fahrenheit
    static double CelsiusAFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    //convertir Fahrenheit a Celsius
    static double FahrenheitACelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }


    static void ContadorVocales()
    {
        string frase;

        // Pedir al usuario una frase
        Console.Write("Ingresa una frase: ");
        frase = Console.ReadLine();

        // Llamar a la función para contar las vocales
        int cantidadVocales = ContarVocales(frase);

        // Mostrar el número de vocales en la frase
        Console.WriteLine($"La frase ingresada tiene {cantidadVocales} vocales.");
    }

    //contar las vocales en una cadena de texto
    static int ContarVocales(string texto)
    {
        int contador = 0;
        // Convertimos el texto a minúsculas para no distinguir entre mayúsculas y minúsculas
        texto = texto.ToLower();

        // Recorremos cada carácter del texto
        foreach (char c in texto)
        {
            // Verificamos si el carácter es una vocal
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                contador++; // Si es una vocal, incrementamos el contador
            }
        }

        return contador;
    }

    static void CalculoFactorial()
    {
        int numero;

        // Pedir al usuario un número
        Console.Write("Ingresa un número entero para calcular su factorial: ");
        while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
        {
            Console.Write("Por favor ingresa un número válido y no negativo: ");
        }

        // Llamar a la función para calcular el factorial
        long factorial = CalcularFactorial(numero);

        // Mostrar el factorial calculado
        Console.WriteLine($"El factorial de {numero} es: {factorial}");
    }

    // calcular el factorial de un número
    static long CalcularFactorial(int n)
    {
        long resultado = 1;

        // Usamos un ciclo for para calcular el factorial
        for (int i = 1; i <= n; i++)
        {
            resultado *= i;  // Multiplicamos el resultado por cada número
        }

        return resultado;
    }

    static void Adivinanza()
    {
        // Generar un número aleatorio entre 1 y 100
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101);  // Genera un número entre 1 y 100
        int intento;

        // Informar al usuario que debe adivinar el número
        Console.WriteLine("¡Bienvenido al juego de adivinanza!");
        Console.WriteLine("He generado un número aleatorio entre 1 y 100.");
        Console.WriteLine("Intenta adivinarlo.");

        do
        {
            // Pedir al usuario un número
            Console.Write("Ingresa tu intento: ");
            while (!int.TryParse(Console.ReadLine(), out intento) || intento < 1 || intento > 100)
            {
                Console.Write("Por favor ingresa un número válido entre 1 y 100: ");
            }

            // Comparar el intento con el número secreto y dar pistas
            if (intento > numeroSecreto)
            {
                Console.WriteLine("Demasiado alto. Intenta de nuevo.");
            }
            else if (intento < numeroSecreto)
            {
                Console.WriteLine("Demasiado bajo. Intenta de nuevo.");
            }
            else
            {
                Console.WriteLine($"¡Felicidades! Adivinaste el número {numeroSecreto}.");
            }

        } while (intento != numeroSecreto);  // El ciclo sigue hasta que el usuario adivine el número
    }

    static void Referencia()
    {
        int num1, num2;

        // Pedir al usuario dos números
        Console.Write("Ingresa el primer número: ");
        while (!int.TryParse(Console.ReadLine(), out num1))
        {
            Console.Write("Por favor ingresa un número válido: ");
        }

        Console.Write("Ingresa el segundo número: ");
        while (!int.TryParse(Console.ReadLine(), out num2))
        {
            Console.Write("Por favor ingresa un número válido: ");
        }

        // Mostrar los valores originales
        Console.WriteLine($"Valores originales: num1 = {num1}, num2 = {num2}");

        // Llamar a la función para intercambiar los valores
        Intercambiar(ref num1, ref num2);

        // Mostrar los valores intercambiados
        Console.WriteLine($"Valores después de intercambiar: num1 = {num1}, num2 = {num2}");
    }

    // Función que intercambia dos números por referencia
    static void Intercambiar(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
    static void TablaMulti()
    {
        int numero;

        // Pedir al usuario un número
        Console.Write("Ingresa un número para ver su tabla de multiplicar: ");
        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.Write("Por favor ingresa un número válido: ");
        }

        // Llamar a la función para generar la tabla de multiplicar
        int[] tabla = GenerarTablaMultiplicar(numero);

        // Llamar a la función para mostrar la tabla de multiplicar
        MostrarTablaMultiplicar(tabla);
    }

    // Función para generar la tabla de multiplicar de un número
    static int[] GenerarTablaMultiplicar(int num)
    {
        int[] tabla = new int[10];

        // Generar los resultados de la tabla de multiplicar del 1 al 10
        for (int i = 1; i <= 10; i++)
        {
            tabla[i - 1] = num * i;
        }

        return tabla;
    }

    // Función para mostrar la tabla de multiplicar
    static void MostrarTablaMultiplicar(int[] tabla)
    {
        Console.WriteLine("\nTabla de multiplicar:");
        for (int i = 0; i < tabla.Length; i++)
        {
            Console.WriteLine($"{i + 1} * {tabla[i] / (i + 1)} = {tabla[i]}");
        }
    }
}
