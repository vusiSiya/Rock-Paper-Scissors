using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Siyabonga Mahlalela
namespace RockPaperScissors_
{
    class Program
    {
        static int iUserPoints = 0, iComputerPoints =0; 
        static void Main(string[] args)
        {
            string sChoice;
            bool bCorrectInput = true;

            int i = 0;
            do
            {
                if (i < 1 || bCorrectInput == false)
                {
                    if (bCorrectInput ==false)
                    {
                        i *= 0;
                        bCorrectInput = true;
                        iComputerPoints *= 0;
                        iUserPoints *= 0;
                        
                    }                  
                    Console.WriteLine("\n\nHi, Welcome to my rock paper scissors game!");
                }

                i++;
                Console.Write("\nEnter your choice [{0}]: ", i);
                sChoice = Console.ReadLine();
                if (sChoice.ToLower() == "rock" || sChoice.ToLower() == "paper" || sChoice.ToLower() == "scissors")
                {
                    string sComptrChoice = GetRandomSelection();

                    Console.WriteLine("Computer Selection [{0}]: {1} ", i, sComptrChoice);
                    Console.WriteLine();

                    RoundWinner(sChoice.ToLower(), sComptrChoice.ToLower());
                    Console.WriteLine("-----------------------------");

                }
                else
                {
                    bCorrectInput = false;
                    Console.WriteLine("Invalid input, application will now start over");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (bCorrectInput == false || i < 5);

            Winner(iUserPoints, iComputerPoints);

            Console.WriteLine("Thank you!!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        static string GetRandomSelection()
        {
            string sRandomNo = "";
            int iRandomNo = 0;
            Random random = new Random();
            iRandomNo = random.Next(1,3);

            switch (iRandomNo)
            {
                case 1:
                    sRandomNo += "rock";
                    break;
                case 2:
                    sRandomNo += "paper";
                    break;
                case 3:
                    sRandomNo += "scissors";
                    break;
                default:
                    break;
            }
            return sRandomNo;
        }
        static void RoundWinner(string _sChoice, string _sComptrChoice)
        {         
            if ( (_sChoice == "rock" &&  _sComptrChoice == "paper") || (_sChoice == "paper" && _sComptrChoice == "scissors") || (_sChoice == "scissors" && _sComptrChoice == "rock"))
            {
                Console.WriteLine(" You lost");
                iComputerPoints++;
            }
            else if ((_sChoice == "paper" && _sComptrChoice == "rock") || (_sChoice == "scissors" && _sComptrChoice == "paper") || (_sChoice == "rock" && _sComptrChoice == "scissors"))
            {
                Console.WriteLine(" You Won! ");
                iUserPoints++;
            }
            else if ((_sChoice == "rock" && _sComptrChoice == "rock") || (_sChoice == "paper" && _sComptrChoice == "paper") || (_sChoice == "scissors" && _sComptrChoice == "scissors"))
            {
                Console.WriteLine(" It's a draw!!");
            }
            Console.WriteLine();
            Console.WriteLine("You:" + iUserPoints.ToString() + "\t\t Computer: " + iComputerPoints.ToString());

        }
        static void Winner(int _iUserPoints, int _iComputerPoints)
        {
            Console.Write("\n Overall score: {0} - {1} _ ", _iUserPoints, _iComputerPoints);
            
            if (_iUserPoints > _iComputerPoints)
            {
                Console.WriteLine("You won!!");
                Console.WriteLine("                        --------");
            }
            else if (_iUserPoints < _iComputerPoints)
            {
                Console.WriteLine("You Lost");
                Console.WriteLine("                        --------");
            }
            else if (_iUserPoints == _iComputerPoints)
            {
                Console.WriteLine("It's a draw!");
                Console.WriteLine("                      -----------");
            }
            
        }
    }
}
