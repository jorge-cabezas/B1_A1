using System;
namespace NumberWithAttempts
{
    public class NumberWithAttempts
    {
        public static void Main()
        {
            const string MsgInput = "\nEnter a integer number to know if its in the pre-defined interval: ";
            const string MsgInside = "Is inside the interval.";
            const string MsgOutside = "\nNot inside the interval or not a valid number, {0} tries left.";
            const string MsgNoAttempts = "You ran out of tries.";
            const string MsgGameOver = "\n== GAME OVER ==";

            const int MinInterval = 2, MaxInterval = 30;
            const int MaxAttempts = 3;

            int value, attempts = 0;
            bool isInside = false;

            do
            {
                Console.Write(MsgInput);
                value = Convert.ToInt32(Console.ReadLine());

                if (value > MinInterval && value < MaxInterval)
                {
                    isInside = true;
                }
                else
                {
                    attempts++;
                    Console.WriteLine(attempts==MaxAttempts ? MsgNoAttempts : MsgOutside, MaxAttempts - attempts);
                }
            }while(attempts!=MaxAttempts && !isInside);
            
            
            if (isInside)
            {
                Console.WriteLine(MsgInside);                
            }
            else
            {
                Console.WriteLine(MsgGameOver);
            }
        }
    }
}