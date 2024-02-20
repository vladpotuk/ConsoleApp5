using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть число A: ");
        int A = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введіть число B (B > A): ");
        int B = Convert.ToInt32(Console.ReadLine());

        
        for (int i = A; i <= B; i++)
        {
            
            for (int j = 0; j < i; j++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(); 
        }
    }
}
