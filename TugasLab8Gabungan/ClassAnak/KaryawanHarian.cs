using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasLab8Gabungan.ClassInduk;

namespace TugasLab8Gabungan.ClassAnak
{
    public class KaryawanHarian : Karyawan
    {
        public double UpahPerJam;
        public double JumlahJamKerja;
        public override double Gaji()
        {
            return JumlahJamKerja * UpahPerJam;
        }
    }
}