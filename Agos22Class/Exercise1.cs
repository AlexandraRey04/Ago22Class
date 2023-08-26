namespace Agos22Class
{
    public class Exercise1
    {
        public static void ExecuteExercise()
        {
            Console.WriteLine("Conversión de centímetros a otras unidades de medida");

            Console.Write("Ingresa la longitud en centímetros: ");
            double centimetros = Convert.ToDouble(Console.ReadLine());

            double yardas = centimetros / 91.44;  // 1 yarda = 91.44 centímetros
            double metros = centimetros / 100;     // 1 metro = 100 centímetros
            double pies = centimetros / 30.48;     // 1 pie = 30.48 centímetros
            double pulgadas = centimetros / 2.54;  // 1 pulgada = 2.54 centímetros

            Console.WriteLine("Longitud en yardas:" + yardas);
            Console.WriteLine("Longitud en metros:" + metros);
            Console.WriteLine("Longitud en pies:" + pies);
            Console.WriteLine("Longitud en pulgadas:" + pulgadas);
        }

        public static void ExecuteExercise2()
        {
            Console.WriteLine("Verificación de divisibilidad");

            Console.Write("Ingresa el primer número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingresa el segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num2 % num1 == 0)
            {
                Console.WriteLine("El segundo número es divisible por el primero.");
            }
            else
            {
                Console.WriteLine("El segundo número no es divisible por el primero.");
            }
        }
        public static void ExecuteExercise3()
        {
            Console.WriteLine("Cálculo del porcentaje de hombres y mujeres en un grupo");

            Console.Write("Ingrese el total de hombres: ");
            int totalHombres = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el total de mujeres: ");
            int totalMujeres = Convert.ToInt32(Console.ReadLine());

            int totalPersonas = totalHombres + totalMujeres;

            double porcentajeHombres = (double)totalHombres / totalPersonas * 100;
            double porcentajeMujeres = (double)totalMujeres / totalPersonas * 100;

            Console.WriteLine("El porcentaje de hombres: " + porcentajeHombres);
            Console.WriteLine("El porcentaje de mujeres: " + porcentajeMujeres);
        }
    }
}

