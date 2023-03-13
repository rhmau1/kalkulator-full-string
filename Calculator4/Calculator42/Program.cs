// See https://aka.ms/new-console-template for more information
using System;

namespace Calculator41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULATOR FULL STRING");
            Console.WriteLine("======================\n");
            string ulang = "";
            do
            {
                Console.Write("Masukkan kalimat perhitungan: ");
                string input = Console.ReadLine().ToLower();

                input = input.Replace("ditambah", "+");
                input = input.Replace("dikurang", "-");
                input = input.Replace("dikali", "*");
                input = input.Replace("dibagi", "/");

                int awal = input.IndexOf(' ');
                int akhir = input.LastIndexOf(' ');
                awal += 1;

                int length = akhir - awal;

                string pertama = input.Substring(0, (awal - 1));
                string simbol = input.Substring(awal, length);
                string kedua = input.Substring(akhir + 1);
                string operasi = simbol;
                switch (operasi)
                {
                    case "+":
                        int hasil = JadiInt(pertama) + JadiInt(kedua);
                        Console.Write($"{pertama} {operasi} {kedua} adalah ");
                        JadiString(hasil);
                        break;
                    case "-":
                        hasil = JadiInt(pertama) - JadiInt(kedua);
                        Console.Write($"{pertama} {operasi} {kedua} adalah ");
                        JadiString(hasil);
                        break;
                    case "*":
                        hasil = JadiInt(pertama) * JadiInt(kedua);
                        Console.Write($"{pertama} {operasi} {kedua} adalah ");
                        JadiString(hasil);
                        break;
                    case "/":
                        hasil = JadiInt(pertama) / JadiInt(kedua);
                        Console.Write($"{pertama} {operasi} {kedua} adalah ");
                        JadiString(hasil);
                        break;
                    default:
                        Console.WriteLine("Masukkan kata operator yang sesuai");
                        break;
                }
                Console.Write("Apakah ingin melakukan perhitungan lagi? [Y/N] : ");
                ulang = Console.ReadLine().ToUpper();
            } while (ulang == "Y");

            static int JadiInt(string kalimat)
            {
                switch (kalimat)
                {
                    case "nol":
                        return 0;
                    case "satu":
                        return 1;
                    case "dua":
                        return 2;
                    case "tiga":
                        return 3;
                    case "empat":
                        return 4;
                    case "lima":
                        return 5;
                    case "enam":
                        return 6;
                    case "tujuh":
                        return 7;
                    case "delapan":
                        return 8;
                    case "sembilan":
                        return 9;
                    default:
                        throw new ArgumentException("Hanya dapat menggunakan angka 0 sampai 9");
                }
            }

            static void JadiString(int hasil)
            {
                switch (hasil)
                {
                    case 1:
                        Console.WriteLine("satu");
                        break;
                    case 2:
                        Console.WriteLine("dua");
                        break;
                    case 3:
                        Console.WriteLine("tiga");
                        break;
                    case 4:
                        Console.WriteLine("empat");
                        break;
                    case 5:
                        Console.WriteLine("lima");
                        break;
                    case 6:
                        Console.WriteLine("enam");
                        break;
                    case 7:
                        Console.WriteLine("tujuh");
                        break;
                    case 8:
                        Console.WriteLine("delapan");
                        break;
                    case 9:
                        Console.WriteLine("sembilan");
                        break;
                    default:
                        Console.WriteLine("Hasil lebih dari 10");
                        break;
                }
            }
        }
    }
}
