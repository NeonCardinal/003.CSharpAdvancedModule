//Stacks and queues - lab, Task 004
//18.03.2024, 20:26

string exp = Console.ReadLine();
Stack<int> stack = new Stack<int>();

for (int i = 0; i < exp.Length; i++)
{
    char ch = exp[i];

    if (ch == '(')
    {
        stack.Push(i);
    }
    else if (ch == ')')
    {
        int startIndex = stack.Pop();
        int endIndex = i;
        string subExp = exp.Substring(startIndex, endIndex - startIndex + 1);
        Console.WriteLine(subExp);
    }
}