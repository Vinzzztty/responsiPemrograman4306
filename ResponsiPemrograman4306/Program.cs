using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4306
{
    class Program
    {
        static void Main(string[] args)
        {
            int gajik, gajikFix, gajik2, gajikFix2;
            Karyawan karyawan = new Karyawan();
            Karyawan karyawan2 = new Karyawan();

            karyawan.Nim = "190302123";
            karyawan.Nama = "Paijo";
            karyawan.GajiBulanan = 3000000;

            karyawan2.Nim = "190302124";
            karyawan2.Nama = "Jono";
            karyawan2.GajiBulanan = 2000000;

            Console.WriteLine();
            Console.WriteLine("No Nik/Nama\t\t Gaji Bulanan");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("1. {0}  {1}\t {2}", karyawan.Nim, karyawan.Nama, karyawan.GajiBulanan);
            Console.WriteLine("2. {0}  {1}\t {2}", karyawan2.Nim, karyawan2.Nama, karyawan2.GajiBulanan);
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            gajik = karyawan.GajiBulanan;
            gajikFix = gajik + (karyawan.GajiBulanan / 10);

            gajik2 = karyawan2.GajiBulanan;
            gajikFix2 = gajik + (karyawan2.GajiBulanan / 10);

            Console.WriteLine("Asyikkk kenaikan gaji 10%");
            Console.WriteLine("1. {0}  {1}\t {2}", karyawan.Nim, karyawan.Nama, gajikFix);
            Console.WriteLine("2. {0}  {1}\t {2}", karyawan2.Nim, karyawan2.Nama, gajikFix2);

            Console.ReadKey();
        }
    }
}
