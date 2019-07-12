using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace chatterBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Spiner spin = new Spiner();

            string[] Str = { "Project Name", "Project Author" };
            int f = 120;
            int middlePoint = f / 2;
            int TotalLinesCount = Str.Length + 3;

            for(int line = 0; line <=TotalLinesCount; line++)
            {
                if (line == 0 || line == TotalLinesCount)
                {
                    string str = "";
                    for (int x = 0; x < f; x++)
                    {

                        str = str + "#";
                    }
                    Console.Write(str);
                }else if (line == 1 || line == TotalLinesCount-1)
                {
                    string str = "";
                    for (int x = 0; x < f; x++)
                    {
                        if (x == 0)
                        {
                            str = "#";
                        }
                        else if (x == f - 1)
                        {
                            str = str + "#";
                        }
                        else
                        {
                            str = str + " ";
                        }
                    }
                    Console.Write(str);
                }
                else if( line >1|| line<TotalLinesCount-4)
                {
                    string toInclude = Str[line - 2];
                    Console.WriteLine(toInclude);
                }
            }
            Console.WriteLine("Press ESC key to quit");
            do
            {
                while (!Console.KeyAvailable)
                {
                    spin.Spin();
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }


    }
    public class Spiner
    {
        int cntr;
        public Spiner()
        {
            cntr = 0;
            Console.CursorVisible = false;
        }
        public void Spin()
        {
            //Console.CursorVisible = true;
            cntr++;
            switch (cntr % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(100);
        }
    }
}
