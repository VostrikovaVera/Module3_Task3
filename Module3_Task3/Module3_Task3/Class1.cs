using System;

namespace Module3_Task3
{
    public class Class1
    {
        public Action<bool> ShowHandler { get; set; }

        public int Pow(int x, int y)
        {
            return x * y;
        }
    }
}
