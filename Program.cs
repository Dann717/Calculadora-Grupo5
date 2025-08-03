using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bienvenido a la Calculadora");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");
        Console.Write("Seleccione una opción: ");

        int opcion = int.Parse(Console.ReadLine());

<<<<<<< HEAD
=======
        if (opcion == 1)
        {
            Sumar();
        }
        else if (opcion == 2)
        {
            Restar();
        }

        // TODO: Implementar funciones de suma, resta, multiplicación, división
    }
    static void Sumar()
    {
>>>>>>> main
        Console.Write("Ingrese el primer número: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        double resultado = 0;

        switch (opcion)
        {
            case 1:
                resultado = Sumar(num1, num2);
                break;
            case 2:
                Console.WriteLine("La operación de Resta aún no está implementada.");
                break;
            case 3:
                resultado = Multiplicar(num1, num2);
                break;
            case 4:
                Console.WriteLine("La operación de División aún no está implementada.");
                break;
            default:
                Console.WriteLine("Opción no válida.");
                return;
        }

        Console.WriteLine($"El resultado es: {resultado}");
    }
        static void Restar()
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        double num2 = double.Parse(Console.ReadLine());
        double resultado = num1 - num2;
        Console.WriteLine($"El resultado de la resta es: {resultado}");
    }

    static double Sumar(double a, double b)
    {
        return a + b;
    }

    static double Multiplicar(double a, double b)
    {
        return a * b;
    }
}