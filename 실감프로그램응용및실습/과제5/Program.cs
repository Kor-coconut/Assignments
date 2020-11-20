using System;
using System.Collections.Generic;
using System.Linq;

namespace Assgnment5
{
    class Person // Person Class 작성
    {
        public string SSN;
        public string Name;
        public string Address;
        public int Age;

        public Person(string ssn, string name, string addr, int age) // Person Class 생성자
        {
            this.SSN = ssn;
            this.Name = name;
            this.Address = addr;
            this.Age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listPersonsInCity = new List<Person>();

            listPersonsInCity.Add(new Person("203456876", "John", "12 Main Street, Newyork, NY", 15));
            listPersonsInCity.Add(new Person("203456877", "SAM", "13 Main Ct, Newyork, NY", 25));
            listPersonsInCity.Add(new Person("203456878", "Elan", "14 Main Street, Newyork, NY", 35));
            listPersonsInCity.Add(new Person("203456879", "Smith", "12 Main Street, Newyork, NY", 45));
            listPersonsInCity.Add(new Person("203456880", "SAM", "345 Main Ave, Dayton, OH", 55));
            listPersonsInCity.Add(new Person("203456881", "Sue", "32 Cranbrook Rd, Newyork, NY", 65));
            listPersonsInCity.Add(new Person("203456882", "Windston", "1208 Alex st, Newyork, NY", 65));
            listPersonsInCity.Add(new Person("203456883", "Mac", "126 Province Ave, Baltimore, NY", 85));
            listPersonsInCity.Add(new Person("203456884", "SAM", "126 Provinnce Ave, Baltimore, NY", 95));

            MyLinq(listPersonsInCity);
        }

        static void MyLinq(List<Person> listPersonInCity)
        {
            int num = 1;

            while(num != 0)
            {
                PrintSolution();
                num = int.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------------------");
                switch (num)
                {
                    case 0:
                        break;
                    case 1:
                        Solution1(listPersonInCity);
                        break;
                    case 2:
                        Solution2(listPersonInCity);
                        break;
                    case 3:
                        Solution3(listPersonInCity);
                        break;
                    case 4:
                        Solution4(listPersonInCity);
                        break;
                    case 5:
                        Solution5(listPersonInCity);
                        break;
                    case 6:
                        Solution6(listPersonInCity);
                        break;
                    case 7:
                        Solution7(listPersonInCity);
                        break;
                    case 8:
                        Solution8(listPersonInCity);
                        break;
                    case 9:
                        Solution9(listPersonInCity);
                        break;
                    case 10:
                        Solution10(listPersonInCity);
                        break;
                    case 11:
                        Solution11(listPersonInCity);
                        break;
                    case 12:
                        Solution12(listPersonInCity);
                        break;
                    default:
                        Console.WriteLine("올바른 메뉴를 선택하세요.(0 ~ 12)");
                        break;
                }
            }
        }

        static void PrintSolution()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("1) 60세 이상인 사람 2명을 검색 (group ~ by 사용)");
            Console.WriteLine("2) 13~19세 사이 청소년을 리스트에서 검색 (group ~ by 사용)");
            Console.WriteLine("3) 모두 나이가 10세 이상인지 체크하고 그 결과 출력");
            Console.WriteLine("4) 모든 사람을 대상으로 평균 연령 구하기 (Average 표준연산자 사용)");
            Console.WriteLine("5) SAM이란 이름을 검색하고 삭제하기");
            Console.WriteLine("6) Smith 인덱스 위치 알아내기");
            Console.WriteLine("7) 나이가 가장 많은 사람의 이름과 나이 출력");
            Console.WriteLine("8) 모든 사람의 나이 합 출력 (Sum 표준연산자 사용)");
            Console.WriteLine("9) 60세 이상인 사람 리스트 (group ~ by 사용)");
            Console.WriteLine("10) 이름이 J로 시작하는 사람 찾기 (Contain 표준연산자 사용)");
            Console.WriteLine("11) 모든 사람이 SSN을 가지고 있는지 확인");
            Console.WriteLine("12) SSN코드 203456876 검색");
            Console.WriteLine("0) 종료");
            Console.Write("메뉴를 선택하세요. (0 ~ 12) : ");
        }
        static void Solution1(List<Person> listPersonsInCity)
        {
            var temp = from persons in listPersonsInCity
                       group persons by persons.Age >= 60 into g // list의 60세 이상 g에 저장
                       select new
                       {
                           GroupKey = g.Key,
                           Persons = g
                       };

            foreach(var Group in temp)
            {
                if (Group.GroupKey)
                {
                    int count = 0;
                    foreach (var persons in Group.Persons)
                    {
                        if (count++ == 2) break;
                        Console.WriteLine($"{persons.SSN}, {persons.Name}, {persons.Address}, {persons.Age}");
                    }
                }
            }
        }
        static void Solution2(List<Person> listPersonsInCity)
        {
            var temp = from persons in listPersonsInCity
                       group persons by 13 <= persons.Age && persons.Age <= 19 into g // list의 13세 ~ 19세 g에 저장
                       select new
                       {
                           GroupKey = g.Key,
                           Persons = g
                       };

            foreach(var Group in temp)
            {
                if (Group.GroupKey)
                {
                    foreach (var persons in Group.Persons)
                    {
                        Console.WriteLine($"{persons.SSN}, {persons.Name}, {persons.Address}, {persons.Age}");
                    }
                }
            }
        }
        static void Solution3(List<Person> listPersonsInCity)
        {
            var temp = from persons in listPersonsInCity
                       group persons by persons.Age >= 10 into g // list의 10세 이상 g에 저장
                       select new
                       {
                           GroupKey = g.Key,
                           Persons = g
                       };

            int count = 0;
            foreach(var Group in temp)
            {
                if (Group.GroupKey)
                {
                    foreach (var persons in Group.Persons)
                    {
                        count++;
                    }
                }
            }
            if (listPersonsInCity.Count == count) Console.WriteLine("모두 나이가 10세 이상입니다.");
            else Console.WriteLine("일부 나이가 10세 이상이 아닙니다.");
        }
        static void Solution4(List<Person> listPersonsInCity)
        {
            var temp = (from persons in listPersonsInCity
                        select persons).Average(persons => persons.Age); // 모든 사람의 나이 평균 temp에 저장
            Console.WriteLine($"모든 사람 평균 연령 : {temp}");
        }
        static void Solution5(List<Person> listPersonsInCity)
        {
            var temp = (from persons in listPersonsInCity
                        select persons).ToList();
            temp.RemoveAll(persons => persons.Name == "SAM");
            Console.WriteLine("삭제 완료\n남은 사람");
            foreach(var Gruop in temp)
            {
                Console.WriteLine($"{Gruop.SSN}, {Gruop.Name}, {Gruop.Address}, {Gruop.Age}");
            }
        }
        static void Solution6(List<Person> listPersonsInCity)
        {
            var temp = (from persons in listPersonsInCity
                        select persons).ToList();
            int idx = temp.FindIndex(persons => persons.Name == "Smith");
            Console.WriteLine($"Smith 인덱스 위치 : {idx}");
        }
        static void Solution7(List<Person> listPersonsInCity)
        {
            var temp = (from persons in listPersonsInCity
                        orderby persons.Age descending // 나이 순 내림차순 정렬
                        select persons).ToList();
            Console.WriteLine($"나이가 가장 많은 사람의 이름 : {temp[0].Name} 나이 : {temp[0].Age}");
        }
        static void Solution8(List<Person> listPersonsInCity)
        {
            var temp = (from persons in listPersonsInCity
                        select persons).Sum(persons => persons.Age);
            Console.WriteLine($"나이 합 : {temp}");
        }
        static void Solution9(List<Person> listPersonsInCity)
        {
            var temp = from persons in listPersonsInCity
                       group persons by persons.Age >= 60 into g
                       select new
                       {
                           GroupKey = g.Key,
                           Persons = g
                       };

            foreach(var Group in temp)
            {
                if (Group.GroupKey)
                {
                    foreach (var persons in Group.Persons)
                    {
                        Console.WriteLine($"{persons.SSN}, {persons.Name}, {persons.Address}, {persons.Age}");
                    }
                }
            }
        }
        static void Solution10(List<Person> listPersonsInCity)
        {
            var temp = (from persons in listPersonsInCity
                        where persons.Name.Contains("J") // J를 포함하는 사람 // 문제를 정확히 해석하면 StartsWith를 쓰는게 맞지 않나 생각이 듬
                        select persons).ToList();
            for(int i = 0; i < temp.Count(); i++)
            {
                if (temp[i].Name.StartsWith("J"))
                {
                    Console.WriteLine($"{temp[i].SSN}, {temp[i].Name}, {temp[i].Address}, {temp[i].Age}");
                }
            }
        }
        static void Solution11(List<Person> listPersonsInCity)
        {
            var temp = from persons in listPersonsInCity
                       group persons by persons.SSN != null into g // SSN이 있는 사람만 g에 저장
                       select new
                       {
                           GroupKey = g.Key,
                           Persons = g
                       };

            int count = 0;
            foreach(var Group in temp)
            {
                if (Group.GroupKey)
                {
                    foreach (var persons in Group.Persons)
                    {
                        count++;
                    }
                }
            }
            if (listPersonsInCity.Count == count) Console.WriteLine("모두 SSN을 갖고 있음");
            else Console.WriteLine("일부 SSN을 갖고 있지 않음");
        }
        static void Solution12(List<Person> listPersonsInCity)
        {
            var temp = (from persons in listPersonsInCity
                        where persons.SSN == "203456876"
                        select persons).ToList();

            Console.WriteLine($"{temp[0].SSN}, {temp[0].Name}, {temp[0].Address}, {temp[0].Age}");
        }
    }
}
