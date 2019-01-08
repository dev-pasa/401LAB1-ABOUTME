using System;

namespace AboutMe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask();
            Ask();
        }

       

        static void Ask()
        {
            int count = 0;
            Console.WriteLine("Hi! My name is Dev and I am a learning software developer.");
            Console.WriteLine("I will ask you some questions to tell you about me.");

            try
            {   //Question 1       
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
            catch (Exception)
            {
                Console.WriteLine("Wrong Format!!");
            }

            //Question 2  
            Console.WriteLine(" ");
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

            //Question 3
            Console.WriteLine(" ");
            Console.WriteLine("Did I server in the Army?");
            Console.WriteLine("Option 1 - I did");
            Console.WriteLine("Option 2 - No I did not");
            Console.Write("Enter your selection. Either 1 or 2: ");
            string userInt = Console.ReadLine();
            int userSelect = Int32.Parse(userInt);

            try
            {
                
                if(userSelect == 1)
                {
                    Console.WriteLine("Your are right");
                    count++;
                }
                else if(userSelect == 2)
                {
                    Console.WriteLine("Your are wrong");
                }
                else
                    {
                    Console.WriteLine("Wrong input");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid option [1,2].");
            }

            //Question 4  
            Console.WriteLine(" ");
            Console.WriteLine("What sports do I watch the most?");
            Console.WriteLine("Option 1 - Soccer");
            Console.WriteLine("Option 2 - Football");
            Console.WriteLine("Option 3 - Basketball");
            Console.Write("Enter your selection: ");
            string userIputGame = Console.ReadLine();
            int userGameInt = Int32.Parse(userIputGame);

            try
            {

                if (userGameInt == 1)
                {
                    Console.WriteLine("Your are right");
                    count++;
                }         
                else
                {
                    Console.WriteLine("Wrong answer");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid option [1,2].");
            }


            try
            {   //Question 5  
                Console.WriteLine(" ");
                Console.WriteLine("What do I enjoy most about programming?");
                Console.WriteLine("Option 1 - Team work"); 
                Console.WriteLine("Option 2 - Problem Solving");
                Console.WriteLine("Option 3 - Career Porgression");
                Console.Write("Enter your selection: ");
                string codingSelect = Console.ReadLine();
                int codingInt = Int32.Parse(codingSelect);
                if (codingInt == 2)
                {
                    count++;
                    Console.WriteLine("Correct Answer");
                }
                else if (codingInt == 1 || codingInt == 3)
                {
                    Console.WriteLine("Wrong answer.");   
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong Format!!");
            }


            Console.WriteLine($"Out of 5 questions, you got {count} right.");



        }


    }
    }

