namespace Agos22Class
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Menu para seleccionar que programa ejecutar 

            int ejercicio = 3;
            switch (ejercicio)
            {
                case 1:
                    
                    Exercise1.ExecuteExercise();

                    break;
                case 2:
                    Console.WriteLine("Exersice2");
                    break;
                case 3:
                    Console.WriteLine("Exersice3");

                    break;



            }
        }

    }

}
