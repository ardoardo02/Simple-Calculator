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

            int menu;

            if (!int.TryParse(Console.ReadLine(), out menu) || (menu < 1 || menu > 4))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            Console.WriteLine("Enter 1st input");
            float num1;
            if (!float.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            Console.WriteLine("Enter 2nd input");
            float num2;
            if (!float.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            float hasil;
            hasil = (menu == 1) ? Tambah(num1, num2) :
                    (menu == 2) ? Kurang(num1, num2) :
                    (menu == 3) ? Kali(num1, num2) :
                    Bagi(num1, num2);

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