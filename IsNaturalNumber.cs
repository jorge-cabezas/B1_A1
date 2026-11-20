
using System;
namespace IsNaturalNumber
{
    public class IsNaturalNumber
    {
        public static void Main()
        {
            const string MsgInput = "Enter a number to know if its a natural";
            const string MsgOk = "Is a natural number.";
            const string MsgNotOk = "Is NOT a natural number.";

            int value;
            bool isNatural = false;

            Console.WriteLine(MsgInput);
            value = Convert.ToInt32(Console.ReadLine());

            if (value >= 0)
            {
                isNatural = true;
            }
            
            if (isNatural)
            {
                Console.WriteLine(MsgOk);                
            }
            else
            {
                Console.WriteLine(MsgNotOk);
            }
        }
    }
}