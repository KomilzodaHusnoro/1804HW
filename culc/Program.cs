using System;

namespace culc
{
    class Program
    {
        public static T Plus<T>(T First, T Second)
        {
            return (dynamic)First + (dynamic)Second; 
        }
        public static T Minus<T>(T First, T Second)
        {
            return (dynamic)First - (dynamic)Second; 
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("Choose operation:\nPush *1* --> to plus operands\nPush *2* --> to minus operands\n Push *3* to find multyplication\nPush *4* --> to divide them\n Your choise:");
            int choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1:
                break;
                case 2:
                break;
                case 3:
                break;
                case 4:
                break;
            }
           
        }
    }
}
