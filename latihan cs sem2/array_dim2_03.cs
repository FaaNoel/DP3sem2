using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Penjumlahan_Array
{
	class Program
	{
		static void Main(string[] args)
		{
			int[,] matrik1 = new int [2, 2];
			int[,] matrik2 = new int [2, 2];
			int[,] hasil1 = new int [2, 2];
			int x, y;
			Console.Clear();

			//imput matriks 1
			Console.WriteLine("Input Matriks 1 : " );
			for ( int a = 0; a < 2; a++)
			{
				for (int b = 0; b < 2; b++)
				{
					Console.WriteLine("Input Nilai Matriks1"+ "["+a+"]["+b+")=");
					matrik1 [a,b]=int.Parse(Console.ReadLine());
				}
			}
			Console.WriteLine();

			//imput matriks 2
			Console.WriteLine("Input Matriks 2 : " );
			for ( int c = 0; c < 2; c++)
			{
				for (int d = 0; d < 2; d++)
				{
					Console.WriteLine("Input Nilai Matriks1"+ "["+c+"]["+d+")=");
					matrik2 [c,d]=int.Parse(Console.ReadLine());
				}		
			}
			Console.WriteLine();

			//cetak matriks 1
			Console.WriteLine("Matriks 1 : " );
			for( int x = 0; x < 2; x++)
			{
				for ( int y = 0; y < 2; y++)
				{
					Console.Write(matrik1[x,y] + " ");
				}
				Console.WriteLine();
			}
			Console.WriteLine(" +");

			//cetak matriks 2
			Console.WriteLine("Matriks 2 : " );
			for( int x = 0; x < 2; x++)
			{
				for ( int y = 0; y < 2; y++)
				{
					Console.Write(matrik2[x,y] + " ");
				}
				Console.WriteLine();
			}

			Console.WriteLine("------HASIL PENJUMLAHAN------");
			// poroses penjumlahan matrik1 dan matrik 2
			for (x = 0; x < 2; x++)
			{
				for (y = 0; y < 2; y++)
				{
					hasil[x, y] = matrik1[x, y] - matrik2[x, y];
				}
			}

			//cetak hasil penjumlahan matriks
			for (x = 0; x < 2; x++)
			{
				for (y = 0; y < 2; y++)
				{
					Console.Write(hasil[x. y] + " ");
				}
				Console.WriteLine();
			}
			Console.ReadKey();
		}
	}
}





