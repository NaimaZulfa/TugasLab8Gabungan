using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasLab8Gabungan.ClassInduk;

namespace TugasLab8Gabungan.ClassAnak
{
    public class KaryawanTetap : Karyawan
    {
        public double GajiBulanan;
        public override double Gaji()
        {
            return GajiBulanan;
        }
    }
}