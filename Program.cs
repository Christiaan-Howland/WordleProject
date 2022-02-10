using System;

namespace WordleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Establish alphabet and guesser array
            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] final = "*****".ToCharArray();
            Console.WriteLine("For letters where you know what and where they are, input as a capital letter.");
            Console.WriteLine("If you know the letter is somewhere in the word, input it as a lower case letter.");
            Console.WriteLine( "If you don't know a letter input a dash.");
            Console.WriteLine("INPUT::");

            //Pass input to character array
            string word = Console.ReadLine();
            char[] letters = word.ToCharArray();
            char one = letters[0];
            char two = letters[1];
            char three = letters[2];
            char four = letters[3];
            char five = letters[4];
            /* Output testing
            Console.WriteLine(one);
            Console.WriteLine(two);
            Console.WriteLine(three);
            Console.WriteLine(four);
            Console.WriteLine(five);
            */
            Console.WriteLine("-----PROCESSING NOW-----");
            
            // lol
            bool test = char.IsUpper(one);
            bool test2 = char.IsUpper(two);
            bool test3 = char.IsUpper(three);
            bool test4 = char.IsUpper(four);
            bool test5 = char.IsUpper(five);

            //There has to be a better way to do this. I've only learned like 20 hours of C#, please forgive StackOverflow gods.
            if (test == true)
            {
                Console.WriteLine("Checking 1::");
                Console.WriteLine("Substituting 1::");
                final[0] = one;
                Console.WriteLine(final);

            } else {
                Console.WriteLine("1 = Blank");
            }


            if (test2 == true)
            {
                Console.WriteLine("Checking 2::");
                Console.WriteLine("Substituting 2::");
                final[1] = two;
                Console.WriteLine(final);

            } else {
                Console.WriteLine("2 = blank");
            }


            if (test3 == true)
            {
                Console.WriteLine("Checking 3::");
                Console.WriteLine("Substituting 3::");
                final[2] = three;
                Console.WriteLine(final);

            } else {
                Console.WriteLine("3 = blank");
            }


            if (test4 == true)
            {
                Console.WriteLine("Checking 4::");
                Console.WriteLine("Substituting 4::");
                final[3] = four;
                Console.WriteLine(final);

            } else {
                Console.WriteLine("4 = blank");
            }


            if (test5 == true)
            {
                Console.WriteLine("Checking 5::");
                Console.WriteLine("Substituting 5::");
                final[4] = five;
                Console.WriteLine(final);

            } else {
                Console.WriteLine("5 = blank");
            }




            for (int i = 1; i <=26; i++) {
                
                Console.WriteLine("yep");
            }




        }
    }
}
