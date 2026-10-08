using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== 1. SICAKLIK DÖNÜŞÜMÜ ===");
        Console.Write("Enter Celsius value: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double kelvin = celsius + 273.15;
        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine($"Kelvin: {kelvin:F2}");
        Console.WriteLine($"Fahrenheit: {fahrenheit:F2}");
        
        Console.WriteLine("\n----------------------------------\n");

        Console.WriteLine("=== 2. SINAV NOTU HESAPLAMA ===");
        Console.Write("Enter first exam grade: ");
        double grade1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second exam grade: ");
        double grade2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter third exam grade: ");
        double grade3 = Convert.ToDouble(Console.ReadLine());

        double sum = grade1 + grade2 + grade3;
        double average = sum / 3;

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average:F2}");
        Console.WriteLine($"Average is >= 60: {average >= 60}");

        Console.WriteLine("\n----------------------------------\n");

        Console.WriteLine("=== 3. 3 BASAMAKLI SAYI ANALİZİ ===");
        Console.Write("Enter a 3-digit number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int hundreds = number / 100;
        int tens = (number / 10) % 10;
        int ones = number % 10;

        Console.WriteLine($"Hundreds digit: {hundreds}");
        Console.WriteLine($"Tens digit: {tens}");
        Console.WriteLine($"Ones digit: {ones}");
    }
}