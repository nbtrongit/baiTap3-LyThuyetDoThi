using System;
using System.IO;

namespace BT3_LTDT
{
    class Program
    {
        public static maTranKe maTran(string filename)
        {
            maTranKe AM;
            string[] a = File.ReadAllLines(filename);
            AM.n = int.Parse(a[0]);
            AM.maTran = new int[AM.n, AM.n];
            int b = 0;
            for (int i = 1; i < a.Length; i++)
            {
                string[] d = a[i].Split(' ');
                for (int j = 0; j < d.Length; j++)
                {
                    AM.maTran[b, j] = int.Parse(d[j]);
                }
                b++;
            }
            return AM;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập vào đường dẫn file/tên file");
            string filename = Console.ReadLine();
            if (!File.Exists(filename))
            {
                Console.WriteLine("File không tồn tại");
            }
            else
            {
                Console.WriteLine("Thuật toán Prim");
                maTranKe AM = maTran(filename);
                Console.WriteLine("Nhập đỉnh bắt đầu thuật toán Prim");
                int dinhBatDau = int.Parse(Console.ReadLine());
                thuatToanPrim.Prim(AM, dinhBatDau);
                Console.WriteLine();
                Console.WriteLine("Thuật toán Kruskal");
                maTranKe AM1 = maTran(filename);
                thuatToanKruskal.Kruskal(AM1);
            }
        }
    }
}
