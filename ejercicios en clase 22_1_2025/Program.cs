using System;

class Program
{
    static void Main()
    {
        // Llamamos a la función para jugar
        AdivinarNumero();
    }

    // Función para generar el número aleatorio entre 1 y 100
    public static int GenerarNumero()
    {
        Random random = new Random();
        return random.Next(1, 101); // Número aleatorio entre 1 y 100
    }

    // Función adivinar el número
    public static void AdivinarNumero()
    {
        int numero_secreto = GenerarNumero();  // Generar el número aleatorio
        int intento;
        bool adivinar = false;

        while (!adivinar)
        {
            // Pedimos al usuario que ingrese un número
            Console.Write("Introduce un número: ");
            intento = int.Parse(Console.ReadLine()); // Convertir la entrada del usuario a int

            if (intento == numero_secreto)
            {
                Console.WriteLine("¡Felicidades! Adivinaste el número.");
                adivinar = true; // Si adivina el número, terminamos el juego
            }
            else if (intento < numero_secreto)
            {
                Console.WriteLine("El número es mayor. Intenta de nuevo.");
            }
            else
            {
                Console.WriteLine("El número es menor. Intenta de nuevo.");
            }
        }
    }
}
