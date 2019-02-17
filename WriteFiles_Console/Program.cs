using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WriteFiles_Dll;

namespace WriteFiles_Console
{
    class Program
    {   
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            Console.WriteLine("Current Directory of DLL: " + obj.GetParentDirectory());
            obj.DisplayDirectory();
            obj.WriteFiles();
            Console.Read();
        }
    }
}
