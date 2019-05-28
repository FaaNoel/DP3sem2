using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Input_Array_2_Dimensi
{
	class Program
	{
		static void Main(string[] args)
		{
			//deklarasi array 2 dbaris dan 2 kolom
			int[,] array = new int [2,2];

			Console.Clear();
			Console.WriteLine("Belajar Array Dimensi 2 dengan inputan");
			Console.WriteLine("Menggunakan Metode Row Mayor Order");
			Console.WriteLine("Input Matriks :");
			//looping input matriks
			for (int x = 0; x < 2; x++)
			{
				for (int y = 0; y < 2; y++)
				{
					Console.Write("Input Array ["+x+"]["+y+"]=");
					array [x, y] = int.Parse(Console.ReadLine());
				}
				Console.WriteLine();
			}

			Console.WriteLine("Output Matriks :");
			//looping cetak matriks
			for (int a = 0; a < 2; a++)
			{
				for (int b = 0; b < 2; b++)
				{
					Console.Write("array[a, b] = " " ");
				}
				Console.WriteLine();
			}
			Console.ReadKey();
			}
		}
}
