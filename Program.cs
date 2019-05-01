using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utspemrogaja
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan krywn = new Karyawan();

            krywn.nama = "HAFIZH";
            krywn.nik = "2345";
            krywn.gaji = 2000000;

            krywn.nama2 = "DWI AJI";
            krywn.nik2 = "2332";
            krywn.gaji2 = 3000000;

            krywn.infoGaji();
            Console.WriteLine();
            krywn.kenaikanGaji();
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}