//=====================================================================================
// All Rights Reserved , Copyright © Learun 2013
//=====================================================================================

using System.Security.Cryptography;
using System.Text;

namespace LeaRun.Util
{
    /// <summary>
    /// MD5加密帮助类
    /// 版本：2.0
    /// <author>
    ///		<name>shecixiong</name>
    ///		<date>2013.09.27</date>
    /// </author>
    /// </summary>
    public class Md5Helper
    {
        //#region "MD5加密"
        ///// <summary>
        ///// MD5加密
        ///// </summary>
        ///// <param name="str">加密字符</param>
        ///// <param name="code">加密位数16/32</param>
        ///// <returns></returns>
        //public static string MD5(string str, int code)
        //{
        //    string strEncrypt = string.Empty;
        //    if (code == 16)
        //    {
        //        strEncrypt = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(str, "MD5").Substring(8, 16);
        //    }

        //    if (code == 32)
        //    {
        //        strEncrypt = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(str, "MD5");
        //    }

        //    return strEncrypt;
        //}
        //#endregion

        #region
        public static string MD5(string str, int code)
        {
            string strEncrypt = string.Empty;
            MD5 md5Hash = System.Security.Cryptography.MD5.Create();
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(str));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            if (code == 16)
            {
                strEncrypt = sBuilder.ToString().Substring(8, 16);
            }
            if (code == 32)
            {
                strEncrypt = sBuilder.ToString();
            }

            return strEncrypt;
        }
        #endregion
    }
}
