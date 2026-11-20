using System;
namespace CheckInterval
{
    public class CheckInterval
    {
        public static void Main()
        {
            const string MsgInput = "Enter a number to know if its in the pre-defined interval:";
            const string MsgInside = "Is inside the interval.";
            const string MsgOutside = "Is outside the interval.";

            const int MinInterval = 5, MaxInterval = 50;

            int value;
            bool isInside = false;

            Console.WriteLine(MsgInput);
            value = Convert.ToInt32(Console.ReadLine());

            if (value > MinInterval && value < MaxInterval)
            {
                isInside = true;
            }
            
            if (isInside)
            {
                Console.WriteLine(MsgInside);                
            }
            else
            {
                Console.WriteLine(MsgOutside);
            }
        }
    }
}