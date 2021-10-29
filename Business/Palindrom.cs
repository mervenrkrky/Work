using System;
namespace Business
{
    public class Palindrom
    {
        public Palindrom()
        {
        }
        public string EnUzunPalindrom(string str)
        {

            int n = str.Length;

            int maxLength = 1, start = 0;

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i; j < str.Length; j++)
                {
                    int flag = 1;

                    for (int k = 0; k < (j - i + 1) / 2; k++)
                        if (str[i + k] != str[j - k])
                            flag = 0;

                    if (flag != 0 && (j - i + 1) > maxLength)
                    {
                        start = i;
                        maxLength = j - i + 1;
                    }
                }
            }

            var enUzunPalindrom = Concat(str, start, start + maxLength - 1);

            return enUzunPalindrom;
        }


        private string Concat(string str, int low, int high)
        {
            return str.Substring(low, high - low + 1);
        }
    }
}
