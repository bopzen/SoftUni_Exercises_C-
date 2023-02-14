namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stack = new StackOfStrings();
            stack.Push("Hello");
            stack.Push("hi");
            stack.IsEmpty();
            Stack<string> newStack = new Stack<string>();
            newStack.Push("Hello");
            newStack.Push("hi");
            stack.AddRange(newStack);
            Console.Write(string.Join(" ", stack.ToArray()));
        }
    }
}