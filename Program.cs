using System.Timers;

namespace MesesArreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un numero");
            string[] meses = new string[12];

            meses[0] = "Enero";
            meses[1] = "Febrero";
            meses[2] = "Marzo";
            meses[3] = "Abril";
            meses[4] = "Mayo";
            meses[5] = "Junio";
            meses[6] = "Julio";
            meses[7] = "Agosto";
            meses[8] = "Septiembre";
            meses[9] = "Octubre";
            meses[10] = "Noviembre";
            meses[11] = "Diciembre";

            string imput = Console.ReadLine();
            int.TryParse(imput, out int result);
            if (result > 0 && result <= 12)
                }
         Console.WriteLine ("MesesArreglos[result-1]");
            }
            else
            {
         Console.WriteLine("El dato es incorrecto");

}
    }
}
