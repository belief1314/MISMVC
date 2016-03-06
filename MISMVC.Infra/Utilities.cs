using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MISMVC.Infra
{
    public static class Utilities
    {
		public static String GetMD5(String value ) {
			String result = string.Empty;
			MD5 md5 = new MD5CryptoServiceProvider( );
			result = UnicodeEncoding.Unicode.GetString( md5.ComputeHash( UnicodeEncoding.Unicode.GetBytes( value ) ) );
			return result;
		}

		public static String GetSHA256(String value ) {
			String result = string.Empty;
			SHA256Managed sha256 = new SHA256Managed( );
			result = UnicodeEncoding.Unicode.GetString( sha256.ComputeHash( UnicodeEncoding.Unicode.GetBytes( value ) ) );
			return result;
		}
    }
}
