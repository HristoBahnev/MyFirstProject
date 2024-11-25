Console.WriteLine("Enter the number of elements to push to, to pop from and an element to look for in the stack: ");

string[] input = Console.ReadLine().Split();
int N = int.Parse(input[0]);
int S = int.Parse(input[1]);
int X = int.Parse(input[2]);

Console.WriteLine("Enter the  elements to push to the stack: ");
List<int> elements = Console.ReadLine().Split().Select(int.Parse).ToList();
Stack<int> stack = new Stack<int>();

for (int i = 0; i < N; i++)
{
    stack.Push(elements[i]);
}

for (int i = 0; i < S; i++)
{
    if (stack.Count > 0)
        stack.Pop();
}

if (stack.Count == 0)
{
    Console.WriteLine(0);
}
else if (stack.Contains(X))
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine(stack.Min());
}
