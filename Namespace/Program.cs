using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryClasses;


namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryClasses.Person person = new LibraryClasses.Person()
            { FirstName = "Темирбулат", Name = "Ануар", LastName = "Жанабекович" };
            Console.WriteLine("1.   Результат: "+LibraryClasses.Information.FullName(person));
            ConstantPi pi = new ConstantPi();
            Console.WriteLine("2.   "+pi.PI+" "+pi.NAME);
        }
    }
}
