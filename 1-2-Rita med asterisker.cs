using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rita
{
    /// <summary>
    /// Applikationen ritar och färgar ett mönster, 39 kolumner
    /// och 25 rader, med asterisker. 
    /// </summary>
    class Program
    {
        /// <summary>
        /// Startpunkt för applikationen.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Title= "Rita Med Asterisker '*'";

            //Två "för" -satser används, där den ena "för" -satsen är nästlad i den andra.
            //Rader och kolumner skapas.
            //Beräknar och presenterar resultatet. 
            for (int row =0; row < 25; row++)
            {
               
                
                    for (int col =0; col < 39; col++)
                    {
                        Console.Write("* ");

                    }
                Console.WriteLine();

                    //En "if" -sats används för att skjuta in varannan rad.
                    if (row % 2 == 0)
                    {
                        Console.Write(" ");
                    }

                    //Satsen "switch" färgar raderna me de tre förbestämda färgerna.
                    switch (row % 3)
                    {
                        case 0:

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;

                        case 1:

                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;

                        case 2:

                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                }  
            }                    
        }
    }
}
              
