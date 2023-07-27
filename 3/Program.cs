// Дана строка, содержащая только следующие символы:'(', ')', '{', '}', '[', ']'. Определите, является ли ваша строка допустимой.
// Исходная строка считается допустимой при условии:
// 1. Открытые скобки должны быть закрыты скобками того же типа.
// 2. Открытые скобки должны быть закрыты в правильном порядке.
// 3. Каждая закрывающия скобка имеет соответствующую открытыю скобку того же типа.


class Program
{
    static bool IsValidExpression(string expression)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char ch in expression)
        {
            if (ch == '(' || ch == '{' || ch == '[')
            {
                stack.Push(ch);
            }
            else if (ch == ')' || ch == '}' || ch == ']')
            {
                if (stack.Count == 0 || !IsMatchingPair(stack.Peek(), ch))
                {
                    return false;
                }
                stack.Pop();
            }
        }

        return stack.Count == 0;
    }

    static bool IsMatchingPair(char opening, char closing)
    {
        return (opening == '(' && closing == ')')
            || (opening == '{' && closing == '}')
            || (opening == '[' && closing == ']');
    }

    static void Main(string[] args)
    {
        string expression = "(){}[]";
        bool isValid = IsValidExpression(expression);
        Console.WriteLine($"Expression is valid: {isValid}");
    }
}
