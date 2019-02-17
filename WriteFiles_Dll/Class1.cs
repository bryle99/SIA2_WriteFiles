using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace WriteFiles_Dll
{
    public class MyClass
    {

        public string GetParentDirectory() {
            Type myType = typeof(MyClass);
            string directory;
            directory = Directory.GetParent(Directory.GetCurrentDirectory()).ToString();
            directory = Directory.GetParent(directory).ToString();
            directory = Directory.GetParent(directory).ToString();
            directory += "\\" + myType.Namespace;

            return directory;
        }

        public string GetDirectory() {
            //string[] files = Directory.GetFiles(ReturnCurrentDirectory());
            //string[] files = Directory.GetDirectories(@"C:\Users\wabzs\source\repos\", "WriteFiles_Dll.dll", SearchOption.AllDirectories);
            //string[] files = Directory.GetFiles(@"C:\Users\wabzs\source\repos\WriteFiles_Dll\bin\Debug\netstandard2.0");
            string[] dirs = Directory.GetFiles(GetParentDirectory(), "*.dll", SearchOption.AllDirectories);
            string ret = "";
            foreach (string dir in dirs) {
                if (dir.Contains("bin")) {
                    ret = dir;
                    ret = Directory.GetParent(ret).ToString();
                }
            }
            //Type myType = typeof(MyClass);

            return ret;
        }

        public void DisplayDirectory() {
            Console.WriteLine(GetDirectory());
        }

        public void WriteFiles() {
            string[] files = Directory.GetFiles(GetDirectory(), "*.txt", SearchOption.AllDirectories);
            string message = "This has been written by a C# dll";
            foreach (string file in files) {
                Console.WriteLine(file + "  Has been written!");
                File.WriteAllText(file, message);
            }
        }
    }
}
