using System;

class BaiTap
{
    public static void Bai1(){
        int[] a = new int[100];
        int n;
        int sum = 0;
        Console.Write("nhap so luong phan tu trong mang:");
        n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write("nhap phan tu so {0} = ", i);
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            sum += a[i];
        }
        Console.WriteLine("tong cac phan tu trong mang la: {0}", sum);
    }

    public static void Bai2()
    {
        string chuoi;
        int chucai = 0;
        int chuso = 0;
        Console.Write("nhap chuoi ki tu:");
        chuoi = Console.ReadLine();
        int l = chuoi.Length;
        for (int i = 0; i < l; i++)
        {
            if (chuoi[i] >= 'a' && chuoi[i] <= 'z' || chuoi[i] >= 'A' && chuoi[i] <= 'Z')
            {
                chucai++;
            }
            else if (chuoi[i] >= '0' && chuoi[i] <= '9')
            {
                chuso++;
            }
        }
        Console.WriteLine("so ki tu co trong chuoi la: {0}", chucai + chuso);
    }

    public static void Bai3()
    {
        int[] a = new int[100];
        int n;
        Console.WriteLine("nhap so luong phan tu: ");
        n = Convert.ToInt32(Console.ReadLine());
        int max = a[0];
        for (int i = 0; i < n; i++)
        {

            Console.WriteLine("phan tu {0} = ", i);
            a[i] = Convert.ToInt32(Console.ReadLine());
            if (a[i] > max)
            {
                max = a[i];
            }
        }
        Console.WriteLine("gia tri lon nhat: {0}", max);
    }

    public static void Bai4()
    {
        Console.WriteLine("nhap chuoi ki tu:");
        string chuoi = Console.ReadLine();
        char[] chuoi2 = chuoi.ToCharArray();
        Array.Reverse(chuoi2);
        string reverse = new string(chuoi2);
        Console.WriteLine("chuoi dao nguoc: {0} ", reverse);
    }

    public static void Bai5()
    {
        int[] a = { 1, 2, 3, 4, 4, 3, 2, 1 };
        int n = a.Length;
        int d = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = n - 1; j > i; j--)
            {
                if (a[i] == a[j])
                {
                    d++;
                }
            }
        }
        if (d == 0)
        {
            Console.WriteLine("day ko phai mang doi xung.");
        }
        else
        {
            Console.WriteLine("day la mang doi xung.");
        }
    }

    public static void Bai6()
    {
        string chuoi;
        int chucai = 0;
        int chuso = 0;
        int kitu = 0;
        Console.Write("nhap chuoi ki tu:");
        chuoi = Console.ReadLine();
        int l = chuoi.Length;
        for (int i = 0; i < l; i++)
        {
            if (chuoi[i] >= 'a' && chuoi[i] <= 'z' || chuoi[i] >= 'A' && chuoi[i] <= 'Z')
            {
                chucai++;
            }
            else if (chuoi[i] >= '0' && chuoi[i] <= '9')
            {
                chuso++;
            }
            else
            {
                kitu++;
            }
        }
        Console.WriteLine("so chu cai trong chuoi la: {0}", chucai);
        Console.WriteLine("so chu so trong chuoi la: {0}", chuso);
        Console.WriteLine("so ki tu trong chuoi la: {0}", kitu);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        BaiTap.Bai1();
        BaiTap.Bai2();
        BaiTap.Bai3();
        BaiTap.Bai4();
        BaiTap.Bai5();
        BaiTap.Bai6();
    }
}