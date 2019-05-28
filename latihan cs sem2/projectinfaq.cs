using System;
class project
{
	static void Main()
	{
		const string USERNAME1 = "3103118011";
		const string PASSWORD1 = "telkom";
		
		const string USERNAME2 = "3103118012";
		const string PASSWORD2 = "telkom";
		
		const string USERNAME3 = "3103118013";
		const string PASSWORD3 = "telkom";
		
		const string USERNAME4 = "3103118014";
		const string PASSWORD4 = "telkom";
		
		
		
		string username, password;
		
		for( ; ; )
		{
			Console.WriteLine("Masukkan NISN dan password");
			Console.Write("NISN: ");
			username = Console.ReadLine();
			
			Console.Write("Password: ");
			password = Console.ReadLine();
			Console.WriteLine();
			
			if((username==USERNAME1)&&(password==PASSWORD1)||(username==USERNAME2)&&(password==PASSWORD2)||(username==USERNAME3)&&(password==PASSWORD3)
			||(username==USERNAME4)&&(password==PASSWORD4))
		
			{
				break;
			}
		}
			
		//1
		
		Console.Clear();
		Console.WriteLine();


		string jenisinfaq, ulang;
		Console.Clear();
		Console.WriteLine("           ==================================================== ");
Console.WriteLine();
Console.WriteLine("                   Selamat Datang di INFAQ Online ");
Console.WriteLine();
Console.WriteLine("           ==================================================== ");

jenisinfaq :

		Console.WriteLine("Jenis INFAQ");
		Console.WriteLine("1: INFAQ Mingguan (Jum'at)");
		Console.WriteLine("2: Infaq Sumbangan");
		Console.WriteLine("3: Infaq Tabungan Akhirat");
		Console.WriteLine("4: Donasi");
		Console.WriteLine();
		Console.Write("Masukkan pilihan Anda: ");
		jenisinfaq = Console.ReadLine();
		jenisinfaq = jenisinfaq.ToLower();
		decimal Tunai = 0m;
		switch (jenisinfaq)
		{
			case "1":
			case "INFAQ Mingguan (Jum'at":
			break;
			
			case "2":
			case "Infaq Sumbangan":
			break;
			
			case "3":
			case "Infaq Tabungan Akhirat":
			break;
			
			case "4":
			case "Donasi":
			break;
			
			default:
			Console.Write(" Pilihan tedak tersedia. ");
			Console.WriteLine("Silahkan pilih 1, 2, 3, atau 4!");
			break;
		}
		
		if (Tunai != 0m)
		{
			int n;
			Console.WriteLine("Masukkan Saldo Infaq : ");
			n = int.Parse(Console.ReadLine());


		}
		//2
		int i;
		Console.Write("Banyaknya Tunai yang di infaqkan : ");
		i = int.Parse(Console.ReadLine());
		
		{
			Console.Clear();
			Console.WriteLine(" ===================================== TERIMA KASIH TELAH INFAQ ============================================== ");
			Console.WriteLine("Pengetian Infaq dan Manfaatnya");
Console.WriteLine("Infaq berasal dari kata anfaqa yang berarti mengeluarkan sesuatu (harta) untuk kepentingan sesuatu.");
Console.WriteLine("Menurut terminologi syariat, infaq berarti mengeluarkan sebagian dari harta atau pendapatan/penghasilan");
Console.WriteLine("untuk suatu kepentingan yang diperintahkan Islam.");
Console.WriteLine("Manfaat Infak bagi kehidupan :");
Console.WriteLine("1. Menolak bala.");
Console.WriteLine("2. Dicintai Allah SWT. (QS 2 : 195)");
Console.WriteLine("3. Infaq dibalas 700x lipat oleh Allah SWT (rizqi, kesehatan, kebahagiaan).");
Console.WriteLine("4. Dibalas pahala di akhirat.");
Console.WriteLine("5. Percaya diri (tidak khawatir hidup).");
Console.WriteLine("6. Tidak akan bersedih hati. (QS 2 : 261, 262)");
Console.WriteLine("7. Dihapus/diampuni dosa.");
Console.WriteLine("8. Diberi karunia.  ");
Console.WriteLine("9. Allah SWT memberikan ilmu Al-Hikmah (paham Al-quran, kemampuan memahami rahasia2 syariat agama).");
Console.WriteLine("10. Kebaikan zakat, infaq akan berbalik kepada diri sendiri.");
Console.WriteLine("11. Akan diberi pahala yang cukup.");
Console.WriteLine("12. Tidak akan dirugikan/didzolimi orang lain. (QS 2 : 272)");
Console.WriteLine("13. Tidak akan berbuat dosa.");
Console.WriteLine("14. Tidak akan menjadi kafir. (QS 2 : 276)");
Console.WriteLine("15. Akan disempurnakan amal ibadahnya. (QS 3 : 92)");
Console.WriteLine("16. Bisa menahan amarah.");
Console.WriteLine("17. Bisa memaafkan orang lain.");
Console.WriteLine("18. Termasuk orang yang benar2 beriman.");
Console.WriteLine("19. Allah SWT akan mengangkat harkat derajatnya.");
Console.WriteLine("20. Allah SWT akan memberikan rizqi yang mulia dan berkah. (QS 8 : 3, 4)");
		}
		//4
		Console.WriteLine();
	Console.Write(" Apakah anda ingin infaq kembali ? [y/t] : ");
	ulang = Convert.ToString(Console.ReadLine());
	if (ulang == "y" || ulang == "Y")

	goto jenisinfaq;

		Console.WriteLine();
Console.WriteLine();
Console.WriteLine(" ========================================================");
Console.WriteLine();
Console.WriteLine("         Semoga Amal Shodaqoh nya di Terima  !!! ");
Console.WriteLine();
Console.WriteLine(" ========================================================");

Console.WriteLine();



	
	}
}
