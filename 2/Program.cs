// Дан одномерный массив целых однозначных чисел (элемент массива содержит число от 1 до 9).
// Ваша задача вывести на экран число, которое формируется элементами массива слева-направо + 1
class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
        
        int number = 0;
        
        for (int i = 0; i < array.Length; i++)
        {
            number = number * 10 + array[i];
        }
        
        number += 1;
        
        Console.WriteLine("Результирующее число: " + number);
    }
}
