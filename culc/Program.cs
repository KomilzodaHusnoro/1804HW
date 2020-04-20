using System;

namespace culc
{
    class Program
    {
        public T Plus<T>(T First, T Second)
        {
            return (dynamic)First + (dynamic)Second; 
        }
        
        static void Main(string[] args)
        {
            
            Console.WriteLine();
        }
    }
}
