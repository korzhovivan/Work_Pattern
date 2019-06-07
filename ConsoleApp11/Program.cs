using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {

            Camera cam1 = new Camera();
            Camera cam2 = new Camera();
            Camera cam3 = new Camera();
           

            Camera.Add(101, cam1);
            Console.WriteLine(Camera.counter);
            Camera.Add(102, cam2);
            Console.WriteLine(Camera.counter);
            Camera.Add(103, cam3);
            Console.WriteLine(Camera.counter);
            

            Console.ReadKey();
                
        }
    }
}
