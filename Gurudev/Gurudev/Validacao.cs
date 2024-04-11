using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Gurudev
{
    internal static class Validacao
    {
        public static string cpf;
        public static bool VerificarNIV(string niv)
        {
            niv = niv.ToUpper();
            if(niv.Length != 17)
            {
                return false;
            }

            for (int i = 0; i < niv.Length; i++)
            {
                if (niv[i].ToString() =="O"|| niv[i].ToString() =="Q" || niv[i].ToString() =="N")
                {
                    return false;

                }
            }
            return true;

        }

    }


}