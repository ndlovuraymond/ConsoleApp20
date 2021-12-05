using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            string A = " ";
            string B = " ";
            string C = " ";
            string D = " ";
            string E = " ";
            string F = " ";
            string G = " ";
            string H = " ";
            string I = " ";
            int J = 1;
            string choice = "";
            string move = " ";
            bool TicTac = true;
            string Menu = " ";
            string quitchoice = " ";
            do
            {
                Console.WriteLine("1. New game \n" + "2. About the Author \n" + "3. Exit");
                Console.Write("> ");
                Menu = Console.ReadLine();
                switch (Menu)
                {
                    case "1":
                        Console.WriteLine("Welcome To Tic Tac Toe!");
                        Console.WriteLine($"   |   |  \n" + "---+---+--- \n" + $"   |   |  \n" +
                                  "---+---+--- \n" + $"   |   |  \n");
                        do
                        {
                            if (J % 2 == 0)
                                move = "O";
                            else
                                move = "X";

                            Console.Write(move + "'s move > ");
                            choice = Console.ReadLine();
                            switch (choice)
                            {
                                case "1": if (A == " ") A = move; break;
                                case "2": if (B == " ") B = move; break;
                                case "3": if (C == " ") C = move; break;
                                case "4": if (D == " ") D = move; break;
                                case "5": if (E == " ") E = move; break;
                                case "6": if (F == " ") F = move; break;
                                case "7": if (G == " ") G = move; break;
                                case "8": if (H == " ") H = move; break;
                                case "9": if (I == " ") I = move; break;
                                default: Console.Write("Illegal move!Try Again! \n "); continue;

                            }


                            Console.WriteLine($" {A} | {B} | {C} \n" + "---+---+--- \n" + $" {D} | {E} | {F} \n" +
                                  "---+---+--- \n" + $" {G} | {H} | {I} \n"); J++;
                            if (A == B && B == C && A != " " ||
                             D == E && E == F && F != " " ||
                             G == H && H == I && I != " " ||
                             A == D && D == G && G != " " ||
                             B == E && E == H && H != " " ||
                             C == F && F == I && C != " " ||
                             A == E && E == I && E != " " ||
                             C == E && E == G && G != " "
                             )
                            {
                                Console.WriteLine(move + " won game!"); break;
                            }
                            if (A != " " && B != " " && C != " " && D != " " && E != " " && F != " " && G != " " &&
                                H != " " && I != " " )
                            { Console.WriteLine("Tie!"); break; }

                        } while (J < 10);
                        do
                        {
                            Console.Write("Press any key to return to the main menu.");
                            Console.ReadKey();
                            Console.Clear();
                        } while (J == 9);
                        continue;

                    case "2":
                        Console.Write("Raymond Ndlovu is a 21 year old Computer Science Student at WSB Poznan. \n"
                  + "(Press any key to return to Menu)");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Console.WriteLine("Are you sure you want to quit? [y/n]");
                        Console.Write(">  ");
                        quitchoice = Console.ReadLine();
                        if (quitchoice == "y")
                            return;
                        if (quitchoice == "Y")
                            return;
                        Console.Clear();
                        break;

                }
                ;
            } while (TicTac = true);

        }
    }
}
