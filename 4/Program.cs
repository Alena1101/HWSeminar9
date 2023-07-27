// Даны два положительных Даны два положительных целых числа, представленных в виде строк. 
// Необходимо получить сумму чисел, которые представлены этими строками. 
// Причем полученная сумма должна быть преобразована в строку.
// Для решения этой задачи запрещено преобразовывать входные строки сразу напрямую в целое число 
// при помощи встроенной функции. Необходимо сделать это самостоятельно.
class Program
{
    static string AddStrings(string num1, string num2)
    {
        int m = num1.Length;
        int n = num2.Length;

        int[] result = new int[Math.Max(m, n) + 1];
        int carry = 0;

        for (int i = m - 1, j = n - 1, k = result.Length - 1; k >= 0; i--, j--, k--)
        {
            int x = i >= 0 ? num1[i] - '0' : 0;
            int y = j >= 0 ? num2[j] - '0' : 0;

            int sum = x + y + carry;
            result[k] = sum % 10;
            carry = sum / 10;
        }

        int startIndex = result[0] == 0 ? 1 : 0;
        return string.Join("", result[startIndex..]);
    }

    static void Main(string[] args)
    {
        string num1 = "156";
        string num2 = "91";
        string sum = AddStrings(num1, num2);
        Console.WriteLine(sum);
    }
}
