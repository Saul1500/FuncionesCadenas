using System;

using System;

class EJERCICIO1
{
    static void Main()
    {
        bool Continuar = true;
        while (Continuar)
        {
            Console.WriteLine("Ingrese una cadena de caracteres: ");
            string CadenaDeCaracteres = Console.ReadLine();

            Console.WriteLine("");

            if (CadenaDeCaracteres.Length < 25)
            {
                Console.WriteLine("Escriba (Izquierda o Derecha) para rellenar los espacios con el símbolo '$': ");
                string LadoParaRellenar = Console.ReadLine().ToLower();

                Console.WriteLine("");

                if (LadoParaRellenar == "izquierda")
                {
                    string resultado = CadenaDeCaracteres.PadLeft(25, '$');
                    Console.WriteLine($"Cadena rellenada a la izquierda es: " + resultado);

                    Console.WriteLine("");
                }
                else if (LadoParaRellenar == "derecha")
                {
                    string resultado = CadenaDeCaracteres.PadRight(25, '$');
                    Console.WriteLine($"Cadena rellenada a la derecha es: " + resultado);

                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Dirreccion Incorrecta. !Escriba Izquierda o Derecha Correctamente!");
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("La cadena cumple con los 25 o más caracteres");

                Console.WriteLine("");
            }

            Console.WriteLine("¿Desea continuar? (S/N): ");
            Console.WriteLine("");
            string Si = Console.ReadLine();
            Continuar = Si.ToLower() == "s";
        }
    }
}

//EJERCICIO 1
//ALUMNO: JOSE SAUL SIBRIAN SERRANO







