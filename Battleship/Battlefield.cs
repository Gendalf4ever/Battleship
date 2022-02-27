using System;

public class Battlfield                                                                             //Поле
{int[,] BF= new int [10,10];int x, y;
    public void initializeBF()
    {
        for (x = 0; x < 10; x++)
        {
            for (y = 0; y < 10; y++)
            {
                BF[x, y] = 0;
            }
        }

    }
        
    public void Ships(int xcord, int ycord)                                                         //Корабли
    {
        for (x = 0; x < 10; x++)
        {
            if (x == xcord)
            {
                for (y = 0; y < 10; y++)
                {
                    if (y == ycord)
                    { BF[x, y] = 4; }
                }
            }
        }
            for (x = 0; x < 10; x++)
            {
                for (y = 0; y < 10; y++)
                {
                    Console.Write(BF[x, y]);

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }


