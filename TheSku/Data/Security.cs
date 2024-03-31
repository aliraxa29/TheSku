using System;
using System.Text;

public class Security
{
    public Security()
    {
    }

    public static string DecryptString(string StringName)
    {
        Decoder decoder = (new UTF8Encoding()).GetDecoder();
        byte[] numArray = Convert.FromBase64String(StringName);
        int charCount = decoder.GetCharCount(numArray, 0, (int)numArray.Length);
        char[] charArray = new char[charCount];
        decoder.GetChars(numArray, 0, (int)numArray.Length, charArray, 0);
        return new string(charArray);
    }

    public static string EncryptString(string StringName)
    {
        byte[] numArray = new byte[StringName.Length];
        string s = Convert.ToBase64String(Encoding.UTF8.GetBytes(StringName));
        return s;
    }
}