using System;

namespace KonsollApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hei, hva heter du?");
            var tekst = Console.ReadLine();
            Console.WriteLine("Velkommen " + tekst);

        }
    }
}


/* Oppgave: 

Lag en konsoll-app som skriver til konsollen "Hei, hva heter du?", 
deretter leser inn input fra bruker og til slutt printer ut "Velkommen + det brukeren skrev".

Eksempel:

Hei, hva heter du?

Joakim

Velkommen Joakim!

*/


/* Huskelapp

Console.Write(); - is used to output/print text on the same line.
Console.WriteLine("Hello World!"); - is used to output/print text on a new line each time.

Read(returns an int) or Console.Read(); - reads only one single character from the standard input stream. 
Similar to ReadKey except that it returns an integer. 
It returns the next character from the input stream, or returns (-1) if there is no more character to be read.

ReadLine(returns a string) or Console.ReadLine(); - (is used to get user input) reads a single line from the standard input stream or the command line. 
As an example, it can be used to ask the user enter their name or age. 
It reads all the character till we press enter.

ReadKey(returns a character) or Console.ReadKey(); - reads only one single character from the standard input stream or command line. 
Usually used when you're giving options to the user in the console to select from, such as select A, B or C. 
Another prominent example, Press Y or n to continue.

 */