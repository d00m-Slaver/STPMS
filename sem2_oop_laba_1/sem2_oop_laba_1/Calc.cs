using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem2_oop_laba_1
{
    public class Calc : ILaba1
    {

      
            public string VPos { get; set; }
            public char[] ArrayG = { 'а', 'о', 'э', 'е', 'и', 'ы', 'у', 'ё', 'ю', 'я' };
            public char[] ArrayS = { 'б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м','н','п','р','с','т','ф','х','ц','ч','ш','щ',};

            public string Change(string podStr, string DrStr)
            {
                     string finaly = VPos.Replace(podStr, DrStr);
                     VPos = VPos.Replace(podStr, DrStr);
                     return finaly;
            }

            public string Del(string value)
            {
            string finaly = VPos.Replace(value,"");
            VPos= VPos.Replace(value, "");
            return finaly;
            }

            public string Take(int number)
            {
            string finaly = VPos.Substring(number-1, 1);
            return finaly;
            }


    }
}
