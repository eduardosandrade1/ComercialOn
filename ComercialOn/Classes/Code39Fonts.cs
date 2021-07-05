
namespace BarCodeWiz
{
    class Code39Fonts
    {
        private const string Code39Charset = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ-. $/+%";

        public static string Code39check(string s)
        {
            long total = 0;

            for(int i = 0; i < s.Length; i++)
            {
                int charPos = Code39Charset.IndexOf(s.Substring(i,1));
                if (charPos == -1)
                    return "";
                
                total += charPos;

            }
            
            return Code39(s + Code39Charset.Substring((int)(total % 43), 1));
        }

        public static string Code39(string s)
        {
            
            if(s.Length == 0)
                return "";

            for (int i = 0; i < s.Length; i++)
            {
                if (!Code39Charset.Contains(s.Substring(i,1)))
                {
                    return "";
                }
            }

            return "*" + s.Replace(" ", "_") + "*";

        }


    }
}
