using System;
namespace ConsoleApp2.StringClass
{ class StringApp{
        public void Show(){
            //字符串, 字符串连接
            string fname, lname;
            fname = "Rowan";
            lname = "Atkson";
            string fullname = fname + lname;
            Console.WriteLine("Full Name: {0}", fullname);
            //构造函数
            char[] letters = {'H', 'e', 'l', 'l', 'o'};
            string greetings = new String(letters);
            Console.WriteLine("Greetings: {0}", greetings);
                
            // 方法返回字符串
            string[] sarray = {"Hello", "From", "Tutorials", "Point"};
            string message = String.Join(" ", sarray);
            Console.WriteLine($"Message {message}");  
            //用于转换值得格式化方法
            DateTime waiting = new DateTime(2020, 9, 25, 13, 33, 24);
            string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("Message: {0}", chat);
        }
    }
}