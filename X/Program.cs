using System;
using System.IO;

class Program
{
    static void Main()
    {
        int max = 0;
        int default1 = 0;

        using (StreamReader a = new StreamReader("C:\\Users\\User\\Desktop\\no.txt"))
        {
            string b = a.ReadToEnd();

            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] == 'X')
                {
                    default1++;
                    if (default1 > max)
                        max = default1;
                }
                else
                {
                    default1 = 0;
                }
            }
        }

        Console.WriteLine(max);
    }
}