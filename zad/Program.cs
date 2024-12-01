
namespace zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine( stack.Pop());
            Console.WriteLine(stack.Peek());
        }

    }
    public class Stack<T>
    {
        private List<T> element;
        public Stack()
        {
            element = new List<T>();
        }
        public void Push(T item)
        {
            element.Add(item);
        }
        public T Pop()
        {
            T temp = element[element.Count - 1];
            element.Remove(element[element.Count - 1]);
            return temp;

        }
        public T Peek()
        {
            return element[element.Count - 1];
        }
    }
}
