using System;
namespace CountDigits
{
    public class CountDigits
    {
        public static void Main()
        {
            const string MsgInput = "\nEnter a natural number to know how many digits does it have: ";
            const string MsgError = "== Error ==\nYou must enter a natural number\n";
            const string MsgDigits = "Your number '{0}' has {1} digits.";
            const string MsgUnexpectedError = "Unxpected Error";

            int num,newNum, counter;
            bool noError = false;

            do
            {
                Console.WriteLine(MsgInput);
                num = int.Parse(Console.ReadLine());

                if(num < 0)
                {
                    Console.WriteLine(MsgError);
                }
                else
                {
                    noError=true;
                    counter = 0;

                    if (num == 0)
                    {
                        counter = 1;
                    }
                    else if (num > 0)
                    {
                        newNum = num;
                        while (newNum > 0)
                        {
                            newNum /= 10;
                            counter++;
                        }
                    }
                    else
                    {
                        Console.WriteLine(MsgUnexpectedError);
                    }

                    Console.WriteLine(MsgDigits,num,counter);
                }
            }while(!noError);         
        }
    }
}