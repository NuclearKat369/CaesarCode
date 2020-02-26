using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caesar
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

           
            

        }
    }



    public class crypto {

        public static String encrypt(String encryptString, int key)
        {

            char[] EncrChar = encryptString.ToCharArray();
            long[] EncrLong = new long[EncrChar.Length];
            char[] EncrCharNew = new char[EncrChar.Length];

            for (int i = 0; i < EncrChar.Length; i++)
            {

                EncrLong[i] = EncrChar[i] + key;
                EncrCharNew[i] = (char)EncrLong[i];

            }

            encryptString = new String(EncrCharNew);

            return encryptString;
        }
        public static String decrypt(String decryptString, int key)
        {

            char[] DecrChar = decryptString.ToCharArray();
            long[] DecrLong = new long[DecrChar.Length];
            char[] DecrCharNew = new char[DecrChar.Length];

            for (int i = 0; i < DecrChar.Length; i++)
            {

                DecrLong[i] = DecrChar[i] - key;
                DecrCharNew[i] = (char)DecrLong[i];

            }

            decryptString = new String(DecrCharNew);

            return decryptString;
        }

    }


}
