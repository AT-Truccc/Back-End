using System;

namespace LAB01;
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n===== MENU CHUONG TRINH =====");
            Console.WriteLine("1. Xin chao [ten], ban [tuoi] tuoi");
            Console.WriteLine("2. Tinh dien tich hinh chu nhat");
            Console.WriteLine("3. Chuyen doi do C sang do F");
            Console.WriteLine("4. Kiem tra so chan hay le");
            Console.WriteLine("5. Tinh tong va tich cua hai so");
            Console.WriteLine("6. Kiem tra so am, duong hay 0");
            Console.WriteLine("7. Kiem tra nam nhuan");
            Console.WriteLine("8. In bang cuu chuong");
            Console.WriteLine("9. Tinh giai thua");
            Console.WriteLine("10. Kiem tra so nguyen to");
            Console.WriteLine("11. Tinh khoang cach giua 2 diem");
            Console.WriteLine("0. Thoat");
            Console.Write("Chon bai muon chay (0-11): ");

            int chon;
            if (!int.TryParse(Console.ReadLine(), out chon)) continue;

            Console.Clear();

            switch (chon)
            {
                case 1: Bai1(); break;
                case 2: Bai2(); break;
                case 3: Bai3(); break;
                case 4: Bai4(); break;
                case 5: Bai5(); break;
                case 6: Bai6(); break;
                case 7: Bai7(); break;
                case 8: Bai8(); break;
                case 9: Bai9(); break;
                case 10: Bai10(); break;
                case 11: Bai11(); break;
                case 0: return;
                default: Console.WriteLine("Lua chon khong hop le."); break;
            }
        }
    }

    static void Bai1()
    {
        Console.Write("Nhap ten cua ban: ");
        string ten = Console.ReadLine();
        Console.Write("Nhap tuoi cua ban: ");
        int tuoi = int.Parse(Console.ReadLine());
        Console.WriteLine($"Xin chao {ten}, ban {tuoi} tuoi.");
    }

    static void Bai2()
    {
        Console.Write("Nhap chieu dai: ");
        double dai = double.Parse(Console.ReadLine());
        Console.Write("Nhap chieu rong: ");
        double rong = double.Parse(Console.ReadLine());
        Console.WriteLine($"Dien tich hinh chu nhat la: {dai * rong}");
    }

    static void Bai3()
    {
        Console.Write("Nhap nhiet do (do C): ");
        double c = double.Parse(Console.ReadLine());
        double f = (c * 9 / 5) + 32;
        Console.WriteLine($"Nhiet do {c} do C tuong duong {f} do F");
    }

    static void Bai4()
    {
        Console.Write("Nhap mot so nguyen: ");
        int n = int.Parse(Console.ReadLine());
        if (n % 2 == 0)
            Console.WriteLine($"{n} la so chan.");
        else
            Console.WriteLine($"{n} la so le.");
    }

    static void Bai5()
    {
        Console.Write("Nhap so thu nhat: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhap so thu hai: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"Tong: {a + b}");
        Console.WriteLine($"Tich: {a * b}");
    }

    static void Bai6()
    {
        Console.Write("Nhap mot so: ");
        double n = double.Parse(Console.ReadLine());
        if (n > 0) Console.WriteLine($"{n} la so duong.");
        else if (n < 0) Console.WriteLine($"{n} la so am.");
        else Console.WriteLine($"{n} la so 0.");
    }

    static void Bai7()
    {
        Console.Write("Nhap mot nam: ");
        int nam = int.Parse(Console.ReadLine());
        if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
            Console.WriteLine($"{nam} la nam nhuan.");
        else
            Console.WriteLine($"{nam} khong phai nam nhuan.");
    }

    static void Bai8()
    {
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{i} x {j} = {i * j}\t");
            }
            Console.WriteLine();
        }
    }

    static void Bai9()
    {
        Console.Write("Nhap mot so nguyen duong: ");
        int n = int.Parse(Console.ReadLine());
        long gt = 1;
        for (int i = 2; i <= n; i++) gt *= i;
        Console.WriteLine($"Giai thua cua {n} la: {gt}");
    }

    static void Bai10()
    {
        Console.Write("Nhap mot so nguyen: ");
        int n = int.Parse(Console.ReadLine());
        bool laNguyenTo = n > 1;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                laNguyenTo = false;
                break;
            }
        }
        Console.WriteLine(laNguyenTo ? $"{n} la so nguyen to." : $"{n} khong phai la so nguyen to.");
    }

    static void Bai11()
    {
        Console.WriteLine("Nhap toa do diem A:");
        Console.Write("x1 = ");
        int x1 = int.Parse(Console.ReadLine());
        Console.Write("y1 = ");
        int y1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhap toa do diem B:");
        Console.Write("x2 = ");
        int x2 = int.Parse(Console.ReadLine());
        Console.Write("y2 = ");
        int y2 = int.Parse(Console.ReadLine());

        double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        Console.WriteLine($"Khoang cach giua A({x1},{y1}) va B({x2},{y2}) la: {d}");
    }
}