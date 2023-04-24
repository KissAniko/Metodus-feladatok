using System;
using System.IO;

namespace gyakorlo_4
{
    class Program
    {

        const char tengerJel = '*';
        static void General(char [,] terkep)
        {
            for (int sor = 0; sor < terkep.GetLength(0); sor++)
            {
                
                for (int oszlop = 0; oszlop < terkep.GetLength(1); oszlop++)
                {                    
                     terkep[sor, oszlop] = tengerJel;                                                                                  
                }
            }
        }
        static void Megjelenit( char [,] terkep)
        {
            for (int sor = 0; sor < terkep.GetLength(0); sor++)
            {
                for (int oszlop = 0; oszlop < terkep.GetLength(1); oszlop++)
                {
                    
                    Console.Write(terkep[sor, oszlop]);
                }
                    Console.WriteLine();
            }
        }
        
        static void Main(string[] args)
        {

            char[,] terkep = new char[10,20];
            General(terkep);
            Megjelenit(terkep);
            
                    Console.WriteLine("Adja meg a sorok számát:");
                    int sorSzam = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Adja meg az oszlopok számát:");
                    int oszlopSzam = Convert.ToInt32(Console.ReadLine());
                    terkep= General(sor, oszlop, tengerJel);
            {
                    Console.WriteLine(terkep );

            }
                   
                                
            
        }
            





    }
}

