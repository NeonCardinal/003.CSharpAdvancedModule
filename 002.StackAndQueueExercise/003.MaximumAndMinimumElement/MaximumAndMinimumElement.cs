//Stack and queue - exercise, Task 003
//09.06.2024, 14:54

int n = int.Parse(Console.ReadLine());
Stack<int> stack = new Stack<int>();

for(int i = 0; i < n; i++)
{
    string[] inputs = Console.ReadLine().Split().ToArray();

    if(inputs.Length > 1)
    {
        stack.Push(int.Parse(inputs[1]));
    }
    else
    {
        int input = int.Parse(inputs[0]);

        if(input == 2)
        {
            stack.Pop();
        }
        else if(input == 3)
        {
            if(stack.Count != 0)
            {
                Console.WriteLine(stack.Max());
            }
        }
        else if(input == 4)
        {
            if (stack.Count != 0)
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}

Console.WriteLine(string.Join(", ", stack));