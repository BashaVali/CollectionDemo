using System.Data;
using System.Xml.Linq;

namespace CollectionDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" 1.dictionary,2.list,3.stack,4.queue,5.set 6.exit");
            int num = Convert.ToInt16(Console.ReadLine());
            bool flag = true;
            while (flag)
            {
                switch (num)
                {
                    case 1:
                        DoDictionaryDemo();
                        break;
                    case 2:
                        DoListDemo();
                        break;
                    case 3:
                        DoStackDemo();
                        break;
                    case 4:
                        DoQueuesDemo();
                        break;
                    case 5:
                        DosetDemo();
                        break;
                    case 6:
                        flag = false;

                        break;
                }
            }
            Console.WriteLine("exit");

        }
        public static void DoDictionaryDemo()
        {
            Console.WriteLine("dictionary");
            Dictionary<int, string> dictionay = new Dictionary<int, string>();
            dictionay.Add(1, "A");
            dictionay.Add(2, "B");
            dictionay.Add(3, "C");
            dictionay.Add(4, "D");
            dictionay.Add(5, "E");

            Console.WriteLine("Access of value using key" + dictionay[1]);

            foreach (var element in dictionay)
            {
                Console.WriteLine("key :" + element.Key + " value :" + element.Value);
            }

        }
        private static void DoListDemo()
        {
            Console.WriteLine("List");
            List<string> list = new List<string>();
            list.Add("A");
            list.Add("B");
            list.Add("C");
            list.Add("D");
            

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }


        }
        private static void DoStackDemo()
        {
            Stack<string> stack = new Stack<string>();

            stack.Push("A");
            stack.Push("B");
            stack.Push("C");
            stack.Push("D");
            stack.Push("E");
            stack.Push("F");

            Console.WriteLine("the element pop is : " + stack.Pop());
            foreach (var item in stack)
            {
                Console.WriteLine(item); ;
            }
        }
        private static void DoQueuesDemo()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("A");
            queue.Enqueue("B");
            queue.Enqueue("C");
            queue.Enqueue("D");
            queue.Enqueue("E");

            Console.WriteLine("element is dequeue is :" + queue.Dequeue());
            Console.WriteLine("element is peek is :" + queue.Peek());
            foreach (var item in queue)
            {
                Console.WriteLine(item); ;
            }
            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        private static void DosetDemo()
        {
            Console.WriteLine("set demo");
            var Set = new HashSet<string>();
            Set.Add("A");
            Set.Add("B");
            Set.Add("C");
            Set.Add("D");
            Set.Add("E");
            foreach (var data in Set)
            {
                Console.WriteLine(data);
            }
            HashSet<string>.Enumerator enumerator = Set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

        }
    }
}
