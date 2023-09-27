using System;

class EJERCICIO2
{
    static void Main()
    {
        Console.WriteLine("Ingrese la primera cadena:");
        string cadena1 = Console.ReadLine();

        Console.WriteLine("");

        Console.WriteLine("Ingrese la segunda cadena:");
        string cadena2 = Console.ReadLine();

        Console.WriteLine("");

        Console.WriteLine("*********************************************");

        Console.WriteLine("");

        int resultadoCadena1 = cadena1.CompareTo(cadena2);

        bool resultadoCadena2 = cadena1.Equals(cadena2);

        if (resultadoCadena1 == 0)
        {
            Console.WriteLine("Las cadenas son iguales CompareTo");

            Console.WriteLine("");

            Console.WriteLine("*********************************************");

        }
        else
        {
            Console.WriteLine("Las cadenas no son iguales CompareTo");

            Console.WriteLine("");

            Console.WriteLine("*********************************************");

            Console.WriteLine("");

        }

        if (resultadoCadena2)
        {
            Console.WriteLine("");

            Console.WriteLine("Las cadenas son iguales Equals");

            Console.WriteLine("");

            Console.WriteLine("*********************************************");

            Console.WriteLine("");

        }
        else
        {
            Console.WriteLine("Las cadenas no son iguales Equals");

            Console.WriteLine("");

            Console.WriteLine("*********************************************");
        }
    }
}


//EJERCICIO 2
//ALUMNO: JOSE SAUL SIBRIAN SERRANO