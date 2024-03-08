namespace NetTaller1_CARG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "1- Mayor y menor de 3 números. " +
                "\n2- Imprimir números del 1 al 50. " +
                "\n3- El buen vestir, reporte contable. " +
                "\n4- Número primos.\n" +
                "\nIngrese la opcion que desea: ");
            int opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    int A = 0;
                    int B = 0;
                    int C = 0;
                    do
                    {
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("Ingrese un numero:");
                        A = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Ingrese otro numero:");
                        B = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Ingrese otro numero:");
                        C = Convert.ToInt32(Console.ReadLine());

                        if (A == B || A == C || B == C)
                        {
                            Console.WriteLine("No pueden haber números iguales");
                        }
                    } while (A == B || A == C || B == C);


                    int mayorNumero = A;

                    if (B > mayorNumero)
                    {
                        mayorNumero = B;
                    }
                    if (C > mayorNumero)
                    {
                        mayorNumero = C;
                    }

                    int menorNumero = A;

                    if (B < menorNumero)
                    {
                        menorNumero = B;
                    }
                    if (C < menorNumero)
                    {
                        menorNumero = C;
                    }

                    int medio = A + B + C;
                    medio = medio - mayorNumero - menorNumero;

                    Console.WriteLine($"El número más alto es {mayorNumero}");
                    Console.WriteLine($"El número del medio es {medio}");
                    Console.WriteLine($"El número más bajo es {menorNumero}");
                    break;

                case 2:
                    for (int i = 1; i <= 50; i++)
                    {
                        if (i == 1)
                        {
                            Console.WriteLine("-------------------------");
                            Console.WriteLine(i);
                        }
                        else if (i != 25)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;

                case 3:
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Ingrese la cantidad de empleados:");
                    int cantidadEmpleados = int.Parse(Console.ReadLine());

                    double sueldosTotal = 0.0;
                    double descuentosTotal = 0.0;
                    int j;
                    for (j = 1; j <= cantidadEmpleados; j++)
                    {
                        double descuentoRenta = 0.0;
                        double descuentoAFP = 0.0;
                        double descuentoISSS = 0.0;
                        double descuentoEmpleado = 0.0;
                        double sueldoNeto = 0.0;

                        Console.WriteLine($"\nIngrese el sueldo base del empleado {j}:");
                        double sueldoBase = double.Parse(Console.ReadLine());


                        descuentoRenta = sueldoBase * 0.10;
                        descuentoAFP = sueldoBase * 0.05;
                        descuentoISSS = sueldoBase * 0.04;
                        descuentoEmpleado = descuentoRenta + descuentoAFP + descuentoISSS;
                        sueldoNeto = sueldoBase - descuentoEmpleado;

                        descuentosTotal += descuentoEmpleado;
                        sueldosTotal += sueldoNeto;

                        Console.WriteLine($"Descuento de Renta: ${descuentoRenta}");
                        Console.WriteLine($"Descuento de AFP Confía: ${descuentoAFP}");
                        Console.WriteLine($"Descuento de Seguro Social ISSS: ${descuentoISSS}");
                        Console.WriteLine($"Descuento neto del empleado {j}: ${descuentoEmpleado}");
                        Console.WriteLine($"Sueldo neto del empleado: ${sueldoNeto}");
                    }
                    Console.WriteLine($"\n---------------------REPORTE CONTABLE---------------------");
                    Console.WriteLine($"Total de descuentos de los {cantidadEmpleados} empleados: ${descuentosTotal}");
                    Console.WriteLine($"Total de sueldos de los {cantidadEmpleados} empleados: ${sueldosTotal}");
                    break;

                case 4:
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("Ingrese la cantidad de números primos que desea:");
                    int cantidadNumeros = int.Parse(Console.ReadLine());
                    Console.WriteLine("------------------------------------------------");


                    int numero = 2;
                    int repeticiones = 0;
                    while (repeticiones < cantidadNumeros)
                    {
                        int contador = 0;
                        for (int k = 1; k <= numero; k++)
                        {
                            if (numero % k == 0)
                            {
                                contador++;
                            }
                        }

                        if (contador <= 2)
                        {
                            Console.WriteLine(numero);
                            repeticiones++;
                        }
                        numero++;
                    }
                    break;
            }
        }
    }
}
