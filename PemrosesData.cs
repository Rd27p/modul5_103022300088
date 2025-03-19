using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_103022300088
{
    internal class PemrosesData
    {
        public void DapatkanNilaiTerbesar<T>(T Nilai1, T Nilai2, T Nilai3)
        {
            dynamic nilai1 = (dynamic)Nilai1;
            dynamic nilai2 = (dynamic)Nilai2;
            dynamic nilai3 = (dynamic)Nilai3;

            if(nilai1 > nilai2 && nilai1 > nilai3)
            {
                Console.WriteLine("Nilai terbesar adalah : " + nilai1);
            }
            if (nilai2 > nilai1 && nilai2 > nilai3)
            {
                Console.WriteLine("Nilai terbesar adalah : " + nilai2);
            }
            if (nilai3 > nilai1 && nilai3 > nilai2)
            {
                Console.WriteLine("Nilai terbesar adalah : " + nilai3);
            }   
        }
        static void Main(string[] args)
        {
            PemrosesData pemrosesData = new PemrosesData();
            pemrosesData.DapatkanNilaiTerbesar<int>(10, 30, 22);
        }

    }
}
