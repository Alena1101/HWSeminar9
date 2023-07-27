// Дан одномерный массив целых чисел, элементом которого, может быть либо 1, либо 0.
// Ваша задача вывести на экран максимальное количество следующих друг за другом 1

class Program
{
   static void Main(string[] args)
    {
        int[] array = { 1, 1, 0, 1, 1, 1, 0, 1, 1, 0, 0, 1, 1 };
        
        int maxSequence = 0;
        int currentSequence = 0;
        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == 1)
            {
                currentSequence++;
                if (currentSequence > maxSequence)
                {
                    maxSequence = currentSequence;
                }
            }
            else
            {
                currentSequence = 0;
            }
        }
        
        Console.WriteLine("Максимальное количество следующих друг за другом 1: " + maxSequence);
    }
}