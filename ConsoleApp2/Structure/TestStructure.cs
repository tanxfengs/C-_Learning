using System;
namespace ConsoleApp2.Structure
{

    struct Book{
        public string title;
        public string author;
        public string subject;
        public int book_id;
    }
    public class TestStructure
    {
        public static void Show(){
            Book Book1;
            Book Book2;

            //Book1 详细描述
            Book1.title = "C Programming";
            Book1.author = "Nuha Ali";
            Book1.subject = "C Programming";
            Book1.book_id = 6498407;

            //Book2 详细描述
            Book2.title = "Telecom";
            Book2.author = "Zara";
            Book2.subject = "Telecom Billing";

            //打印Book1信息
            Console.WriteLine($"Book1 title: {Book1.title}");
            Console.WriteLine($"Book1 author: {Book1.author}");
            Console.WriteLine($"Book1 subject: {Book1.subject}");
            Console.WriteLine($"Book1 book_id: {Book1.book_id}");

        }
    }
}