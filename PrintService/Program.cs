using PrintService.Services;
using System;

namespace PrintService {
    internal class Program {
        static void Main(string[] args) {
            PrinterService<int> print = new PrinterService<int>();
            Console.Write("Quantos Números: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                Console.Write($"Número {i + 1}: ");
                int number = int.Parse(Console.ReadLine());
                print.AddValue(number);
            }
            Console.WriteLine();
            print.Print();
            Console.WriteLine($"Primeiro: {print.First()}");
            Console.WriteLine();
        }
    }
}
