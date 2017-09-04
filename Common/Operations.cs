namespace Common
{
    public class Operations
    {
        static public bool IsPrime(int value)
        {
            if (value < 2)
                return false;
            for (int i = 2; i < value; i++)
                if (value % i == 0)
                    return false;
            return true;
        }

        static public int Add(int a, int b)
        {
            return a+b;
        }

        static public int Sub(int a, int b)
        {
            return a-b;
        }

        static public int Mul(int a, int b)
        {
            return a*b;
        }
    }
}
