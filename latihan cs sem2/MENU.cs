using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QUIZ2_NOMOR_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int why;
            string jawab;

            menu:
            Console.WriteLine(" ********* Menu Program *********");
            Console.WriteLine(" ");
            Console.WriteLine("1. Penjumlahan Array 2 Dimensi");
            Console.WriteLine("2. Structure / Array");
            Console.WriteLine("3. Exit");
            Console.WriteLine(" ");
            Console.Write("Silahkan masukkan pilihan anda = ");
            why = int.Parse(Console.ReadLine());

            Console.Clear();

            if (why > 5)
            {
                Console.WriteLine("Pilihan tidak tersedia");
                Console.ReadKey();
            }

            switch (why)
            {
                case 1:
                array:
                int mat1, mat11, mat2, mat22;
                int[,] matriks1 = new int[2, 2];
                int[,] matriks2 = new int[2, 2];
                int[,] hasil = new int[2, 2];
                int x, y;

                //Input jumlah row dan coloumn Matriks
                Console.Write("Masukan jumlah baris matriks 1 = ");
                mat1 = int.Parse(Console.ReadLine());
                Console.Write("Masukkan jumlah kolom matriks 1 = ");
                mat11 = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.Write("Masukan jumlah baris matriks 2 =");
                mat2 = int.Parse(Console.ReadLine());
                Console.Write("Masukkan jumlah kolom matriks 2 =");
                mat22 = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (mat1 == mat11 && mat2 == mat22)
                {
                    //Proses Penjumlahan DILANJUTKAN
                    for (int a = 0; a < 2; a++)
                    {
                        for (int b = 0; b < 2; b++)
                        {
                            Console.Write("Input nilai matriks1 " + "[" + a + "][" + b + "] = ");
                            matriks1[a, b] = int.Parse(Console.ReadLine());
                        }
                    }

                    Console.WriteLine();

                    for (int c = 0; c < 2; c++)
                    {
                        for (int d = 0; d < 2; d++)
                        {
                            Console.Write("Input nilai matriks2 " + "[" + c + "][" + d + "] = ");
                            matriks2[c, d] = int.Parse(Console.ReadLine());
                        }
                    }

                    Console.WriteLine();

                    for (x = 0; x < 2; x++)
                    {
                        for (y = 0; y < 2; y++)
                        {
                            Console.Write(matriks1[x, y] + " ");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine(" +");

                    for (x = 0; x < 2; x++)
                    {
                        for (y = 0; y < 2; y++)
                        {
                            Console.Write(matriks2[x, y] + " ");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine("------HASIL PENJUMLAHAN-----");

                    for (x = 0; x < 2; x++)
                    {
                        for (y = 0; y < 2; y++)
                        {
                            hasil[x, y] = matriks1[x, y] + matriks2[x, y];
                        }
                    }

                    for (x = 0; x < 2; x++)
                    {
                        for (y = 0; y < 2; y++)
                        {
                            Console.Write(hasil[x, y] + " ");
                        }
                        Console.WriteLine();
                    }

                    //Tombol Kembali
                    Console.WriteLine(" ");
                    Console.Write("Kembali ke program? [Y/T] = ");
                    jawab = (Console.ReadLine());

                    Console.WriteLine("");
                    Console.WriteLine("[Y] = kembali ke program penjumlahan array 2 dimensi");
                    Console.WriteLine("[T] = kembali ke menu utama");
                    Console.WriteLine("");
                    Console.WriteLine("");

                    if (jawab == "y")
                    {
                        Console.Clear();
                        goto array;
                    }
                    else if (jawab == "t")
                    {
                        Environment.Exit(0);
                    }
                }
                else
                {
                    //Proses Penjumlahan GAGAL
                    Console.WriteLine("Proses penjumlahan tidak dapat dilanjuti karena jumlah baris dan kolom tidak sama");

                    //Tombol Kembali
                    Console.WriteLine(" ");
                    Console.Write("Kembali ke program? [Y/T] = ");
                    jawab = (Console.ReadLine());

                    Console.WriteLine("");
                    Console.WriteLine("[Y] = kembali ke menu utama");
                    Console.WriteLine("[T] = keluar Program");
                    Console.WriteLine("");

                    if (jawab == "y")
                    {
                        Console.Clear();
                        goto menu;
                    }
                    else if (jawab == "t")
                    {
                        Environment.Exit(0);
                    }
                }
                break;

            }
        }
    }
}
