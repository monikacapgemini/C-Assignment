using System;
namespace Books
{
    struct Book
    {
        public int bookId;
        public string title;
        public double price;
        public int code;
        enum bookType
        {
            Magazine = 0,
            Novel = 1,
            ReferenceBook = 2,
            Miscellaneous = 3
        }

        public void Accept()
        {
            Console.WriteLine("Enter the Book Id:");
            bookId=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Title:");
            title = (Console.ReadLine());
            Console.WriteLine("Enter the Price:");
            price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the code for Book Type:");
            code = int.Parse(Console.ReadLine());

        }

        public void Display()
        {
            Console.WriteLine("\n----------Details----------");
            Console.WriteLine("Book Id : "+bookId);
            Console.WriteLine("Book Title : " + title);
            Console.WriteLine("Book Price : " + price);
            Console.WriteLine("Book Type is:"+(bookType)code);
        }

        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Accept();
            book1.Display();


        }
    }
}