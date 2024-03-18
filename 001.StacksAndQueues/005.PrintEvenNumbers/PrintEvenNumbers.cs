//Stacks and queues - lab, Task 005
//18.03.2024, 20:27

int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
Queue<int> queueNumbers = new Queue<int>();

for (int i = 0; i < array.Length; i++)
{
    queueNumbers.Enqueue(array[i]);
}

int len = queueNumbers.Count;

for (int i = 0; i < len; i++)
{
    int number = queueNumbers.Dequeue();
    if (number % 2 == 0)
    {
        queueNumbers.Enqueue(number);
    }
}

Console.WriteLine(string.Join(", ", queueNumbers));