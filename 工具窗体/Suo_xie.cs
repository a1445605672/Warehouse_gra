using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.工具窗体
{
    public class Suo_xie
    {
        /// <summary>
        /// 用户获取汉字的首字母缩写
        /// </summary>
        /// <param name="str">为输入的汉字 </param>
        /// <returns></returns>
        public  string  GetPYString(string str)

        {


            string tempStr = "";

            foreach (char c in str)

            {

                if ((int)c >= 33 && (int)c <= 126)

                {//字母和符号原样保留

                    tempStr += c.ToString();

                }

                else

                {//累加拼音声母

                    tempStr += GetPYChar(c.ToString());

                }

            }

            return tempStr;

        }

        ///</summary>

        ///<param name="c">要转换的单个汉字</param>

        ///<returns>拼音声母</returns>

        public  string  GetPYChar(string c)

        {

            byte[] array = new byte[2];

            array = System.Text.Encoding.Default.GetBytes(c);

            int i = (short)(array[0] - '\0') * 256 + ((short)(array[1] - '\0'));

            if (i < 0xB0A1) return "*";

            if (i < 0xB0C5) return "a";

            if (i < 0xB2C1) return "b";

            if (i < 0xB4EE) return "c";

            if (i < 0xB6EA) return "d";

            if (i < 0xB7A2) return "e";

            if (i < 0xB8C1) return "f";

            if (i < 0xB9FE) return "g";

            if (i < 0xBBF7) return "h";

            if (i < 0xBFA6) return "g";

            if (i < 0xC0AC) return "k";

            if (i < 0xC2E8) return "l";

            if (i < 0xC4C3) return "m";

            if (i < 0xC5B6) return "n";

            if (i < 0xC5BE) return "o";

            if (i < 0xC6DA) return "p";

            if (i < 0xC8BB) return "q";

            if (i < 0xC8F6) return "r";

            if (i < 0xCBFA) return "s";

            if (i < 0xCDDA) return "t";

            if (i < 0xCEF4) return "w";

            if (i < 0xD1B9) return "x";

            if (i < 0xD4D1) return "y";

            if (i < 0xD7FA) return "z";

            return "*";

        }


    }
}
