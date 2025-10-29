namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region stringdelegate
            //Message msg = ShowMessage;
            //msg("salamsalam");
            ////multicast
            //msg += ShowDiffMsg;
            //msg("salamsagol");
            #endregion

            #region delegateint
            //OperationNum op;

            //op = Sum;
            //Console.WriteLine(op(5, 7));

            //op = Multiply;
            //Console.WriteLine(op(6, 9));

            //op = Subtract;
            //Console.WriteLine(op(7, 2));
            #endregion

            #region queue
            //Queue<int> nums = new();
            //nums.Enqueue(5);
            //nums.Enqueue(10);
            //nums.Enqueue(15);
            //nums.Enqueue(20);
            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region dictionary
            //Dictionary<int, string> dict = new();
            //dict.Add(1, "salamsagol");
            //dict.Add(2, "sagol");
            //dict.Add(3, "salam");
            //foreach (var item in dict)
            //{
            //    Console.WriteLine($"{item.Key} : {item.Value}");
            //}
            #endregion

            #region stack
            //Stack<string> stack = new();
            //stack.Push("first");
            //stack.Push("second");
            //stack.Push("third");
            //stack.Push("fourth");
            //stack.Push("last");
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region task
            List<string> sozler = new List<string> { "alma", "armud", "banan", "nar" };

           
            Predicate<string> startsWithA = s => s.StartsWith("a");

            List<string> result = Filter(sozler, startsWithA);

            foreach (var word in result)
            {
                Console.WriteLine(word);
            }
            #endregion
        }

        #region stringdelegate
        //public delegate void Message(string msg);


        //public static void ShowMessage(string message)
        //{
        //    Console.WriteLine(message);
        //}

        //public static void ShowDiffMsg(string message) 
        //{
        //    Console.WriteLine("sagolsalam??");
        //}
        #endregion

        #region delegateint
        //public delegate int OperationNum(int a, int b);

        //public static int Sum(int a, int b)
        //{
        //    return a + b;
        //}

        //public static int Multiply(int a, int b)
        //{
        //    return a * b;
        //}
        //public static int Subtract(int a, int b)
        //{
        //    return a - b;
        //}
        #endregion

        #region task
        static List<string> Filter(List<string> list, Predicate<string> shert)
        {
            List<string> newList = new List<string>();

            foreach (var item in list)
            {
                if (shert(item))
                    newList.Add(item);
            }

            return newList;
        }
        #endregion
    }
}
