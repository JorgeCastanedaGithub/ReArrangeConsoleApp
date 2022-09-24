using System;

namespace ReArrangeConsoleApp
{
    class Program
    {
        static int i = 0;
        static void Main(string[] args)
        {
            string[] names = readArrayNames();
            string[] order = readArrayOrder();
            string[] newNames = readArrayReArrange(names, order);
            foreach (string s in newNames)
                Console.WriteLine(s);
            Console.ReadLine();
        }

        public static string[] readArrayNames()
        {
            string[] array1 = new string[1];
            try
            {
                Console.WriteLine("Size of array: ");
                i = Convert.ToInt32(Console.ReadLine());
                array1 = new string[i];
                string name = string.Empty;
                Console.WriteLine("Names: ");
                for (int j = 0; j < i; j++)
                {
                    name = Console.ReadLine();
                    array1.SetValue(name, j);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return array1;
        }

        public static string[] readArrayOrder()
        {
            string[] array2 = new string[1];
            try
            {
                Console.WriteLine("Order of array: ");
                array2 = new string[i];
                string name = string.Empty;
                for (int j = 0; j < i; j++)
                {
                    name = Console.ReadLine();
                    array2.SetValue(name, j);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return array2;
        }

        public static string[] readArrayReArrange(string[] arrayNames, string[] arrayOrder)
        {
            Console.WriteLine("ReArrange arrays");
            string[] newArray = new string[i];
            try
            {
                for (int j = 0; j < i; j++)
                {
                    string name = arrayNames[j];
                    int order = Convert.ToInt32(arrayOrder[j]);
                    newArray.SetValue(name, order-1);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return newArray;
        }
    }
}
