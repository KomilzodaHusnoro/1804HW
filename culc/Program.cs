using System;

namespace culc
{
    class Calculator 
    {
        public static T Plus<T>(T First, T Second)
        {
            return (dynamic)First + (dynamic)Second; 
        }
        public static T Minus<T>(T First, T Second)
        {
            return (dynamic)First - (dynamic)Second; 
        }
        public static T Multyplication<T>(T First, T Second)
        {
            return (dynamic)First * (dynamic)Second; 
        }
        public static T Division<T>(T First, T Second)
        {
            return (dynamic)First / (dynamic)Second; 
        }
    }
    class Program
    {
        delegate T Rezult<T>(T First, T Second);
        static void Main(string[] args)
        {
            //System.Console.WriteLine("Enter first operand: ");
            //double First = double.Parse(Console.ReadLine());
            //System.Console.WriteLine("Enter second operand: ");
            //double Second = double.Parse(Console.ReadLine());
            double First = 5.5, Second = 3;

            System.Console.WriteLine("Choose operation:\nPush *1* --> to plus operands\nPush *2* --> to minus operands\n Push *3* to find multyplication\nPush *4* --> to divide them\n Your choise:");
            int choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1:
                Rezult<double> rez = new Rezult<double>(Calculator.Plus);
                Console.WriteLine(rez.Invoke(First,Second));
                break;
                // case 2:
                // Rezult<double> rez = new Rezult<double>(Calculator.Plus);
                // rez.Invoke(First,Second);
                // break;
                // case 3:
                // Rezult<double> rez = new Rezult<double>(Calculator.Plus);
                // rez.Invoke(First,Second);
                // break;
                // case 4:
                // Rezult<double> rez = new Rezult<double>(Calculator.Plus);
                // rez.Invoke(First,Second);
                // break;
            }
           
        }
    }
}
