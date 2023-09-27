using System;

class EJERCICIO3
{
    static void Main()
    {
        string Cadena = "MI MAMA ME MIMA, AMO A MI MAMA";

        string Minusculas = Cadena.ToLower();

        string[] Palabras = Minusculas.Split(' ');

        foreach (string palabra in Palabras)
        {
            string palabraFinal = palabra;
            if (palabra.Length < 3)
            {
               palabraFinal += "%";
            }
            Console.WriteLine(palabraFinal);
        }
    }
}

//EJERCICIO 3
// JOSE SAUL SIBRIAN SERRANO

