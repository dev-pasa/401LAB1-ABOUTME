using System;

namespace AboutMe
{
    class Program
    {
        static void Main(string[] args)
        {
            Ask();
        }

        static void Ask()
        {
            int count = 0;
            Console.WriteLine("Hi! My name is Dev and I am a learning software developer.");
            Console.WriteLine("I will ask you some questions to tell you about me.");
            try
            {
                Console.WriteLine("How old am I? Enter a number: ");
                string ageString = Console.ReadLine();
                int ageNum = Int32.Parse(ageString);
                if(ageNum > 30 || ageNum < 30)
                {
                    Console.WriteLine("Wrong guess!");
                }
                else if (ageNum == 30)
                {
                    Console.WriteLine("You are right");
                    count++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Wrong Format!!");
            }
            
            Console.WriteLine("Where do I live?");
            string location = Console.ReadLine();
            if(location == "Puyallup" || location == "Tacoma" || location == "tacoma" || location == "puyallup")
            {
                Console.WriteLine("You are right");
                count++;
            }
            else if(location != "Puyallup" || location != "Tacoma" || location != "tacoma" || location != "puyallup")
            {
                Console.WriteLine("Wrong guess!");
            }

            Console.WriteLine("Did I server in the Army?");
            string veteran = Console.ReadLine();
            Console.WriteLine($"Out of 5 questions, you got {count} right.");
        }


    }
    }

