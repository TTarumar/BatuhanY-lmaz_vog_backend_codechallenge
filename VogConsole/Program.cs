using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public static class QuestionClass
    {
        static List<string> NamesList = new List<string>()
        {
            "Jimmy",
            "jeffrey"
        };

        public static void TestQuestion()// Foreach is easier sytnax of This TestQuestion
        {
            using (var enumerator = NamesList.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    Console.WriteLine(enumerator.Current);// output of this method is "Jimmy" "Jeffery"
                }
            }
        }

        public static void Syntax()
        {
            foreach (var item in NamesList)
            {
                Console.WriteLine(item);
                /*output of this method is "Jimmy" "Jeffery" . 
                Their output is the same but this syntax is easier and more common than TestQuestion
                */

            }
        }

    }
}
