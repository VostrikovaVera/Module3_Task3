using System;

namespace Module3_Task3
{
    public class Class2
    {
        private Predicate<int> _resultHandler;
        private int _powResult;

        public Func<int, int, int> PowHandler { get; set; }

        public Predicate<int> Calc(Func<int, int, int> powHandler, int x, int y)
        {
            var class1 = new Class1();
            var class2 = new Class2();

            powHandler = class1.Pow;
            _powResult = powHandler(x, y);

            return class2._resultHandler = Result;
        }

        public bool Result(int number)
        {
            var class1 = new Class1();
            var class2 = new Class2();
            class2.PowHandler = class1.Pow;

            var gelegatePowResult = class2.PowHandler.Invoke(7, 8);
            var remainderOfDivision = gelegatePowResult % number;

            return remainderOfDivision == 0;
        }
    }
}
