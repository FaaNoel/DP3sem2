using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace cara_membuat_array_dimensi1
{
	class Program
	{
		static void Main(string[] args) //Sekumpulan data dalam variabel yang sama
		{
			string[] Hari=new string [7] {"Senin","Selasa","Rabu","Kamis","Jumat","Sabtu","Minggu"};
			Console.WriteLine("\n Hari yang anda masukan adalah :");
			for (int a = 0; a<7; a++)
			{
			Console.WriteLine(a + "  " +Hari[a] + "  ");
			}
			Console.ReadLine();
		}
	}
}