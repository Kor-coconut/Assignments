using System;
using System.Collections.Generic;

namespace Homework_2_3
{
    /*
    <!-- Books 클래스 멤버로 List<T> 사용 && Property 반드시 사용 -->
    [완] 1. Books 클래스 생성 --> Book 상속
    [완] 2. Books 클래스의 AddBook Method(Book) (Book)
    [완] 3. Books 클래스 멤버의 list 이름은 al
    [완] 4. Book 클래스 생성 (parameter 2개 생성자 필요)
    [완] 5. BookCount --> Books의 Property
    [완] 6. getID, getName Property --> Book의 Property 생성
    [완] 7. Books 클래스의 ReMoveBook(int) Method (void type)
    [완] 8. Books 클래스의 BookIsPresent(Book) Method (bool type)
    [완] 9. Books 클래스의 ClearAllBooks(void) Method (void type);

    4 6 1 3 5 2 7 8 9
     */
    class Book
    {
        private string Name;
        private int ID;
        public Book() // 기본 생성자
        {
            Name = null;
            ID = 0;
        }
        public Book(string Name, int ID) // parameter 2개 생성자
        {
            this.Name = Name;
            this.ID = ID;
        }
        public string getName // Name의 property
        {
            get { return Name; }
            set { Name = value; }
        }
        public int getID // ID의 property
        {
            get { return ID; }
            set { ID = value; }
        }
    }
    class Books<T> : Book // Books
    {
        private List<T> array_list;

        public Books()
        {
            al = new List<T>();
        }

        public List<T> al
        {
            get { return array_list; }
            set { array_list = value; }
        }

        public void AddBook(T book)
        {
            al.Add(book);
        }

        public int BookCount
        {
            get { return array_list.Count; }
        }

        public void RemoveBook(int pos)
        {
            //al.RemoveAt(array_list.Count - pos); // 마지막으로 들어온 책 중 pos 번째
            al.RemoveAt(pos); // 0 번째에서 시작해서 pos 번째
        }

        public bool BookIsPresent(T book)
        {
            for (int i = 0; i < al.Count; i++)
            {
                if (al[i].Equals(book))
                {
                    return true;
                }
            }
            return false;
        }

        public void ClearAllBooks()
        {
            al.Clear();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Books<Book> bookStore = new Books<Book>(); // 문제에는 <Book> 빠져있음. Books의 클래스 멤버로 List<T>를 사용하려면 필요.
            bookStore.AddBook(new Book("냉정과 열정사이", 10001));
            bookStore.AddBook(new Book("우리들의 행복한 시간", 10002));
            bookStore.AddBook(new Book("블루오션 전략", 10003));
            bookStore.AddBook(new Book("나를 사랑하는 법", 10004));

            Console.WriteLine("You have {0} in the store:\n", bookStore.BookCount);

            foreach (Book b in bookStore.al)
            {
                Console.WriteLine("PBSN : {0}", b.getID);
                Console.WriteLine("Book Name : {0}", b.getName);
            }

            Console.WriteLine("You remove second book in the store\n");

            bookStore.RemoveBook(2); // 0 번째에서 시작해서 2 번째 책? || 마지막으로 들어온 책 중 두 번째?
            Console.WriteLine("\nYou have {0} in the store:\n", bookStore.BookCount);

            foreach (Book b in bookStore.al)
            {
                Console.WriteLine("PBSN : {0}", b.getID);
                Console.WriteLine("Book Name : {0}", b.getName);
            }

            Book temp = new Book("토정비결", 10010);
            bookStore.AddBook(temp);
            if (bookStore.BookIsPresent(temp))
            {
                Console.WriteLine("{0} is already in the store.", temp.getName);
            }
            Console.WriteLine("\nRemove all books in the store.\n");

            bookStore.ClearAllBooks();
            Console.WriteLine("You have {0} in the store.\n", bookStore.BookCount);
        }
    }
}
