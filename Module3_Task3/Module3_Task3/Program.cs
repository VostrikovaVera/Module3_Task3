using System;

namespace Module3_Task3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var class1 = new Class1();
            var class2 = new Class2();
            var program = new Program();

            class1.ShowHandler = program.Show;
            class1.ShowHandler(class2.Calc(class2.PowHandler, 7, 8).Invoke(8));
        }

        public void Show(bool isTrue)
        {
            Console.WriteLine(isTrue);
        }
    }
}
