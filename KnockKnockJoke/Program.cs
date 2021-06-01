using System;
using System.Collections.Generic;
using System.Linq;

namespace KnockKnockJoke
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> CorrectResponseOptions1 = new List<string>();
            List<string> CorrectResponseOptions2 = new List<string>();
            CorrectResponseOptions1.Add("Who's there?");
            CorrectResponseOptions1.Add("Who is there?");
            CorrectResponseOptions1.Add("Whose there?");//Accounts for misspelling

            CorrectResponseOptions2.Add("Terrible who?");


            Console.WriteLine("Knock! Knock!");
            string resp = Console.ReadLine();

            while (!IsThisCorrect(resp, CorrectResponseOptions1))
            {
                Console.WriteLine("Invalid Input.\nPlease re-enter.");
                resp = Console.ReadLine();
            }
            Console.WriteLine("Terrible.");
            resp = Console.ReadLine();
            while (!IsThisCorrect(resp, CorrectResponseOptions2))
            {
                Console.WriteLine("Invalid Input.\n Please re-enter.");
                resp = Console.ReadLine();
            }
            Console.WriteLine("Terrible who?\nThe terrible twos!");

        }


        public static bool IsThisCorrect(string response, List<string> correctResponseOptions)
        {
            if (correctResponseOptions.Contains(response, StringComparer.OrdinalIgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        //public static bool CorrectResponse1(string response)
        //{
        //    var rArray = response.Trim().Split();
        //    var fWord = rArray[0];
        //    var sWord = rArray[1];
        //    var x = "who's";
        //    var y = "who is";
        //    var z = "whose";//incorrect spelling but ok

        //    if (x.Equals(fWord, StringComparison.CurrentCultureIgnoreCase) || y.Equals(fWord, StringComparison.CurrentCultureIgnoreCase) || z.Equals(fWord, StringComparison.CurrentCultureIgnoreCase))
        //    {
        //        if (sWord.Equals("there?".Trim(), StringComparison.CurrentCultureIgnoreCase))
        //        {
        //            return true;



        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    else
        //    {
        //        return false;
        //    }

        //}

    }
}
