using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            Random numberGen = new Random();

            int even = 2 * numberGen.Next(10 + 2);
            Console.WriteLine("   ");

             Console.WriteLine(" Hi there, I am the Computaar...");
             synth.Speak("Hi there, I am the Computaar");

             Console.WriteLine("   ");
             Start:
             Console.WriteLine(" Please think of a number between 1 and 15..");
             synth.SpeakAsync("Please think of a number between 1 and 15..");

             Console.WriteLine("   ");

            System.Threading.Thread.Sleep(250);
            Console.WriteLine(" BUT do not tell anybody... okay lets press ENTER to continue..");
             synth.SpeakAsync("BUT do not tell a single soul... press ENTER to continue when you are ready");


             System.Threading.Thread.Sleep(250);
             Console.WriteLine(" ? ");
             synth.SpeakAsync(" press ENTER already");
             Console.WriteLine(" ? ");
             System.Threading.Thread.Sleep(150);
             synth.SpeakAsync(" get on with it");
             Console.Write(" ? ");
             Console.Write(" ? ");
             synth.SpeakAsync(" what are you waiting for, I have already processed a billion calculations");
             System.Threading.Thread.Sleep(450);
             Console.Write(" ?");
             System.Threading.Thread.Sleep(450);
             Console.Write(" ?");
             System.Threading.Thread.Sleep(450);
             Console.Write(" ?");
             System.Threading.Thread.Sleep(450);
             Console.Write(" ?");
             System.Threading.Thread.Sleep(450);
             Console.Write(" ?");
             System.Threading.Thread.Sleep(450);
             Console.Write(" ?");
             Console.ReadKey();
             synth.SpeakAsyncCancelAll();

             System.Threading.Thread.Sleep(150);
             Console.WriteLine(" | ");
             System.Threading.Thread.Sleep(150);
             Console.WriteLine(" | ");
             System.Threading.Thread.Sleep(150);
             Console.WriteLine(" | ");
             System.Threading.Thread.Sleep(150);
             Console.Write(" |  ");
             System.Threading.Thread.Sleep(150);
             Console.Write("-");
             System.Threading.Thread.Sleep(150);
             Console.Write("-");
             System.Threading.Thread.Sleep(150);
             Console.Write("-");
             System.Threading.Thread.Sleep(150);
             Console.Write("> \n");
             System.Threading.Thread.Sleep(250);
             Console.WriteLine(" \n  NExt \n ");
             Console.WriteLine("  Got Your number? ");
             synth.Speak("  Got Your number? ");
             Console.WriteLine("  ");
             Console.WriteLine(" Now times your number by 2 'in your head' ( 'Your number X 2' ) ..  ");
             synth.Speak("Now times your number by 2 'in your head' ( 'Your number times 2' ) ");

             Console.WriteLine("  ");          
             Console.WriteLine(" Hit ENTER when your done... and don't tell anybody your answer just yet..  ");
             synth.Speak("Hit ENTER when your done... and don't tell anybody your answer just yet, it's a secret.. ");

             Console.ReadKey();

             System.Threading.Thread.Sleep(150);
             Console.WriteLine(" | ");
             System.Threading.Thread.Sleep(150);
             Console.WriteLine(" | ");
             System.Threading.Thread.Sleep(150);
             Console.WriteLine(" | ");
             System.Threading.Thread.Sleep(150);
             Console.Write(" |  ");
             System.Threading.Thread.Sleep(150);
             Console.Write("-");
             System.Threading.Thread.Sleep(150);
             Console.Write("-");
             System.Threading.Thread.Sleep(150);
             Console.Write("-");
             System.Threading.Thread.Sleep(150);
             Console.Write("--");
             System.Threading.Thread.Sleep(150);
             Console.Write("> \n");
             System.Threading.Thread.Sleep(250);
             Console.WriteLine(" \n  NExt \n ");

             Console.WriteLine("   ");
             Console.WriteLine("   ");


             Console.WriteLine(" Now ADD " + even + " to your answer...  ");
             synth.Speak("Now ADD " + even + " to your answer and ");

             Console.WriteLine("   ");
             Console.WriteLine(" Hit ENTER when your done...  ");
             synth.Speak("Hit ENTER when your done messing around  ");

             Console.WriteLine("   ");
             Console.WriteLine("   ");
             Console.ReadKey();

             System.Threading.Thread.Sleep(150);
             Console.WriteLine(" | ");
             System.Threading.Thread.Sleep(150);
             Console.WriteLine(" | ");
             System.Threading.Thread.Sleep(150);
             Console.WriteLine(" | ");
             System.Threading.Thread.Sleep(150);
             Console.Write(" |  ");
             System.Threading.Thread.Sleep(150);
             Console.Write("-");
             System.Threading.Thread.Sleep(150);
             Console.Write("-");
             System.Threading.Thread.Sleep(150);
             Console.Write("--");
             System.Threading.Thread.Sleep(150);
             Console.Write("----");
             System.Threading.Thread.Sleep(150);
             Console.Write("> \n");
             System.Threading.Thread.Sleep(250);
             Console.WriteLine(" \n  NExt \n ");

             Console.WriteLine(" Okay, now divide your current answer by 2 ...  ");
             synth.Speak("Okay, now divide your current answer by 2 and go climb a tree  ");

             Console.WriteLine("   ");
             Console.WriteLine(" Hit ENTER when your done...  ");
             synth.Speak("Hit ENTER when your done being a smarty pants  ");

             Console.WriteLine("   ");
             Console.WriteLine("   ");
             Console.ReadKey();


             System.Threading.Thread.Sleep(150);
             Console.WriteLine(" | ");
             System.Threading.Thread.Sleep(150);
             Console.WriteLine(" | ");
             System.Threading.Thread.Sleep(150);
             Console.WriteLine(" | ");
             System.Threading.Thread.Sleep(150);
             Console.Write(" |  ");
             System.Threading.Thread.Sleep(150);
             Console.Write("--");
             System.Threading.Thread.Sleep(150);
             Console.Write("--");
             System.Threading.Thread.Sleep(150);
             Console.Write("---");
             System.Threading.Thread.Sleep(150);
             Console.Write("------");
             System.Threading.Thread.Sleep(150);
             Console.Write("> \n");
             System.Threading.Thread.Sleep(250);
             Console.WriteLine(" \n  NExt \n ");

             Console.WriteLine(" Okay we are making progress..  ");
             synth.Speak(" Okay we are making progress, very nice  ");
             Console.WriteLine("   ");
             Console.WriteLine("  Now subtract from your current answer, \n  the number that you thought of in the beginning ");
             synth.Speak(" Now subtract from your current answer, \n  the number that you thought of in the beginning ");
             Console.WriteLine("   ");
             Console.WriteLine(" Hit ENTER when your done...  ");
             synth.Speak("Hit ENTER when your ready to do so  ");

             Console.WriteLine("   ");
             Console.WriteLine("   ");
             Console.ReadKey();


             System.Threading.Thread.Sleep(150);
             Console.WriteLine(" | ");
             System.Threading.Thread.Sleep(150);
             Console.WriteLine(" | ");
             System.Threading.Thread.Sleep(150);
             Console.WriteLine(" | ");
             System.Threading.Thread.Sleep(150);
             Console.Write(" |  ");
             System.Threading.Thread.Sleep(150);
             Console.Write("--");
             System.Threading.Thread.Sleep(150);
             Console.Write("----");
             System.Threading.Thread.Sleep(150);
             Console.Write("----");
             System.Threading.Thread.Sleep(150);
             Console.Write("-------");
             System.Threading.Thread.Sleep(150);
             Console.Write("> \n");
             System.Threading.Thread.Sleep(250);
             Console.WriteLine(" \n  NExt \n ");


             Console.WriteLine(" Okay, your answer should be " + even / 2 + " ");
             synth.Speak(" Okay, your answer should be " + even / 2 + " ");
             System.Threading.Thread.Sleep(850);
             synth.Speak("are you happy now");
             Console.WriteLine(" Happy?  ");
             System.Threading.Thread.Sleep(850);
             synth.Speak("If so, then very nice. I am happy for you.");

             Console.WriteLine(" If your answer is not " + even / 2 + " then I will be happy to show you that I am correct...  ");
             System.Threading.Thread.Sleep(850);
             synth.SpeakAsync(" If your answer is not " + even / 2 + " then I will be happy to show you that I am correct...");

             
            Console.WriteLine(" ");
            Console.WriteLine(" Please press ENTER to allow me to show you the calculation...");
            Console.ReadKey();
            Console.WriteLine(" ");
           

            int sum;
            Console.WriteLine(" Please enter your number..");
            Console.WriteLine(" ");
            Console.Write(" ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            System.Threading.Thread.Sleep(850);
            int num2 = Convert.ToInt32(3);
            int sum2 = num1 *(2);
            sum = even + sum2;
            int sum3 = even + sum;
            int sum4 = sum / 2;
            int sum5 = sum4 - num1;
            /* num1 *2 +even /2 -num1 (=half even) */

            Console.Write(" This is how it is done..\n");
            Console.WriteLine("  my    number= " + even + " ");
            Console.WriteLine("  your  number= " + num1 + " ");
            Console.WriteLine();

            /* Multiplies user input by two */
            Console.Write("  Your number " + num1 + " x 2 = " + num1 * 2 + " \n");
            Console.WriteLine();

            /*Adds PC number to multiplied user input from previous line*/
            Console.Write("  " +num1 * 2 + " + " + even + " (my number) = " + sum + " \n");
            Console.WriteLine();

            Console.Write("  " + sum + " Devided by 2 = " + sum4 + " \n");
            Console.WriteLine();

            Console.Write("  " + sum4 + " Minus / subtract your number ( "+num1+ ") = " +sum5+ " \n");
            Console.WriteLine(" ");

            Console.WriteLine("The answer is "+sum5+"");
            Console.WriteLine(" ");
            Console.Write(" It's just how it is. ");
            Console.Write(".");
            System.Threading.Thread.Sleep(250);
            Console.Write(".");
            System.Threading.Thread.Sleep(250);
            Console.Write(".");
            System.Threading.Thread.Sleep(250);
            Console.Write(".");
            System.Threading.Thread.Sleep(250);
            Console.Write(".");
            System.Threading.Thread.Sleep(250);
            Console.WriteLine(" | ");
            System.Threading.Thread.Sleep(150);
            Console.WriteLine(" | ");
            System.Threading.Thread.Sleep(150);
            Console.WriteLine(" | ");
            System.Threading.Thread.Sleep(150);
            Console.Write(" |  ");
            System.Threading.Thread.Sleep(150);
            Console.Write("-");
            System.Threading.Thread.Sleep(150);
            Console.Write("-");
            System.Threading.Thread.Sleep(150);
            Console.Write("--");
            System.Threading.Thread.Sleep(150);
            Console.Write("> \n");
            System.Threading.Thread.Sleep(250);
            Console.WriteLine(" \n Feel free to play again ");
            System.Threading.Thread.Sleep(650);
            synth.Speak("Feel free to try again, just press enter to start again or else close the window by clicking on the x or alt plus f4");
            Console.ReadKey();

            goto Start;
            Console.WriteLine("   ");
            Console.WriteLine("   ");
            Console.WriteLine("   ");
        }
    }
}

