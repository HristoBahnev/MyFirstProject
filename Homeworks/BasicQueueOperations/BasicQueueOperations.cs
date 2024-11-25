Console.WriteLine("Enter the number of elements to enqueue, to dequeue and an element to look for in the queue: ");

string[] input = Console.ReadLine().Split();
int N = int.Parse(input[0]);
int S = int.Parse(input[1]);
int X = int.Parse(input[2]);

Console.WriteLine("Enter the  elements to enqueue to the queue: ");
List<int> elements = Console.ReadLine().Split().Select(int.Parse).ToList();
Queue<int> queue = new Queue<int>();

for (int i = 0; i < N; i++)
{
    queue.Enqueue(elements[i]);
}

for (int i = 0; i < S; i++)
{
    if (queue.Count > 0)
        queue.Dequeue();
}

if (queue.Count == 0)
{
    Console.WriteLine(0);
}
else if (queue.Contains(X))
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine(queue.Min());
}
