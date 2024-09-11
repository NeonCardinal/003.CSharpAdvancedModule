//Stacks and Queues - exercise, Task 001
//09.06.2024, 14:28

Stack<int> stack = new Stack<int>();

int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

int n = arr[0];
int s = arr[1];
int x = arr[2];


for(int i = 0; i < n; i++)
{
    stack.Push(inputNumbers[i]);
}

for(int i = 0; i < s; i++)
{
    stack.Pop();
}

if(stack.Count > 0)
{
    if(stack.Contains(x))
    {
        Console.WriteLine("true");
    }
    else
    {
        Console.WriteLine(stack.Min());
    }
}
else
{
    Console.WriteLine(0);
}
