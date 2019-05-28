using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace array_input
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] nama = new string [3];
			string[] nilai = new string [3];
			Console.WriteLine("Masukkan 3 Nama Siswa :");
			for (int i=0; i<3;i++)
			{
				Console.Write("Masukkan Nama : ");
				nama[i] = Console.ReadLine();
			}
			Console.WriteLine("Masukkan Nilai Anda");
			for (int u=0; u<1;u++)
			{
				Console.Write("\nMasukkan Nilai B.Indo     : ");
				nilai[u] = Console.ReadLine();
				Console.Write("\nMasukkan Nilai IPA        : ");
				nilai[u] = Console.ReadLine();
				Console.Write("\nMasukkan Nilai B.Inggris  : ");
				nilai[u] = Console.ReadLine();
				Console.Write("\nMasukkan Nilai Matematika : ");
				nilai[u] = Console.ReadLine();
			}
			Console.WriteLine("\n Nama Yang Anda Masukkan Adalah :");
			for (int a = 0;a<3;a++)
			{
				Console.WriteLine(a +"  "+nama[a]+ "\n"+a +"  "+nilai[a] );
			}
			Console.ReadLine();
 		}
	}
}