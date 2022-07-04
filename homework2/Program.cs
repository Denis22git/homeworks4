//Напишите программу, которая принимает
//на вход число и выдаёт сумму цифр в числе.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите числа через пробел : ");
        int[] values = Console.ReadLine().Split(new string[]{" "}, StringSplitOptions.RemoveEmptyEntries).Select( n => int.Parse(n)).ToArray();
        int sum = GetSum(values);
        Console.WriteLine("Сумма = {0}", sum);
        Console.ReadLine();
    }
 
    private static int GetSum( params int[] list)
    {
        return list.Sum();
    }
}