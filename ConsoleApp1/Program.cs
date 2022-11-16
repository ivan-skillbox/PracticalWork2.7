// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

//Console.WriteLine("Hello, World!");

internal class Program
{
    private static double GetAverage(params double[] values)
    {
        double sum = 0;
        int count = 0;
        foreach (double Value in values)
        {
            sum = sum + Value;
            count++;
        }
        return sum/count;
    }
    private static void Main(string[] args)
    {
        
        
        


        Console.WriteLine("Введите ФИО:");
        string name = Console.ReadLine();
        Console.WriteLine("Введите возраст:");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите email:");
        string email = Console.ReadLine();
        Console.WriteLine("Введите балл по программированию");
        double programmingScore = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите балл по математике");
        double mathsScore = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите балл по математике");
        double phisicsScore = Convert.ToDouble(Console.ReadLine());

        string output = "ФИО: {0}\nВозраст: {1}\nЭл.почта: {2}\nБаллы по программированию: {3}\nБаллы по математике: {4}\nБаллы по физике: {5}";
        
        Console.WriteLine(output, name,age,email,programmingScore,mathsScore,phisicsScore);
        
        double sumScore = programmingScore + mathsScore + phisicsScore;
        double avgScore = GetAverage(programmingScore ,mathsScore ,phisicsScore);
        Console.WriteLine("Сумма баллов по предметам: {0:0.0}",sumScore);
        Console.WriteLine("Средний балл по предметам: {0:0.0}", avgScore);
        Console.ReadKey();
    }
}