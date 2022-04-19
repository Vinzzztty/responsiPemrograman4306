using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4306
{
    class Karyawan
    {
        public void Biodata(string nama, string nim, int gajiBulanan)
        {
            Nim = nim;
            Nama = nama;
            GajiBulanan = gajiBulanan;
            //Validasi jika gaji bulanan diisi kurang dari 0
            if (GajiBulanan < 0)
            {
                GajiBulanan = 0; 
            }
        }

        //properties
        public string Nama { get; set; }
        public string Nim { get; set; }
        public int GajiBulanan { get; set; } 
    }
}
