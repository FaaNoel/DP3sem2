using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace cara_membuat_array_dengan_input
{
	class program
	{
		static void Main(string[] args)
		{
			string[] nama = new string[4];
			Console.WriteLine("Masukkan 4 Mapel UN Anda :");
			for (int i = 0; i<4;i++) //looping input
			{
				Console.Write("Masukkan Nama Mapel - "+ i + " :" );
				nama[i] = Console.ReadLine();
			}

			string[] nilai = new string[4];
			Console.WriteLine("Masukkan 4 Nilai Mapel UN Anda :");
			for (int u = 0; u<4;u++) //looping input
			{
				Console.Write("Masukkan Nilai Anda - "+ u + " :" );
				nilai[u] = Console.ReadLine();
			}

			Console.WriteLine("\n Nilai UN yang anda masukan adalah :");
			for (int a = 0; a<4; a++) //looping output
			{
				Console.WriteLine(a +"  " +nama[a] + " " + nilai[a] + " ");
			}
			Console.ReadLine();
		}
	}
}