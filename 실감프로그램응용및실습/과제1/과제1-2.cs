using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace Homework_1_2
{
    public class DynamicArray
    {
        private object[] arr = new object[0];
        public void Add(object element)
        {
            var temp = new object[arr.Length + 1];
            for(int i = 0; i < arr.Length; i++)
            {
                temp[i] = arr[i];
            }
            arr = temp;
            arr[arr.Length - 1] = element;
        }
    }
    class Exercise_2
    {
        static int[] Dynamic_Arr(int element, int[] arr) // ★ 3번 프로그램에 쓸 동적 배열
        {
            int[] temp = new int[arr.Length + 1];
            for(int i = 0; i < arr.Length; i++)
            {
                temp[i] = arr[i];
            }
            arr = temp;
            arr[arr.Length - 1] = element;
            return temp;
        }
        static int Max_Num(int[] arr) // ★ 3번 프로그램에 쓸 최댓값 구하기
        {
            int max_num = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max_num)
                {
                    max_num = arr[i];
                }
            }
            return max_num;
        }
        static void Print_Guide() // 프로그램 사용 방법
        {
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            Console.WriteLine("1. 원금과 이율, 기간을 입력으로 받아 복리법에 의해 원래 합계를 구하는 프로그램");
            Console.WriteLine("2. 10사람의 키(H)와 몸무게(W)를 입력받아 (2차원 배열) 비만도(B)를 계산하여 동시에 출력하는 프로그램");
            Console.WriteLine("3. 일련의 정수를 읽어(자료의 끝은 0) 제일 큰 수를 출력하는 프로그램을 작성");
            Console.WriteLine("0. 종료");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            Console.Write("프로그램을 선택하세요 : ");
        }
        static void Select_Num(int input_num) // 프로그램 선택
        {
                switch (input_num)
                {
                    case 0:
                        Console.WriteLine("프로그램을 종료합니다.\n\n");
                        break;
                    case 1:
                        Console.WriteLine("1번 선택\n");
                        Program_Num_One();
                        break;
                    case 2:
                        Console.WriteLine("2번 선택\n");
                        Program_Num_Two();
                        break;
                    case 3:
                        Console.WriteLine("3번 선택\n");
                        Program_Num_Three();
                        break;
                    default:
                        Console.WriteLine("1번 ~ 3번 혹은 0번을 선택하세요.\n\n\n");
                        break;
                }
        }
        static void Program_Num_One() // 1번 프로그램 (복리)
        {
            Double sum, interest_Rate;
            int principal, term;
            Console.Write("원금을 입력하세요.(예 : 3,000\\ -> 3000) : ");
            principal = Convert.ToInt32(Console.ReadLine());
            Console.Write("이율을 입력하세요.(예 : 3.3% -> 3.3) : ");
            interest_Rate = Convert.ToDouble(Console.ReadLine());
            Console.Write("기간을 입력하세요.(예 : 4년 -> 4) : ");
            term = Convert.ToInt32(Console.ReadLine());
            sum = principal * (Math.Pow(1 + (interest_Rate / 100), term));
            Console.WriteLine("\n합계 : {0}\\\n", sum);
        }
        static void Program_Num_Two() // 2번 프로그램 (비만)
        {
            double SW, B;
            int[,] HW = new int[2, 10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}번째 학생의 키를 입력하세요. (예 : 178cm -> 178) : ", i + 1);
                HW[0, i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("{0}번째 학생의 몸무게를 입력하세요. (예 : 76kg -> 76) : ", i + 1);
                HW[1, i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\t\t  키 몸무게 표준체중 비만도");
            Console.WriteLine("-----------------------------------------------------");
            for (int i = 0; i < 10; i++)
            {
                SW = (HW[0, i] - 100) * 0.9;
                B = HW[1, i] / SW * 100;
                Console.WriteLine("{0}번째 학생\t| {1} | {2} | {3} | {4} |", i + 1, HW[0, i], HW[1, i], SW, B);
            }
        }
        static void Program_Num_Three() // 3번 프로그램 (큰 수)
        {
            int[] arr = new int[0];
            int input_num, count = 0;
            while (true)
            {
                Console.Write("{0}번째 숫자를 입력하세요.(입력 끝 : 0) : ", ++count);
                input_num = Convert.ToInt32(Console.ReadLine());
                if (input_num == 0)
                    break;
                else
                    arr = Dynamic_Arr(input_num, arr);
            }
            Console.WriteLine("총 입력 받은 개수 : {0}", arr.Length);
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
                if(i % 10 == 9)
                {
                    Console.Write("\n");
                }
            }
            Console.Write("\b");
            Console.WriteLine("입력 받은 수들 중 가장 큰 수는 : {0} 입니다.\n", Max_Num(arr));
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Print_Guide();
                int input_num;
                input_num = Convert.ToInt32(Console.ReadLine());
                Select_Num(input_num);
                if(input_num == 0)
                {
                    break;
                }
            }
        }
    }
}
