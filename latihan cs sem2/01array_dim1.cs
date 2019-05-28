using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace cara_membuat_array_dengan_input
{
	class Program
	{
		static void Main(string[] args) //Sekumpulan data dalam variabel yang sama
		{
			string[] nama = new string [3];
			int[] bind = new int[3];
			int[]ipa=new int[3];
			int[]mtk=new int[3];
			Console.WriteLine("Masukan 3 Nama peserta :");
			for (int i = 0; i<3;i++) //looping input
			{
				Console.Write("Masukan nama index ke -  "+ i + " :" );
				nama[i] =Console.ReadLine();

				Console.Write("masukkan nilai bahasa indonesia : ");
				bind[i]=int.Parse(Console.ReadLine());

				Console.Write("masukkan nilai ipa : ");
				ipa[i]=int.Parse(Console.ReadLine());

				Console.Write("masukkan nilai matematika : ");
				mtk[i]=int.Parse(Console.ReadLine());

				Console.Write(" ");

			}
			Console.WriteLine("\n Nama yang anda masukan adalah :");
			for (int i = 0; i<3; i++) //looping output
			{
				Console.WriteLine("Index       Nama       Mapel      nilai")
				Console.WriteLine( i+ nama[i]+"Ipa"+ipa[i] );
				Console.WriteLine( i+ nama[i}+"Bind"+bind[i] );
				Console.WriteLine( i+ nama[i]+"Mtk"+mtk[i] );
			}
			Console.ReadLine();
		}
	}
}