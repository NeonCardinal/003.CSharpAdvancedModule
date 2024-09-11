//Stack and queue - exercise, Task 004
//12.09.2024, 00:06

int quantity = int.Parse(Console.ReadLine());
Queue<int> orders = new Queue<int>();

string[] input = Console.ReadLine().Split().ToArray();

for(int i = 0; i < input.Length; i++)
{
    orders.Enqueue(int.Parse(input[i]));
}

Console.WriteLine(orders.Max());

while (orders.Count != 0)
{
    int order = orders.Peek();

    if(order <= quantity)
    {
        quantity -= order;
        orders.Dequeue();
    }
    else
    {
        break;
    }
}

if(orders.Count == 0)
{
    Console.WriteLine("Orders complete");
}
else
{
    Console.Write("Orders left: ");
    Console.WriteLine(string.Join(" ", orders));
}