//Напишите программу, которая задаёт
//массив из 8 элементов и выводит их на экран

Random rnd = new Random();
int[] array = new int[8];



for(int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(0,100);
}
for(int i = 0; i < array.Length; i++)
{
    Console.Write($"[{array[i]}] ");
}