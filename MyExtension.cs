using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assiment_7
{
    public static class MyExtension
    {
        /// <summary>
        /// Kiểm tra số nguyên tố
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool isPrime(this int n)
        {
            double can = Math.Sqrt(n);
            if( n == 0 || n == 1)
            {
                return false;
            }
            for(int i = 2; i < can; ++i)
            {
                if(n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Truy xuất danh sách số nguyên tố
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static List<int> DanhSachSNT(this int n)
        {
            List<int> list = new List<int>();
            for (int i = 2; i < n; ++i)
            {
                if (i.isPrime())
                {
                    list.Add(i);
                }
            }
            return list;
        }
        /// <summary>
        /// Lấy số nguyên
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public static int LaySoNguyen(this TextBox txt)
        {
            int i;
            int.TryParse(txt.Text, out i);
            return i;
        }

    }
}
