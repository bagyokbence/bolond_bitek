using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torpedo
{
    class Program
    {
        static void Main(string[] args)
        {
            int hajokszama = 0;
            int ki = 0;
            Console.WriteLine("Üdvözöllek!");
            Console.Write("Add meg a tábla méretét: ");
            int meret = Convert.ToInt16(Console.ReadLine());
            int[,] tomb = new int[meret + 2, meret + 2];
            while (ki == 0)
            {
                for (int i = 1; i < meret + 1; i++)
                {
                    for (int j = 1; j < meret + 1; j++)
                    {
                        Console.Write(tomb[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Kell-e még hajó? | 0 - nem | 1 - igen");
                int valasz = Convert.ToInt16(Console.ReadLine());

                if (valasz == 0)
                {
                    if (hajokszama < 1)
                    {
                        Console.WriteLine("Minimum kell egy hajó!");
                    }
                    if (hajokszama >= 1)
                    {
                        ki++;
                    }
                }
                if (valasz == 1)
                {
                    int hajomeret = 0;
                    int jo2 = 0;
                    while (jo2 != 1)
                    {
                        Console.Write("Add meg a hajó méretét: ");
                        hajomeret = Convert.ToInt16(Console.ReadLine());
                        if (hajomeret >= meret)
                        {
                            Console.WriteLine("Ez nem lehetséges. Próbáld újra!");
                        }
                        else
                        {
                            jo2 = 1;
                        }
                    }
                    Console.WriteLine("Add meg a hajó pozícióját: | 1 - függőleges | 2 - vízszintes | 3 - mégse");
                    int pozicio = Convert.ToInt16(Console.ReadLine());
                    if (pozicio == 1 || pozicio == 2)
                    {
                        Console.WriteLine("Add meg a hajó koordinátáit: ");
                        string hajopozicio = Console.ReadLine();
                        int hajooszlop = 0;
                        if (hajopozicio[0] == 'A')
                        {
                            hajooszlop = 1;
                        }
                        if (hajopozicio[0] == 'B')
                        {
                            hajooszlop = 2;
                        }
                        if (hajopozicio[0] == 'C')
                        {
                            hajooszlop = 3;
                        }
                        if (hajopozicio[0] == 'D')
                        {
                            hajooszlop = 4;
                        }
                        if (hajopozicio[0] == 'E')
                        {
                            hajooszlop = 5;
                        }
                        if (hajopozicio[0] == 'F')
                        {
                            hajooszlop = 6;
                        }
                        if (hajopozicio[0] == 'G')
                        {
                            hajooszlop = 7;
                        }
                        if (hajopozicio[0] == 'H')
                        {
                            hajooszlop = 8;
                        }
                        if (hajopozicio[0] == 'I')
                        {
                            hajooszlop = 9;
                        }
                        if (hajopozicio[0] == 'J')
                        {
                            hajooszlop = 10;
                        }
                        if (hajopozicio[0] == 'K')
                        {
                            hajooszlop = 11;
                        }
                        if (hajopozicio[0] == 'L')
                        {
                            hajooszlop = 12;
                        }
                        if (hajopozicio[0] == 'M')
                        {
                            hajooszlop = 13;
                        }
                        if (hajopozicio[0] == 'N')
                        {
                            hajooszlop = 14;
                        }
                        if (hajopozicio[0] == 'O')
                        {
                            hajooszlop = 15;
                        }
                        if (hajopozicio[0] == 'P')
                        {
                            hajooszlop = 16;
                        }
                        int hajosor = 0;
                        if (hajopozicio[1] == '1')
                        {
                            hajosor = 1;
                        }
                        if (hajopozicio[1] == '2')
                        {
                            hajosor = 2;
                        }
                        if (hajopozicio[1] == '3')
                        {
                            hajosor = 3;
                        }
                        if (hajopozicio[1] == '4')
                        {
                            hajosor = 4;
                        }
                        if (hajopozicio[1] == '5')
                        {
                            hajosor = 5;
                        }
                        if (hajopozicio[1] == '6')
                        {
                            hajosor = 6;
                        }
                        if (hajopozicio[1] == '7')
                        {
                            hajosor = 7;
                        }
                        if (hajopozicio[1] == '8')
                        {
                            hajosor = 8;
                        }
                        if (hajopozicio[1] == '9')
                        {
                            hajosor = 9;
                        }
                        if (pozicio == 1)
                        {
                            int jo = 0;
                            if (meret - (hajooszlop - 1) >= hajomeret)
                            {
                                jo = 1;
                            }
                            else
                            {
                                Console.WriteLine("Ide nem rakhatsz hajót! Próbáld újra!");
                            }
                            if (jo == 1)
                            {
                                int jo3 = 0;
                                int jo4 = 0;
                                int hajosor2 = hajosor;
                                int hajooszlop2 = hajooszlop;
                                for (int i = 1; i < hajomeret + 1; i++)
                                {
                                    if (tomb[hajosor2, hajooszlop] == 0)
                                    {
                                        hajosor2++;
                                        jo3++;
                                    }
                                }
                                if (jo3 == hajomeret)
                                {
                                    jo4 = 1;
                                }
                                if (jo4 == 1)
                                {
                                    for (int i = 1; i < hajomeret + 1; i++)
                                    {
                                        tomb[hajosor, hajooszlop] = 1;
                                        if (tomb[hajosor - 1, hajooszlop - 1] == 0)
                                        {
                                            tomb[hajosor - 1, hajooszlop - 1] = 2;
                                        }
                                        if (tomb[hajosor - 1, hajooszlop] == 0)
                                        {
                                            tomb[hajosor - 1, hajooszlop] = 2;
                                        }
                                        if (tomb[hajosor - 1, hajooszlop + 1] == 0)
                                        {
                                            tomb[hajosor - 1, hajooszlop + 1] = 2;
                                        }
                                        if (tomb[hajosor, hajooszlop - 1] == 0)
                                        {
                                            tomb[hajosor, hajooszlop - 1] = 2;
                                        }
                                        if (tomb[hajosor, hajooszlop + 1] == 0)
                                        {
                                            tomb[hajosor, hajooszlop + 1] = 2;
                                        }
                                        if (tomb[hajosor + 1, hajooszlop - 1] == 0)
                                        {
                                            tomb[hajosor + 1, hajooszlop - 1] = 2;
                                        }
                                        if (tomb[hajosor + 1, hajooszlop] == 0)
                                        {
                                            tomb[hajosor + 1, hajooszlop] = 2;
                                        }
                                        if (tomb[hajosor + 1, hajooszlop + 1] == 0)
                                        {
                                            tomb[hajosor + 1, hajooszlop + 1] = 2;
                                        }
                                        hajosor++;
                                    }
                                    hajokszama++;
                                }
                                else
                                {
                                    Console.WriteLine("Ide nem rakhatsz hajót! Próbáld újra!");
                                }
                            }
                        }
                        if (pozicio == 2)
                        {
                            int jo = 0;
                            if (meret - (hajooszlop - 1) >= hajomeret)
                            {
                                jo = 1;
                            }
                            else
                            {
                                Console.WriteLine("Ide nem rakhatsz hajót! Próbáld újra!");
                            }
                            if (jo == 1)
                            {
                                int jo3 = 0;
                                int jo4 = 0;
                                int hajosor2 = hajosor;
                                int hajooszlop2 = hajooszlop;
                                for (int i = 1; i < hajomeret + 1; i++)
                                {
                                    if (tomb[hajosor2, hajooszlop2] == 0)
                                    {
                                        hajooszlop2++;
                                        jo3++;
                                    }
                                }
                                if (jo3 == hajomeret)
                                {
                                    jo4 = 1;
                                }
                                if (jo4 == 1)
                                {
                                    for (int i = 1; i < hajomeret + 1; i++)
                                    {
                                        tomb[hajosor, hajooszlop] = 1;
                                        if (tomb[hajosor - 1, hajooszlop - 1] == 0)
                                        {
                                            tomb[hajosor - 1, hajooszlop - 1] = 2;
                                        }
                                        if (tomb[hajosor - 1, hajooszlop] == 0)
                                        {
                                            tomb[hajosor - 1, hajooszlop] = 2;
                                        }
                                        if (tomb[hajosor - 1, hajooszlop + 1] == 0)
                                        {
                                            tomb[hajosor - 1, hajooszlop + 1] = 2;
                                        }
                                        if (tomb[hajosor, hajooszlop - 1] == 0)
                                        {
                                            tomb[hajosor, hajooszlop - 1] = 2;
                                        }
                                        if (tomb[hajosor, hajooszlop + 1] == 0)
                                        {
                                            tomb[hajosor, hajooszlop + 1] = 2;
                                        }
                                        if (tomb[hajosor + 1, hajooszlop - 1] == 0)
                                        {
                                            tomb[hajosor + 1, hajooszlop - 1] = 2;
                                        }
                                        if (tomb[hajosor + 1, hajooszlop] == 0)
                                        {
                                            tomb[hajosor + 1, hajooszlop] = 2;
                                        }
                                        if (tomb[hajosor + 1, hajooszlop + 1] == 0)
                                        {
                                            tomb[hajosor + 1, hajooszlop + 1] = 2;
                                        }
                                        hajooszlop++;
                                    }
                                    hajokszama++;

                                }
                                else
                                {
                                    Console.WriteLine("Ide nem rakhatsz hajót! Próbáld újra!");
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Nem jó választás - próbáld újra!");
                }
            }
        }
    }
}
