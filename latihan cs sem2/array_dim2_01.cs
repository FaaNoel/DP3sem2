using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array_2_Dimensi
{
	class Program
	{
		static void Main(string[] args)
		{
			int [,] x = {{1,2},{3,4}};
		Console.Clear();
		Console.WriteLine("Belajar Array Dimensi 1");
		Console.WriteLine("Menggunakan Metode Row Mayor Order\n");
			for (int a = 0; a < 2; a++) // untuk indek baris
			{
				for (int b = 0; b < 2; b++ ) //untuk index kolom
				{
					Console.Write(x[a, b]+" ");
				}
				Console.WriteLine();
			}
			Console.ReadKey();
		}
	}
}