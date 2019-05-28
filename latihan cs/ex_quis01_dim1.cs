using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace cara_membuat_array_dimensi1
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] nama=new string[7] {"Senin","Selasa","Rabu","Kamis","Jumat","Sabtu","Minggu"};
			Console.WriteLine("\n Nama Hari yang anda masukan adalah :");
			for (int a = 0; a<7; a++)
			{
				Console.WriteLine(a +" " +nama[a] + " ");
			}
			Console.ReadLine();
		}
	}
}