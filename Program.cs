using System;

namespace LAB02;
class Program1
{
    static void main(string[] args)
    {
        int[] mangSoNguyen = new int[0];
        double[] mangSoThuc = new double[0];

        while (true)
        {
            Console.WriteLine("\n=== MENU CHUONG TRINH ===");
            Console.WriteLine("1. Tinh tong cac so chan trong mang");
            Console.WriteLine("2. Hien thi cac so nguyen to trong mang");
            Console.WriteLine("3. Dem so am va so duong trong mang");
            Console.WriteLine("4. Tim so lon thu hai trong mang");
            Console.WriteLine("5. Hoan vi hai so nguyen");
            Console.WriteLine("6. Sap xep mang so thuc tang dan");
            Console.WriteLine("0. Thoat");
            Console.Write("Chon chuc nang: ");
            int luaChon = int.Parse(Console.ReadLine());

            switch (luaChon)
            {
                case 1:
                    mangSoNguyen = NhapMangNguyen();
                    Console.WriteLine("Tong cac so chan la: " + TinhTongSoChan(mangSoNguyen));
                    break;
                case 2:
                    mangSoNguyen = NhapMangNguyen();
                    HienThiSoNguyenTo(mangSoNguyen);
                    break;
                case 3:
                    mangSoNguyen = NhapMangNguyen();
                    DemSoAmVaDuong(mangSoNguyen, out int am, out int duong);
                    Console.WriteLine($"So am: {am}, So duong: {duong}");
                    break;
                case 4:
                    mangSoNguyen = NhapMangNguyen();
                    Console.WriteLine("So lon thu hai la: " + TimSoLonThuHai(mangSoNguyen));
                    break;
                case 5:
                    Console.Write("Nhap so a: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Nhap so b: ");
                    int b = int.Parse(Console.ReadLine());
                    HoanVi(ref a, ref b);
                    Console.WriteLine($"Sau hoan vi: a = {a}, b = {b}");
                    break;
                case 6:
                    mangSoThuc = NhapMangThuc();
                    SapXepTangDan(mangSoThuc);
                    Console.WriteLine("Mang sau sap xep: " + string.Join(", ", mangSoThuc));
                    break;
                case 0:
                    Console.WriteLine("Thoat chuong trinh.");
                    return;
                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    break;
            }
        }
    }

    // ==== Cac ham xu ly ====

    static int[] NhapMangNguyen()
    {
        Console.Write("Nhap so phan tu: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        return arr;
    }

    static double[] NhapMangThuc()
    {
        Console.Write("Nhap so phan tu: ");
        int n = int.Parse(Console.ReadLine());
        double[] arr = new double[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            arr[i] = double.Parse(Console.ReadLine());
        }
        return arr;
    }

    static int TinhTongSoChan(int[] arr)
    {
        int tong = 0;
        foreach (int x in arr)
        {
            if (x % 2 == 0)
                tong += x;
        }
        return tong;
    }

    static bool LaSoNguyenTo(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }

    static void HienThiSoNguyenTo(int[] arr)
    {
        Console.WriteLine("Cac so nguyen to trong mang:");
        for (int i = 0; i < arr.Length; i++)
        {
            if (LaSoNguyenTo(arr[i]))
                Console.WriteLine($"Vi tri {i} -> {arr[i]}");
        }
    }

    static void DemSoAmVaDuong(int[] arr, out int demAm, out int demDuong)
    {
        demAm = 0;
        demDuong = 0;
        foreach (int x in arr)
        {
            if (x < 0) demAm++;
            else if (x > 0) demDuong++;
        }
    }

    static int TimSoLonThuHai(int[] arr)
    {
        int max1 = int.MinValue, max2 = int.MinValue;
        foreach (int x in arr)
        {
            if (x > max1)
            {
                max2 = max1;
                max1 = x;
            }
            else if (x > max2 && x < max1)
            {
                max2 = x;
            }
        }
        return max2;
    }

    static void HoanVi(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void SapXepTangDan(double[] arr)
    {
        Array.Sort(arr);
    }
}