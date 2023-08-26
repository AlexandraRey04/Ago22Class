namespace Agos22Class
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Menu para seleccionar que programa ejecutar 

            int ejercicio = 0;
            Console.WriteLine("Seleccione el ejercio que desea realixar\n 1. Conversión\n 2. Números divisibles\n 3. Promedio población");
            ejercicio = int.Parse(Console.ReadLine());
            switch (ejercicio)
            {
                case 1:
                    
                    Exercise1.ExecuteExercise();
                    Console.WriteLine("Ejercicio conversión");
                    break;
                case 2:
                    Exercise1.ExecuteExercise2();
                    Console.WriteLine("Ejercicio números divisibles");
                    break;
                case 3:
                    Exercise1.ExecuteExercise3();
                    Console.WriteLine("Promedio población");
                    break;
            }
        }

    }

}
