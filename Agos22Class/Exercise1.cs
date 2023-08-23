namespace Agos22Class
{
    public class Exercise1
    {
        public static void ExecuteExercise()
        {

            double p, r;
            double pi = 3.1416;


            Console.WriteLine("Ingrese el radio del circulo");

            double v = double.Parse(Console.ReadLine());
            r = v;
            p = (2 * pi) * r;
            Console.WriteLine("El perimetro es" + p);

        }
    }
}

