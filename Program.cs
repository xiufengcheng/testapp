using System;

namespace testapp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a = 5;
            if(a<10)
            {
               Console.WriteLine("this is my first line");  
            }
            else
            {
               Console.WriteLine("this is my second line");
               Console.Beep(1000,1000); //发出一个蜂鸣声
            }
           

        }
    }
}
