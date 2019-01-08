using System;

namespace AboutMe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pass Ask() method inside Main, Ask() includes other sub methods that is passed into it;
            Ask();
            Console.ReadKey();
        }

        static void Ask()
        {
            int count=0;
            Console.WriteLine("Hi! My name is Dev and I am a learning software developer.");
            Console.WriteLine("I will ask you some questions to tell you about me.");

            //Question 1
            bool ageAsk = AgeAsk();
            if(ageAsk == true)
            {
                count++;
            }
            
            //Question 2
            string location = LocQuestion();
            if(location == "Puyallup" || location == "Tacoma" || location == "tacoma" || location == "puyallup")
            {
                count++;
            }

            //Question 3
            int armyServe = ArmyServer();
            if(armyServe == 1)
            {
                count++;
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

            Console.WriteLine();
            Console.WriteLine($"Out of 5 questions, you got {count} right.");

        }

        static bool AgeAsk()
        {
            try
            {   //Question 1       
                Console.WriteLine("How old am I? Enter a number: ");
                string ageString = Console.ReadLine();
                int ageNum = Int32.Parse(ageString);
                if (ageNum > 30 || ageNum < 30)
                {
                    Console.WriteLine("Wrong guess!");
                }
                else if (ageNum == 30)
                {
                    Console.WriteLine("You are right");
                    return true;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong Format!!");
            }
            return false;
        }

        static string LocQuestion()
        {
            //Question 2  
            Console.WriteLine(" ");
            Console.WriteLine("Where do I live?");
            string location = Console.ReadLine();
            if (location == "Puyallup" || location == "Tacoma" || location == "tacoma" || location == "puyallup")
            {
                Console.WriteLine("You are right");
               
            }
            else if (location != "Puyallup" || location != "Tacoma" || location != "tacoma" || location != "puyallup")
            {
                Console.WriteLine("Wrong guess!");
            }
            return location;
        }

        static int ArmyServer()
        {

            //Question 3
            Console.WriteLine(" ");
            Console.WriteLine("Did I server in the Army?");
            Console.WriteLine("Option 1 - I did");
            Console.WriteLine("Option 2 - No I did not");
            Console.Write("Enter your selection. Either 1 or 2: ");
            string userInt = Console.ReadLine();
            int userSelect = Int32.Parse(userInt);
            int answer = 0;

            try
            {

                if (userSelect == 1)
                {
                    Console.WriteLine("Your are right");
                   answer = 1;
                }
                else if (userSelect == 2)
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
            return answer;
        }
    }
    }

