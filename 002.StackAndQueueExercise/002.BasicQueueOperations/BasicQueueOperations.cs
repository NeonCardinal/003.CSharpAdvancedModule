//Stack and Queue - exercise, Task 002
//09.06.2024, 14:38

Queue<int> que = new Queue<int>();

int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

int n = arr[0];
int s = arr[1];
int x = arr[2];

for(int i = 0; i < n; i++)
{
    que.Enqueue(inputNumbers[i]);
}

for(int i = 0; i < s; i++)
{
    que.Dequeue();
}

if(que.Count > 0)
{
    if(que.Contains(x))
    {
        Console.WriteLine("true");
    }
    else
    {
        Console.WriteLine(que.Min());
    }
}
else
{
    Console.WriteLine(0);
}