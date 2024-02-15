using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            Persona persona2 = new Persona("Иванов");
            Persona persona3 = new Persona("Петров", "Петр");
            Persona persona4 = new Persona("Сидоров", "Сидор", "Сидорович");

            persona1.Show();
            persona2.Show();
            persona3.Show();
            persona4.Show();

            Console.ReadKey();
        }
}
