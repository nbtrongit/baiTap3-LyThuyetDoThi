using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3_LTDT
{
    class thuatToanPrim
    {
        public static void Prim(maTranKe AM, int dinhBatDau)
        {
            Canh[] cayKhung = new Canh[AM.n - 1];
            int indexT = 0;
            bool[] tapDinh = new bool[AM.n];
            tapDinh[dinhBatDau] = true;
            while (indexT < AM.n - 1)
            {
                Canh Min;
                Min.Dau = 0;
                Min.Cuoi = 0;
                Min.trongSo = -1;
                for (int i = 0; i < AM.n; i++)
                {
                    if (tapDinh[i])
                    {
                        for (int j = 0; j < AM.n; j++)
                        {
                            if(AM.maTran[i,j] != 0 && (tapDinh[i] == false || tapDinh[j] == false))
                            {
                                if(Min.trongSo < 0 || AM.maTran[i,j] < Min.trongSo)
                                {
                                    Min.Dau = i;
                                    Min.Cuoi = j;
                                    Min.trongSo = AM.maTran[i, j];
                                }    
                            }
                        }
                    }
                }
                cayKhung[indexT] = Min;
                indexT++;
                tapDinh[Min.Cuoi] = true;
                tapDinh[Min.Dau] = true;
            }
            int tong = 0;
            Console.WriteLine("Tập cạnh có cây khung nhỏ nhất");
            for (int i = 0; i < cayKhung.Length; i++)
            {
                Console.WriteLine($"{cayKhung[i].Dau}-{cayKhung[i].Cuoi}: {cayKhung[i].trongSo}");
                tong += cayKhung[i].trongSo;
            }
            Console.WriteLine($"Trọng số của cây khung nhỏ nhất: {tong}");
        }
    }
}
