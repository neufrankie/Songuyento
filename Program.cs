using System;

namespace PrimeNumberCheckerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao mot so nguyen duong: ");
            int number;
            if (!int.TryParse(Console.ReadLine(), out number) || number <= 1)
            {
                Console.WriteLine("So ma ban vua nhap khong hop le. Vui long thu lai voi mot so nguyen duong lon hon 1!");
                return;
            }

            if (IsPrime(number))
            {
                Console.WriteLine(number + " la so nguyen to.");
            }
            else
            {
                Console.WriteLine(number + " khong phai la so nguyen to.");
            }
        }

        static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;
            if (n <= 3)
                return true;
            if (n % 2 == 0 || n % 3 == 0)
                return false;
            for (int i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;
            }
            return true;
        }
    }
}
