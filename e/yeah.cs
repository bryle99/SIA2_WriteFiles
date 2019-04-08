using System;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using Yo.Interface;
using System.Reflection;
using System.IO;

namespace test
{
    class program
    {
        static void Main(string[] args)
        {

            var pluginFiles = Directory.GetFiles("//home//chayanne//Desktop//e//", "*.dll");

            var loaders = (
                from file in pluginFiles
                let asm = Assembly.LoadFile(file)
                from type in asm.GetTypes()
                where typeof(ILoader).IsAssignableFrom(type)
                select (ILoader)Activator.CreateInstance(type)
            ).ToArray();

            foreach(var loader in loaders)
            {
                Console.WriteLine("{0}",loader.hello());
            }
            Console.ReadLine();
        }
    }
}
