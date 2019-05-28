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
			string[] nama = new string[5];
			Console.WriteLine("Masukkan 5 Nama Teman Terdekat Anda :");
			for (int i = 0; i<5;i++) //looping input
			{
				Console.Write("Masukkan nama index ke - "+ i + " :" );
				nama[i] = Console.ReadLine();
			}
			Console.WriteLine("\n Nama yang anda masukan adalah :");
			for (int a = 0; a<5; a++) //looping output
			{
				Console.WriteLine(a +"  " +nama[a] + " ");
			}
			Console.ReadLine();
		}
	}
}