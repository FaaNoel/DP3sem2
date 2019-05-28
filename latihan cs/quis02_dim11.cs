using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,c;
            string[] nama=new string[3];
            string[] nilai = new string[3];

            for (i = 0; i < 3; i++)
            {
                c = i + 1;
                Console.WriteLine("Input " + c);
                Console.Write("Nama    : ");
                nama[i]=Console.ReadLine();
                Console.Write("Nilai Mapel B.Indonesia : ");
                nilai[i]=Console.ReadLine();
                Console.Write("Nilai Mapel Matematika : ");
                nilai[i]=Console.ReadLine();
                Console.Write("Nilai Mapel B.Inggris : ");
                nilai[i]=Console.ReadLine();
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Click to Continue. . .");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Data siswa yang di masukan :");
            Console.WriteLine("==========================================");
            Console.WriteLine();
            Console.WriteLine("+---------------------------------------+");
            Console.WriteLine(" No  Nama  B.Indonesia  Matematika  B.Inggris ");
            Console.WriteLine("+---------------------------------------+");
            for (i = 0; i < 3; i++)
            {
                c = i + 1;
                Console.WriteLine(" "+c+ "   "+nama[i]+"     "+nilai[i]+"          "+nilai[i]+"          "+nilai[i]+"  ");
            }
            Console.WriteLine("+---------------------------------------+");
            Console.WriteLine();
            Console.Write("Enter untuk keluar . . . ");
            Console.ReadLine();
        }
    }
}