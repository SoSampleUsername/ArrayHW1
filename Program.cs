using System;

namespace ArrayHW1
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;            
            
            static int ReadSize(string q)
            {
                bool @continue = true;
                int size;
                do
                {
                    Console.WriteLine("Size:");
                    string input = (Console.ReadLine());
                    @continue = !int.TryParse(input, out size);
                }
                while (@continue || size < 0);
                return size;
            }
            
            static void ShowArray(int arraySize, int[,] myMassive)
            {
                
                for (int i = 0; i < arraySize; i++)
                {
                    Console.WriteLine();
                    for (int k = 0; k < arraySize; k++)
                    {                        
                        Console.Write("{0}\t", myMassive[i, k]);
                    }
                }
                Console.WriteLine("\n");
            }
            //----------------------------------------------------------------
            static int[,] Task1(int size)
            {
                int[,] myMassive1 = new int[size, size];

                for (int i = 0; i < size; i++)
                {
                    int n = 1;
                    for (int k = 0; k < size; k++)
                    {
                        myMassive1[i, k] =  i > size - k - 1 && i < k || i < size- k -1  && i > k  ? 0 :n++;
                    }
                }
                return myMassive1;
            }

            static int[,] Task2(int size)
            {
                int[,] myMassive2 = new int[size, size];

                for (int i = 0; i < size; i++)
                {
                    for (int k = 0; k < size; k++)
                    {                        
                        myMassive2[i, k] = i == size-1 || k == size-1|| i==0|| k==0 ? 1 : 0;
                    }
                }
                return myMassive2;
            }
            
            static int[,] Task3(int size)
            {
                int[,] myMassive3 = new int[size, size];

                for (int i = 0; i < size; i++)
                {
                    for (int k = 0; k < size; k++)
                    {
                        myMassive3[i, k] = i == k || i + k == size - 1  ? 1 : 0;
                    }
                }
                return myMassive3;
            }



            do { size = ReadSize(""); }
            while (size < 0);
            int[,] myMassive1 = Task1(size);
            ShowArray(size, myMassive1);

            do { size = ReadSize(""); }
            while (size<0);
            int[,]myMassive2 = Task2(size);
            ShowArray(size, myMassive2);

            do { size = ReadSize(""); }
            while (size < 0);
            int[,] myMassive3 = Task3(size);
            ShowArray(size, myMassive3);



        }
    }
}
