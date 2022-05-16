using System;
using System.Reflection;

namespace checkReflec
{
    class Program
    {
        static void Main(string[] args)
        {
            var getClassName = "ClassA";



            IClass classAtest = CreateInstance<IClass>(getClassName);

            classAtest.Hello();

            getClassName = "ClassB";



            IClass classBtest = CreateInstance<IClass>(getClassName);

            classBtest.Hello();


            getClassName = "ClassC";



            IClass classCtest = CreateInstance<IClass>(getClassName);

            classCtest.Hello();




            Console.WriteLine("Hello World!");
        }

        public static I CreateInstance<I>(string className) where I : class
        {
            string assemblyPath = Environment.CurrentDirectory + "\\checkReflec.dll";

            Assembly assembly;

            assembly = Assembly.LoadFrom(assemblyPath);
            Type type = assembly.GetType($"checkReflec.{className}");
            return Activator.CreateInstance(type) as I;
        }
    }
}
