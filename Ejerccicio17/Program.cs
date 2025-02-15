using System;

class Program
{
    static int Sumar(int num1, int num2)
    {
        return num1 + num2;
    }

    static void Main(string[] args)
    {
        // Solicitar los dos números al usuario
        Console.Write("Ingrese el primer número: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo númeroo: ");
        int numero2 = int.Parse(Console.ReadLine());

        // Invocar la función y mostrar el resultado
        int resultado = Sumar(numero1, numero2);
        Console.WriteLine("La suma de los dos números es: " + resultado);
    }
}
