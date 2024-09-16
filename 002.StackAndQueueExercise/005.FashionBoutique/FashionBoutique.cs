//Stack and queue - exercise, Task 005
//12.09.2024, 00:39

Stack<int> box = new Stack<int>();
int racksCnt = 0;

int[] inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
int rackCapacity = int.Parse(Console.ReadLine());

for(int i = 0; i < inputs.Length; i++)
{
    box.Push(inputs[i]);
}



while(box.Count > 0)
{
    int sum = 0;
    int currentValue = box.Peek();

    while(sum + currentValue < rackCapacity)
    {
        if(sum + currentValue < rackCapacity)
        {
            sum += box.Pop();
        }

        if(box.Count > 0)
        {
            currentValue = box.Peek();
        }
        else
        {
            break;
        }
    }

    racksCnt++;
}

Console.WriteLine(racksCnt);