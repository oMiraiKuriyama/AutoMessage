using System;
using System.Threading;

try
{
    Console.Write("Hay nhap tin nhan ma ban muon viet: ");
    string tin_nhan;
    tin_nhan = Console.ReadLine();
    Console.Write("Nhap so luong tin nhan: ");
    int so_luong;
    so_luong = Convert.ToInt32(Console.ReadLine());

    int mac_dinh;
    mac_dinh = 0;

    int real_time;
    Console.Write("Nhap thoi gian delay: ");
    int thoi_gian = Convert.ToInt32(Console.ReadLine());
    real_time = thoi_gian * 1;



    while (mac_dinh < so_luong)
    {

        mac_dinh = mac_dinh + 1;
        Thread.Sleep(real_time);
        Console.WriteLine(mac_dinh + " " + tin_nhan);
    }
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}
