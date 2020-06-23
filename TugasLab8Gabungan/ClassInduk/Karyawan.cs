using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasLab8Gabungan.ClassInduk
{
    public abstract class Karyawan
    {
        public string NIK;
        public string Nama;
        public abstract double Gaji();
    }
}
