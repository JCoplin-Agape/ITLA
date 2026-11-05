Console.WriteLine("===== Calculadora =====");
Console.WriteLine("1. Suma");
Console.WriteLine("2. Resta");
Console.WriteLine("3. Multiplicacion");
Console.WriteLine("4. Division");
Console.WriteLine("==============================");

Console.Write("Elige una opcion (1-4): ");
int opcion = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingresa el primer numero: ");
double numero1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingresa el segundo numero: ");
double numero2 = Convert.ToDouble(Console.ReadLine());

double resultado = 0;
bool operacionValida = true;

if (opcion >= 1 && opcion <= 4)
{
    switch (opcion)
    {
        case 1:
            resultado = numero1 + numero2;
            Console.WriteLine("El resultado es: " + resultado);
            break;

        case 2:
            resultado = numero1 - numero2;
            Console.WriteLine("El resultado es: " + resultado);
            break;

        case 3:
            resultado = numero1 * numero2;
            Console.WriteLine("El resultado es: " + resultado);
            break;

        case 4:
            if (numero2 == 0)
            {
                Console.WriteLine("Yo no sabia que se divide entre cero");
            }
            else
            {
                resultado = numero1 / numero2;
                Console.WriteLine("El resultado es: " + resultado);
            }
            break;
    }
}
else
{
    operacionValida = false;
    Console.WriteLine("Opcion no valida, elige entre 1 y 4.");
}

if (operacionValida == false)
{
    Console.WriteLine("Programa finalizado sin calcular");
}

Console.WriteLine("Presiona Enter para salir...");
Console.ReadLine();
