using System;

namespace ArrayMaximum
{
    public class Program
    {
        static void Main(string[] args)
        {
            //MAXIMUM
            int[] arraymax = new int[] {1,2,3,4,5};
            int maxZahl = arraymax[0]; //MaxZahl ist beim Start Index 0
            

            for (int i = 0; i < arraymax.Length; i++)
            {
                if(arraymax[i] > maxZahl)//Wenn der Wert des ArrayIndex größer als MaxZahl ist
                {
                    maxZahl = arraymax[i];
                }
               
            }
            if (maxZahl == 5)
            {
                Console.WriteLine($" Die größte Zahl lautet {maxZahl} ");
            }
            else Console.WriteLine(" Fehler ");

            //MINIMUM
            int[] arraymin = new int[] { 1, 2, 3, 4, 5 };
            int minZahl = arraymin[0]; //MinZahl ist beim Start Index 0


            for (int i = 0; i < arraymin.Length; i++)
            {
                if (arraymin[i] < minZahl)//Wenn der Wert des ArrayIndex kleiner als MinZahl ist
                {
                    minZahl = arraymin[i];
                }

            }
            if (minZahl == 1)
            {
                Console.WriteLine($" Die kleinste Zahl lautet {minZahl} ");
            }
            else Console.WriteLine(" Fehler ");

            //GET HEAD
            int[] arrayhead = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine($"Der Head lautet: {arrayhead[0]}");//Index 0

            //GET TAIL
            //Neue Array: index -1
            int[] arraytail = new int[] { 1, 2, 3, 4, 5 };

        }
    }
}
