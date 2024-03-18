//Stacks and queues - lab, Task 006
//18.03.2024, 21:18

Queue<string> names = new Queue<string>();

while(true)
{
    string input = Console.ReadLine();

    if(input == "End")
    {
        Console.WriteLine($"{names.Count} people remaining.");
        break;
    }
    else
    {
        names.Enqueue(input);
    }

    if(input == "Paid")
    {
        foreach(var item in names)
        {
            Console.WriteLine(item);
        }

        names.Clear();
    }
}