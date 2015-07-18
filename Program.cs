using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalityQuizDoro
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer;
            int result = 0;

            Console.WriteLine("Hello! Let's take a personality quiz!" + "\n");
            Console.WriteLine("Which 70s Show character are you?" + "\n");


            Console.WriteLine("Question 1: Would you consider yourself to be:");
            Console.WriteLine("1: Annoying" + "\n" + "2: Geeky" + "\n" + "3: Strict" + "\n" + "4: Witty" + "\n" + "5: Odd");
            answer = Convert.ToInt32(Console.ReadLine());
            result = result + answer;

            Console.WriteLine("Question 2: Which word best describes you:");
            Console.WriteLine("1: Conceited" + "\n" + "2: Clumsy" + "\n" + "3: Straight-Forward" + "\n" + "4: Rebellious" + "\n" + "5: Gullible");
            answer = Convert.ToInt32(Console.ReadLine());
            result = result + answer;

            Console.WriteLine("Question 3: What is more important to you:");
            Console.WriteLine("1: Being Pretty" + "\n" + "2: Being Brave" + "\n" + "3: Being Loyal" + "\n" + "4: Being Smart" + "\n" + "5: Being Friendly");
            answer = Convert.ToInt32(Console.ReadLine());
            result = result + answer;

            Console.WriteLine("Question 4:  Which trait describes your negative side:");
            Console.WriteLine("1: Selfish" + "\n" + "2: Socially Awkward" + "\n" + "3: Insensitive" + "\n" + "4: Disobedient" + "\n" + "5: Delusional");
            answer = Convert.ToInt32(Console.ReadLine());
            result = result + answer;

            Console.WriteLine("Question 5:  Which trait would you like to have:");
            Console.WriteLine("1: Spoiled" + "\n" + "2: Compassionate" + "\n" + "3: Loving" + "\n" + "4: Sarcastic" + "\n" + "5: Sweet");
            answer = Convert.ToInt32(Console.ReadLine());
            result = result + answer;

            //Console.WriteLine(result);

            if (result <= 9)
            {
                Console.WriteLine("You're Jackie Burkhart!");
            }

            else if (result >= 10 && result <= 14)
            {
                Console.WriteLine("You're Eric Forman!");
            }

            else if (result >= 15 && result <= 18)
            {
                Console.WriteLine("You're Red Forman!");
            }

            else if (result >= 19 && result <= 20)
            {
                Console.WriteLine("You're Steven Hyde!");
            }

            else if (result >= 21 && result <= 25)
            {
                Console.WriteLine("You're Fez!");
            }

            Console.ReadLine();
        }
    }
}
