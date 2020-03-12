using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MyCalcLib
{
    public class MyCalc
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }
    }
    public class prov
    {
        public bool car_number(string car)
        {
            string alpha = "ABEKMHOPCTYX";
            string numbers = "1234567890";
            int[] regions_from_01_to_99 = Enumerable.Range(01, 99).ToArray();
            string y = car.Remove(0, 6);
            if ((car[6] == '0' && car[7] == '0') || (car[6] == '0' && car[7] == '0' && car[8] == '0'))
            {
                return false;
            }
            else if ((car.Length == 8) && alpha.Contains(car[0]) && alpha.Contains(car[4]) && alpha.Contains(car[5]) && numbers.Contains(car[1]) && numbers.Contains(car[2]) && numbers.Contains(car[3]) && numbers.Contains(car[6]) && numbers.Contains(car[7]) || (car.Length == 9 && alpha.Contains(car[0]) && alpha.Contains(car[4]) && alpha.Contains(car[5]) && numbers.Contains(car[1]) && numbers.Contains(car[2]) && numbers.Contains(car[3]) && ((y == "102") || (y == "113") || (y == "116") || (y == "121") || (y == "123") || (y == "124") || (y == "125") || (y == "126") || (y == "134") || (y == "136") || (y == "138") || (y == "142") || (y == "150") || (y == "152") || (y == "154") || (y == "159") || (y == "161")
            || (y == "163") || (y == "164") || (y == "173") || (y == "174") || (y == "177") || (y == "178") || (y == "186") || (y == "190") || (y == "196") || (y == "199") || (y == "750") || (y == "716") || (y == "761") || (y == "763") || (y == "777") || (y == "799"))))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
