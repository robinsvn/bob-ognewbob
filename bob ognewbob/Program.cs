using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace bob_ognewbob
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //fjerne alt fra siste b-en i bob og til venstre
            //søk i kortere string for gang counter++
            //stringen må bli lik ny string
            //hvilke metoder?

            //oppgave 1
            //kjør programmet for å se om alt er ok
            //alt fungerer som det skal.

            //oppgave 2
            //Let etter gunnar og ikke bob. hva skjer? må noe endres?
            //while loopen som har "(bob.Contains("bob")) må forandres til (bob.Contains("gunnar")), og hvor = bob.IndexOf("bob"); må forandres til hvor = bob.IndexOf("gunnar");

            //Oppgave 3
            //ikke let etter gunnar mer. endre tilbake til bob.
            //stringen bob skal leses inn fra en fil https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-read-from-a-text-file
            //lag en stooor textfil. tar det lang tid? lag en enda større fil. test på nytt. fortsett. hvor stor fil kan vi ha? 
            //Med en tekstfil på 400kb så tok det 30 sekunder før jeg fikk svaret.

            //oppgave 4
            //ta tiden på dette. Bruk datetime og datediff https://www.tutorialsteacher.com/articles/get-difference-between-two-dates-in-csharp
            // 27 sekunder

            //oppgave 5
            //istedfor å ha alt i main, lag en metode av dette. Hva det letes etter og i hvor det letes skal være parametre. Returtype int

            //oppgave 6
            //lag en metode som heter KlassiskBob. Det er denne bobløsningen som bruker for loops
            //ta tiden på denne og avansert bob. hvem er raskest? her er det viktig at det er samme inputfil som brukes.


            // Declare two dates
            var TimeStart = DateTime.Now;

            int counter = 0;
            string bob = System.IO.File.ReadAllText(@"C:\Users\Robin\source\repos\bobbern.txt"); //lese inn fra fil
            string newBob = "";
            int hvor = 0;
            while (bob.Contains("bob"))
            //if (bob.Contains("bob"))
            {
                hvor = bob.IndexOf("bob");
                newBob = bob.Substring(hvor + 3, bob.Length - hvor - 3);//overwrite bob
                bob = newBob;
                counter++;
            }


            Console.WriteLine(counter);

            var TimeStop = DateTime.Now;
            var diffOfDates = TimeStop - TimeStart;
            Console.WriteLine("Difference in Seconds: {0}", diffOfDates.Seconds);

            Console.ReadLine();

        }
    }
}
