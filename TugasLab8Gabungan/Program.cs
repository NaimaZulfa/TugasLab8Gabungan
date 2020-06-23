using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasLab8Gabungan.ClassAnak;
using TugasLab8Gabungan.ClassInduk;

namespace TugasLab8Gabungan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nama\t: Naima Zulfa");
            Console.WriteLine("NIM\t: 19.11.2735");
            Console.WriteLine("Kelas\t: S1 - 19 IF 03");
            Console.WriteLine();

            Console.Title = "Tugas Lab 8 - Inheritance, Polymorphsim, Abstraction & Collection";

            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.NIK = "2735";
            karyawanTetap.Nama = "Naima Zulfa";
            karyawanTetap.GajiBulanan = 4000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.NIK = "1090";
            karyawanHarian.Nama = "Naima";
            karyawanHarian.UpahPerJam = 13000;
            karyawanHarian.JumlahJamKerja = 8;

            Sales sales = new Sales();
            sales.NIK = "1010";
            sales.Nama = "Zulfa";
            sales.JumlahPenjualan = 30;
            sales.Komisi = 45000;

            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrut = 1;

            foreach(Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. NIK : {1}, \tNama \t: {2}, \tGaji \t: {3}", 
                    noUrut, karyawan.NIK, karyawan.Nama, karyawan.Gaji());
                
                noUrut++;
            }
            Console.ReadLine();
        }
    }
}
