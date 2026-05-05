//juego del ahorcado

try
{
    Console.WriteLine("Programa 3: Ahorcado");
    Console.WriteLine("");
    Console.WriteLine("Bienvenido al juego del Ahorcado.");
    Console.WriteLine("");
    string[] palabras = { "programacion", "casa", "gato","televicion", "pneumonoultramicroscopicsilicovolcanoconiosis", "supercalifragilisticoespialidoso" };
    Random random = new Random();
    for (int i = 0; i < palabras.Length; i++)
    {
        int indice = random.Next(palabras.Length);
        string palabraSecreta = palabras[indice];
        char[] palabraAdivinada = new char[palabraSecreta.Length];
        for (int j = 0; j < palabraAdivinada.Length; j++)
        {
            palabraAdivinada[j] = '_';
        }
        int intentosRestantes = 7;
        bool juegoTerminado = false;
        while (!juegoTerminado)
        {
            Console.WriteLine($"Palabra: {new string(palabraAdivinada)}");
            Console.WriteLine($"Intentos restantes: {intentosRestantes}");
            Console.Write("Ingresa una letra: ");
            char letra = Console.ReadLine()[0];
            if (palabraSecreta.Contains(letra))
            {
                for (int k = 0; k < palabraSecreta.Length; k++)
                {
                    if (palabraSecreta[k] == letra)
                    {
                        palabraAdivinada[k] = letra;
                    }
                }
            }
            else
            {
                intentosRestantes--;
            }
            if (new string(palabraAdivinada) == palabraSecreta)
            {
                Console.WriteLine("¡Felicidades! Has adivinado la palabra: " + palabraSecreta);
                juegoTerminado = true;
                break;
            }
            else if (intentosRestantes == 0)
            {
                Console.WriteLine("Te qyedaste sin intentos, La palabra era:" + palabraSecreta);
                juegoTerminado = true;
                break;
            }
        }
    }
}
catch (System.IndexOutOfRangeException)
{
    Console.WriteLine("La letra que acabas de ingresar no funciona.");
}