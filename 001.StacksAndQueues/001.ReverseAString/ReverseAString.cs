//Stacks and queues - lab, Task 001
//11.03.2024, 22:31

string str = Console.ReadLine();

Stack<char> stack = new Stack<char>();

foreach(var ch in str)
{
    stack.Push(ch);
}

Console.WriteLine(string.Join("", stack));