using System;
using modul5_103022300088;

class Program
{
    static void Main(string[] args)
    {
        PemrosesData pemrosesData = new PemrosesData();
        pemrosesData.DapatkanNilaiTerbesar<int>(10, 30, 22);

        SimpleDataBase<int> db = new SimpleDataBase<int>();
        db.addNewData(12);
        db.addNewData(34);
        db.addNewData(56);
        db.showAllData();
    }
}