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
        }
    }
}