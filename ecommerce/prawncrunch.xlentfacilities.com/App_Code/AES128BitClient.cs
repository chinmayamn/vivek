using System;
using com.toml.dp.util;

public class AES128BitClient
{
	public static void Main(string[] args)
	{
		string plainStr = "mypassword";
		Console.WriteLine("Original Text: {0}", plainStr);

		int keySize = 128;
		string completeEncodedKey = "glBv+xevOenDM5ydcqb9pA==";

		string encryptedText = AES128Bit.Encrypt(plainStr, completeEncodedKey, keySize);
		Console.WriteLine("Encrypted Text: {0}", encryptedText);

		string decrypted = AES128Bit.Decrypt(encryptedText, completeEncodedKey, keySize);
		Console.WriteLine("Decrypted Text: {0}", decrypted);

		Console.Read();
	}
}