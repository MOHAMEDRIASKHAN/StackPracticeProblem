// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace StackPracticeProblem
{
    class program
    {
        public static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("56");
            stack.Push("30");
            stack.Push("70");

            foreach(string ele in stack)
            {
                Console.WriteLine(ele);
            }

            stack.Pop();

            Console.WriteLine("The peek element is " +stack.Peek());
            Console.WriteLine("--------------------");

                foreach (string ele in stack)
            {
                Console.WriteLine(ele);
            }
        }
    }
}