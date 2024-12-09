using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Imtahan
{
    public static class Helper
    {
        public static List<char> GetEvenNumber(this string str)
        {
            List<char> list = new List<char>();
            for (int i = 0; i < str.Length; i += 2)
            {
                list.Add(str[i]);
            }
            return list;
        }
    }
}