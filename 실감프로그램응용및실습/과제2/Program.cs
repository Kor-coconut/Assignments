using System;

namespace Assingment2
{
    interface IOperation
    {
        void Insert(string str); // 매개변수로 받은 str을 스택 or 큐에 푸시
        string Delete(); // 스택 or 큐에 팝한 후 반환
        bool Search(string str); // 스택 or 큐에서 주어진 원소의 존재여부를 반환
        string GetCurrentElt(); // 현재 스택 or 큐 탑 혹은 front에 있는 원소를 반환
        int NumOfElement(); // 스택 or 큐에 존재하는 원소의 개수를 반환

    }
    class MyStack : IOperation // Interface IOperation 상속 받고 구현
    {
        private string[] arr = new string[0];
        public void Insert(string str)
        {
            string[] temp = new string[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                temp[i] = arr[i];
            }
            arr = temp;
            arr[arr.Length - 1] = str;
            Console.WriteLine("{0} 가 추가 되었습니다.", str);
        }
        public string Delete()
        {
            if (arr.Length == 0)
            {
                return "원소가 없습니다!";
            }
            else
            {
                string[] temp = new string[arr.Length - 1];
                string str = arr[arr.Length - 1];
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    temp[i] = arr[i];
                }
                arr = temp;
                return str;
            }
        }
        public bool Search(string str)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == str)
                {
                    return true;
                }
            }
            return false;
        }
        public string GetCurrentElt()
        {
            if (arr.Length == 0)
            {
                return "원소가 없습니다!";
            }
            else
            {
                return arr[arr.Length - 1];
            }
        }
        public int NumOfElement()
        {
            return arr.Length;
        }

    }

    class MyQueue // : IOperation // Interface IOperation 상속 받고 구현
    {
        private string[] arr = new string[0];
        public void Insert(string str)
        {
            string[] temp = new string[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                temp[i] = arr[i];
            }
            arr = temp;
            arr[arr.Length - 1] = str;
            Console.WriteLine("{0} 가 추가 되었습니다.", str);
        }
        public string Delete()
        {
            if (arr.Length == 0)
            {
                return "원소가 없습니다!";
            }
            else
            {
                string[] temp = new string[arr.Length - 1];
                string str = arr[0];
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    temp[i] = arr[i + 1];
                }
                arr = temp;
                return str;
            }
        }
        public bool Search(string str)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == str)
                {
                    return true;
                }
            }
            return false;
        }
        public string GetCurrentElt()
        {
            if (arr.Length == 0)
            {
                return "원소가 없습니다!";
            }
            else
            {
                return arr[0];
            }
        }
        public int NumOfElement()
        {
            return arr.Length;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }
        static void Start()
        {
            while (true)
            {
                Print_Guide();
                int input_num = Convert.ToInt32(Console.ReadLine());
                Select_Num(input_num);
                if (input_num == 0)
                {
                    break;
                }
            }
        }

        static void Print_Guide()
        {
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            Console.WriteLine("1. 스택 테스트");
            Console.WriteLine("2. 큐 테스트");
            Console.WriteLine("0. 종료");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            Console.Write("프로그램을 선택하세요 : ");
        }
        static void Print_Test_Guide()
        {
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            Console.WriteLine("1. Insert");
            Console.WriteLine("2. Delete");
            Console.WriteLine("3. Search");
            Console.WriteLine("4. GetCurrentElt");
            Console.WriteLine("5. NumOfElement");
            Console.WriteLine("0. 종료");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            Console.Write("기능을 선택하세요 : ");
        }

        static void Select_Num(int input_Num)
        {
            switch (input_Num)
            {
                case 0:
                    Console.WriteLine("프로그램을 종료합니다.\n\n");
                    break;
                case 1:
                    Console.WriteLine("1번 스택 선택\n");
                    MyStackTest();
                    break;
                case 2:
                    Console.WriteLine("2번 큐 선택\n");
                    MyQueueTest();
                    break;
                default:
                    Console.WriteLine("1번 ~ 4번 혹은 0번을 선택하세요.\n\n\n");
                    break;
            }
        }
        static MyStack Stack_Test_Select_Num(int input_Num, MyStack myStack)
        {
            string str;
            switch (input_Num)
            {
                case 0:
                    Console.WriteLine("프로그램을 종료합니다.\n\n");
                    return myStack;
                case 1:
                    Console.Write("Insert : ");
                    str = Console.ReadLine();
                    myStack.Insert(str);
                    return myStack;
                case 2:
                    Console.WriteLine("Delete : {0} \n", myStack.Delete());
                    return myStack;
                case 3:
                    Console.Write("Search : ");
                    str = Console.ReadLine();
                    if(myStack.Search(str) == true) Console.WriteLine("{0} 가 있습니다.", str);
                    else Console.WriteLine("{0} 가 없습니다.", str);
                    return myStack;
                case 4:
                    Console.WriteLine("GetCurrentElt : {0}\n", myStack.GetCurrentElt());
                    return myStack;
                case 5:
                    Console.WriteLine("NumOfElement : {0}\n", myStack.NumOfElement());
                    return myStack;
                default:
                    Console.WriteLine("1번 ~ 5번 혹은 0번을 선택하세요.\n\n\n");
                    return myStack;
            }
        }
        static MyQueue Queue_Test_Select_Num(int input_Num, MyQueue myQueue)
        {
            string str;
            switch (input_Num)
            {
                case 0:
                    Console.WriteLine("프로그램을 종료합니다.\n\n");
                    return myQueue;
                case 1:
                    Console.Write("Insert : ");
                    str = Console.ReadLine();
                    myQueue.Insert(str);
                    return myQueue;
                case 2:
                    Console.WriteLine("Delete : {0} \n", myQueue.Delete());
                    return myQueue;
                case 3:
                    Console.Write("Search : ");
                    str = Console.ReadLine();
                    if(myQueue.Search(str) == true) Console.WriteLine("{0} 가 있습니다.", str);
                    else Console.WriteLine("{0} 가 없습니다.", str);
                    return myQueue;
                case 4:
                    Console.WriteLine("GetCurrentElt : {0}\n", myQueue.GetCurrentElt());
                    return myQueue;
                case 5:
                    Console.WriteLine("NumOfElement : {0}\n", myQueue.NumOfElement());
                    return myQueue;
                default:
                    Console.WriteLine("1번 ~ 5번 혹은 0번을 선택하세요.\n\n\n");
                    return myQueue;
            }
        }
        static void MyStackTest()
        {
            MyStack myStack = new MyStack();
            while (true)
            {
                Print_Test_Guide();
                int input_num = Convert.ToInt32(Console.ReadLine());
                myStack = Stack_Test_Select_Num(input_num, myStack);
                if (input_num == 0)
                {
                    break;
                }
            }
        }
        static void MyQueueTest()
        {
            MyQueue myQueue = new MyQueue();
            while (true)
            {
                Print_Test_Guide();
                int input_num = Convert.ToInt32(Console.ReadLine());
                myQueue = Queue_Test_Select_Num(input_num, myQueue);
                if (input_num == 0)
                {
                    break;
                }
            }
        }
    }
}
