using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class Employe
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public Employe GetClone() { return (Employe) this.MemberwiseClone(); }
    }


    class Prototype
    {
        static void Main(string[] args)
        {
            Employe emp1 = new Employe();
            emp1.Name = "Rustam";
            emp1.Department = "IT";

            Employe emp2 = emp1.GetClone();
            emp2.Name = "Resul";

            Console.WriteLine("Name: " + emp1.Name + " , Department : " + emp1.Department);
            Console.WriteLine("Name: " + emp2.Name + " , Department : " + emp2.Department);

        }
    }

}
