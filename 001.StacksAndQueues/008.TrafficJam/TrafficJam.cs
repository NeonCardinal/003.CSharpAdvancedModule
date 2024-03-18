//Stacks and queues - lab, Task 008
//18.03.2024, 21:28

int n = int.Parse(Console.ReadLine());
Queue<string> carsQueue = new Queue<string>();
int carsCounter = 0;

while (true)
{
    string cmd = Console.ReadLine();

    if (cmd == "end")
    {
        Console.WriteLine($"{carsCounter} cars passed the crossroads.");
        break;
    }
    else if (cmd == "green")
    {
        for (int i = 0; i < n; i++)
        {
            if (carsQueue.Count > 0)
            {
                Console.WriteLine($"{carsQueue.Dequeue()} passed!");
                carsCounter++;
            }
        }
    }
    else
    {
        carsQueue.Enqueue(cmd);
    }
}