using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SalesManagement_SysDev.Common
{
    internal class DataInputFormCheck
    {
        public bool CheckFullWidth(string text)
        {
            bool flg;
            int textLength = text.Replace("\r\n", string.Empty).Length;
            int textByte = Encoding.GetEncoding("Shift_JIS").GetByteCount(text.Replace("\r\n", string.Empty));
            //全角文字列かを確認
            if (textByte != textLength * 2)
                flg = false;
            else flg = true;
            return flg;
        }

        public bool CheckHalfAlphabetNumeric(string text)
        {
            bool flg;

            Regex regex = new Regex("^[a-zA-z0-9]+$");
            //半角英数字文字列かを確認
            if(!regex.IsMatch(text))
                flg = false;
            else flg = true;
            return flg;
        }

        public bool CheckHalfWidthKatakana(string text)
        {
            bool flg;
            Regex regex = new Regex(@"[\uFF66-\uFF9D]");
            //半角カナかを確認
            if (!regex.IsMatch(text))
                flg = false;
            else flg = true;
            return flg;
        }

        public bool CheckNumeric(string text)
        {
            bool flg;
            Regex regex = new Regex("^[0-9]+$");
            //数値かを確認
            if(!regex.IsMatch(text))
                flg = false;
            else flg = true;
            return flg;
        }

        public bool CheckMailAddress(string text)
        {
            bool flg = false;
            Regex regex = new Regex(@"^\b[\w.%+-]+@[\w.-]+\.[a-zA-Z]{2,4}\b$");
            //メールアドレス形式の確認
            if(!regex.IsMatch(text))
                flg = false;
            else flg = true;
            return flg;
        }

        public bool CheckHalfChar(string text)
        {
            bool flg = false;
            Regex regex = new Regex("^[ -~];$");
            if(!regex.IsMatch(text))
                flg = false;
            else flg = true;
            return flg;
        }
    }
}
