using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3_LTDT
{
    class thuatToanKruskal
    {
        public static int soLuongCanh(maTranKe AM)
        {
            int Dem = 0;
            for (int i = 0; i < AM.n; i++)
            {
                for (int j = i + 1; j < AM.n; j++)
                {
                    if (AM.maTran[i, j] != 0)
                    {
                        Dem++;
                    }
                }
            }
            return Dem;
        }
        public static Canh[] dsTapCanh(maTranKe AM)
        {
            Canh[] tapCanh = new Canh[soLuongCanh(AM)];
            int indextapCanh = 0;
            for (int i = 0; i < AM.n; i++)
            {
                for (int j = i + 1; j < AM.n; j++)
                {
                    if (AM.maTran[i, j] != 0)
                    {
                        tapCanh[indextapCanh].Dau = i;
                        tapCanh[indextapCanh].Cuoi = j;
                        tapCanh[indextapCanh].trongSo = AM.maTran[i, j];
                        indextapCanh++;
                    }
                }
            }
            int dem = 0;
            for (int i = 0; i <= tapCanh.Length - 2; i++)
            {
                for (int j = 0; j <= tapCanh.Length - 2; j++)
                {
                    dem = dem + 1;
                    if (tapCanh[j].trongSo > tapCanh[j + 1].trongSo)
                    {
                        Canh trungGian = tapCanh[j + 1];
                        tapCanh[j + 1] = tapCanh[j];
                        tapCanh[j] = trungGian;
                    }
                }
            }
            return tapCanh;
        }
    }
}
