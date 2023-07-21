using System;
using System.Text;

namespace Arraylist_Stringbuilder_guessing_game
{
    class Program
    {
        int Guess = 0;
        int Target = 3;
        string Input = "";
        string[] Word = {
            "Red",
            "Blue",
            "Orange" };
        Random ran = new Random();

        public void guess()
        {
            Target = ran.Next(Word.Length);


            Console.Write( " What color is in my mind now ");
            for (int i = 0; i < Word.Length; i++)
            {
                if (i == (Word.Length - 1))
                    Console.Write("or " + Word[i] + "? ");
                else
                    Console.Write(Word[i] + ", ");
            }

            Input = Console.ReadLine();

            if (Input == Word[Target])
            {
                Console.WriteLine("Congratulations! You guessed it!");
            }
            else
            {
                Console.WriteLine("Wrong Guess");
                Console.WriteLine("Press enter to play again..............");
                Console.ReadLine();
                guess();
            }


            Console.ReadKey();
        }
            static void Main(string[] args)
            {
                StringBuilder qwe = new StringBuilder();
                qwe.Append("******");
                qwe.Append("Guessing Game");
                qwe.Append("******");
                Console.WriteLine(qwe);

                Console.WriteLine("Enter Name: ");

                string Name = Console.ReadLine();
                Console.WriteLine("*****");
                Console.WriteLine("Welcome Jerome to the Guessing Game: " + Name);

                Program g1 = new Program();
                g1.guess();








            }
        }
    }

