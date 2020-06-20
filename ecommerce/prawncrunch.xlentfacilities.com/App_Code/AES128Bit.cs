using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;

namespace com.toml.dp.util
{
	public class AES128Bit
	{
		public static void Main(string[] args)
		{
			string plainStr = "mypassword";
			Console.WriteLine("Original Text: {0}", plainStr);

			int keySize = 128; // 192, 256

			string completeEncodedKey = GenerateKey(keySize);
			Console.WriteLine("Using complete key '{0}'", completeEncodedKey);

			string encryptedText = Encrypt(plainStr, completeEncodedKey, keySize);
			Console.WriteLine("Encrypted Text: {0}", encryptedText);

			string decrypted = Decrypt(encryptedText, completeEncodedKey, keySize);
			Console.WriteLine("Decrypted Text: {0}", decrypted);

			Console.Read();
		}

		public static string GenerateKey(int keySize)
		{
			RijndaelManaged aesEncryption = new RijndaelManaged();
			aesEncryption.KeySize = keySize;
			aesEncryption.BlockSize = 128;
			aesEncryption.Mode = CipherMode.ECB;
			aesEncryption.Padding = PaddingMode.PKCS7;

			//aesEncryption.GenerateIV();
			//string ivStr = Convert.ToBase64String(aesEncryption.IV);

			aesEncryption.GenerateKey();
			string keyStr = Convert.ToBase64String(aesEncryption.Key);

			//Console.WriteLine("Using key '{0}'", keyStr, ivStr);
			//Console.WriteLine("Using iv '{0}'", ivStr);

			//string completeKey = ivStr + "," + keyStr;
			string completeKey = keyStr;
			return Convert.ToBase64String(ASCIIEncoding.UTF8.GetBytes(completeKey));
		}

		public static string Encrypt(string plainStr, string completeEncodedKey, int keySize)
		{
			RijndaelManaged aesEncryption = new RijndaelManaged();
			aesEncryption.KeySize = keySize;
			aesEncryption.BlockSize = 128;
			aesEncryption.Mode = CipherMode.ECB;
			aesEncryption.Padding = PaddingMode.PKCS7;
			//aesEncryption.IV = Convert.FromBase64String(ASCIIEncoding.UTF8.GetString(Convert.FromBase64String(completeEncodedKey)).Split(',')[0]);
			//aesEncryption.Key = Convert.FromBase64String(ASCIIEncoding.UTF8.GetString(Convert.FromBase64String(completeEncodedKey)).Split(',')[1]);
			aesEncryption.Key = Convert.FromBase64String(completeEncodedKey);

			byte[] plainText = ASCIIEncoding.UTF8.GetBytes(plainStr);

			ICryptoTransform crypto = aesEncryption.CreateEncryptor();

			// The result of the encryption and decryption
			byte[] cipherText = crypto.TransformFinalBlock(plainText, 0, plainText.Length);

			return Convert.ToBase64String(cipherText);
		}

		public static string Decrypt(string encryptedText, string completeEncodedKey, int keySize)
		{
			RijndaelManaged aesEncryption = new RijndaelManaged();
			aesEncryption.KeySize = keySize;
			aesEncryption.BlockSize = 128;
			aesEncryption.Mode = CipherMode.ECB;
			aesEncryption.Padding = PaddingMode.PKCS7;
			//aesEncryption.IV = Convert.FromBase64String(ASCIIEncoding.UTF8.GetString(Convert.FromBase64String(completeEncodedKey)).Split(',')[0]);
			//aesEncryption.Key = Convert.FromBase64String(ASCIIEncoding.UTF8.GetString(Convert.FromBase64String(completeEncodedKey)).Split(',')[1]);
			aesEncryption.Key = Convert.FromBase64String(completeEncodedKey);

			ICryptoTransform decrypto = aesEncryption.CreateDecryptor();
			byte[] encryptedBytes = Convert.FromBase64CharArray(encryptedText.ToCharArray(), 0, encryptedText.Length);

			return ASCIIEncoding.UTF8.GetString(decrypto.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length));
		}
	}
}