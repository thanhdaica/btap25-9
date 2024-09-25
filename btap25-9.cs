using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;
class Program
{
    static void Bai1()
    {
        Console.Write("Nhap mot danh sach cac so nguyen: ");
        int number = int.Parse(Console.ReadLine());
        ArrayList arrayList = new ArrayList();
        for (int i = 0; i < number; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            arrayList.Add(Console.ReadLine());
        }
        Console.Write("Danh sach cac so nguyen sau khi sap xep: ");
        arrayList.Sort();
        for (int i = 0; i < number; i++)
        {
            Console.Write(arrayList[i]);
            Console.Write(" ");
        }

        Console.ReadKey();
    }
    static void Bai2()
    {
        Console.Write("Nhap so luong nguoi: ");
        int input = int .Parse(Console.ReadLine());
        Hashtable hashtable = new Hashtable();
        for(int i = 0;i < input;i++)
        {
            Console.Write("Nhap ten: ");
            string ten = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            int tuoi = int.Parse(Console.ReadLine());
            hashtable.Add(ten, tuoi);
        }

        Console.WriteLine("\nDanh sach ten va tuoi:");
        foreach (DictionaryEntry entry in hashtable)
        {
            Console.WriteLine($"Ten: {entry.Key}, Tuoi: {entry.Value}");
        }
        Console.ReadKey();
    }
    static void Bai3()
    {
        Console.Write("Nhap so luong hoc sinh : ");
        int hs = int.Parse(Console.ReadLine());
        Dictionary<string, int> hocsinh = new Dictionary<string, int>();
        for (int i = 0; i < hs; i++)
        {
            Console.Write("Nhap ten: ");
            string tenhs = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            int tuoihs = int.Parse(Console.ReadLine());
            hocsinh.Add(tenhs, tuoihs);
        }
        Console.WriteLine("\nDanh sach ten va tuoi hoc sinh:");
        foreach (var entry in hocsinh)
        {
            Console.WriteLine($"Ten: {entry.Key}, Tuoi: {entry.Value}");
        }
    }
    static void Main() 
    {
            Bai1();
            //Bai2();
            //Bai3();
    }
}

