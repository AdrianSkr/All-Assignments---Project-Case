using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bog_Opgave
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Bog
            Bog voresBog = new Bog
            {
                Forfatter = "J.K. Rowling",
                Title = "Harry Potter",
                Year = 2001,
                Pages=759
            };

            //Bog voresBog1 = new Bog("JK", "Harry", 2002, Bog.Cover.hardcover);
            #endregion

            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.SetCursorPosition(5, 5);
            Console.WriteLine("Vores forfatter hedder {0}.", voresBog.Forfatter);
            Console.SetCursorPosition(5, 6);
            Console.WriteLine("Hun har skrevet {0}.", voresBog.Title);
            Console.SetCursorPosition(5, 7);
            Console.WriteLine("Bogen er på {0} sider.", voresBog.Pages);
            Console.SetCursorPosition(5, 8);
            Console.WriteLine("Bogen er af {0}.", voresBog.cover);
            Console.SetCursorPosition(5, 10);
            Console.WriteLine("Skrevet i: {0}.", voresBog.Year);

        }

        struct Bog
        {
            public string Forfatter, Title;
            public int Year, Pages;

            public Cover cover;
            public enum Cover {hardcover, paperback, ebog, lydbog}

            //private Vudering vurdering;
            //private enum Vudering {one, two, three, four, five}

            public Bog(string f, string t, int y, Cover c1, int p)

            {
                Forfatter = f;
                Title = t;
                Year = y;
                cover= c1;
                Pages = p;
                //vurdering = v1; //Vurdering v1
            }










            /*private AuthenticationMethod(int pages, String title)
            {
                this.title = title;
                this.pages = pages;
            }

            public override String ToString()
            {
                return Title;
            }
            */
        }
    }
}