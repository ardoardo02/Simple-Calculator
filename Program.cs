using System;

namespace SkilvulLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the action to be performed");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Substraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division");
            Console.WriteLine();

            int menu = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 1st input");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd input");
            float num2 = float.Parse(Console.ReadLine());

            float hasil;
            hasil = (menu == 1) ? Tambah(num1, num2) :
                    (menu == 2) ? Kurang(num1, num2) :
                    (menu == 3) ? Kali(num1, num2) :
                    (menu == 4) ? Bagi(num1, num2) :
                    0.0f;

            if (hasil == 0.0f)
                Console.WriteLine("Invalid input");
            else
                Console.WriteLine($"The result is {hasil}");
        }

        static float Tambah(float a, float b)
        {
            return a + b;
        }
        static float Kurang(float a, float b)
        {
            return a - b;
        }
        static float Kali(float a, float b)
        {
            return a * b;
        }
        static float Bagi(float a, float b)
        {
            return a / b;
        }
    }
}