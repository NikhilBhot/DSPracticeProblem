namespace DataStructurePP
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create generic class custom Linkedlist datastructure .
            LinkedList<int> numbers = new LinkedList<int>();

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);

            numbers.Print(); // Output: 1 2 3 4 5

            numbers.Remove(3);
            numbers.Remove(5);

            numbers.Print(); // Output: 1 2 4

            numbers.Clear();

            Console.WriteLine("Count: " + numbers.Count); // Output: 0

            Console.WriteLine("________________________________");
            Console.WriteLine("Stack Implemetation");
            Stack<int> stack = new Stack<int>(5);

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("Count: " + stack.Count); // Output: 3
            Console.WriteLine("Peek: " + stack.Peek()); // Output: 3

            int poppedItem = stack.Pop();
            Console.WriteLine("Popped Item: " + poppedItem); // Output: 3
            Console.WriteLine("Count: " + stack.Count); // Output: 2

            stack.Clear();
            Console.WriteLine("Count: " + stack.Count); // Output: 0
            Console.WriteLine("Is Empty: " + stack.IsEmpty()); // Output: True
        }
    }
}