using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica01_Meses
{
    class Program
    {
        static void Main()
        {
            string[] mes = new string[] { "ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE" };
            int i = 0;
            int m;
            do
            {
                Console.WriteLine("Ingresa Un Numero: ");
                m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("El Nombre Del Mes Es:" + mes[m]);
                i = i + 1;
            } while (i < mes.Length);

        }
    }
}
