using System;

namespace ApplicationWithOverflow
{
    class Program
    {
        class A
        {
            public int ovflw1()
            {
                unchecked
                {
                    int i = 1834567890 + 1834567890;
                    return i;
                }
            }

            public int ovflw2()
            {
                int i = 1834567890;
                i += i;
                return i;
            }

            public int ovflw3()
            {
                int i = 1834567890;
                var j = i + i;
                return j;
            }

            public int ovflw4()
            {
                int i = -1834567890;
                int j = 1834567890;
                var k = i - j;
                return k;
            }

            public int ovflw5(int i)
            {
                if (i > 1834567890)
                {
                    return i + i;
                }
                return 0;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
