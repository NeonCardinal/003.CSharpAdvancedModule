//Stacks and queues - lab, Task 002
//11.03.2024, 22:41

int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

Stack<int> stack = new Stack<int>();

foreach(var numer in numbers)
{
    stack.Push(numer);
}

while(true)
{
    string input = Console.ReadLine().ToLower();

    if(input == "end")
    {
        break;
    }

    string[] tokens = input.Split(" ");
    string command = tokens[0];

    if(command == "add")
    {
        stack.Push(int.Parse(tokens[1]));
        stack.Push(int.Parse(tokens[2]));
    }
    else if(command == "remove")
    {
        int n = int.Parse(tokens[1]);

        if(n <= stack.Count)
        {
            for(int i = 0; i < n; i++)
            {
                stack.Pop();
            }
        }
    }
}

int sum = stack.Sum();

Console.WriteLine($"Sum: {sum}");