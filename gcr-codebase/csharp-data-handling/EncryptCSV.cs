using System;
using System.IO;
using System.Text;

class EncryptCSV
{
    static string Encrypt(string text)
    {
        byte[] bytes = Encoding.UTF8.GetBytes(text);
        return Convert.ToBase64String(bytes);
    }

    static string Decrypt(string text)
    {
        byte[] bytes = Convert.FromBase64String(text);
        return Encoding.UTF8.GetString(bytes);
    }

    static void Main()
    {
        string salary = "50000";
        string encrypted = Encrypt(salary);
        string decrypted = Decrypt(encrypted);

        Console.WriteLine("Encrypted: " + encrypted);
        Console.WriteLine("Decrypted: " + decrypted);
    }
}
