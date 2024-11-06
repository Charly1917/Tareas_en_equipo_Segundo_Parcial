using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;

public class HelloWorld
{
    public enum Propiedades
    {
        [Description("Puerto 89-80, validar")]
        Puerto_8980 = 89 - 80,
        [Description("Puerto 89-81, calculadora")]
        Puerto_8981 = 89 - 81,
        [Description("Puerto 89-82, contador")]
        Puerto_8982 = 89 - 82,
        [Description("Puerto 89-83, servicio adicional")]
        Puerto_8983 = 89 - 83,
        [Description("Puerto 89-84, sistema de informes")]
        Puerto_8984 = 89 - 84,
        [Description("Puerto 89-85, acceso externo")]
        Puerto_8985 = 89 - 85,
        [Description("Puerto 89-86, servicio web")]
        Puerto_8986 = 89 - 86,
        [Description("Puerto 89-87, administración remota")]
        Puerto_8987 = 89 - 87,
        [Description("Puerto 89-88, monitoreo")]
        Puerto_8988 = 89 - 88,
        [Description("Puerto 89-89, almacenamiento")]
        Puerto_8989 = 89 - 89,
        [Description("Puerto 89-90, sistema de seguridad")]
        Puerto_8990 = 89 - 90,
    }

    private static readonly byte[] Key = Encoding.UTF8.GetBytes("0123456789abcdef"); // 16 bytes for AES-128
    private static readonly byte[] IV = Encoding.UTF8.GetBytes("abcdef9876543210");  // 16 bytes IV

    public static void Main(string[] args)
    {
        foreach (Propiedades value in Enum.GetValues(typeof(Propiedades)))
        {
            MemberInfo[] memberInfo = typeof(Propiedades).GetMember(value.ToString());
            DescriptionAttribute descriptionAttribute = memberInfo[0].GetCustomAttribute<DescriptionAttribute>();
            string description = descriptionAttribute != null ? descriptionAttribute.Description : "No description";

            Console.WriteLine($"{value}: {description}");
            HandlePortConfiguration(value);
        }

        string originalText = "Texto a encriptar";
        string encryptedText = Encrypt(originalText);
        Console.WriteLine($"Texto encriptado: {encryptedText}");
        Console.ReadLine();
        string decryptedText = Decrypt(encryptedText);
        Console.WriteLine($"Texto desencriptado: {decryptedText}");
        Console.ReadLine();
    }

    private static void HandlePortConfiguration(Propiedades port)
    {
        switch (port)
        {
            case Propiedades.Puerto_8980:
                Console.WriteLine("Configure puerto 8980");
                break;
            case Propiedades.Puerto_8981:
                Console.WriteLine("Configure puerto 8981");
                break;
            case Propiedades.Puerto_8982:
                Console.WriteLine("Configure puerto 8982");
                break;
            case Propiedades.Puerto_8983:
                Console.WriteLine("Configure puerto 8983");
                break;
            case Propiedades.Puerto_8984:
                Console.WriteLine("Configure puerto 8984");
                break;
            case Propiedades.Puerto_8985:
                Console.WriteLine("Configure puerto 8985");
                break;
            case Propiedades.Puerto_8986:
                Console.WriteLine("Configure puerto 8986");
                break;
            case Propiedades.Puerto_8987:
                Console.WriteLine("Configure puerto 8987");
                break;
            case Propiedades.Puerto_8988:
                Console.WriteLine("Configure puerto 8988");
                break;
            case Propiedades.Puerto_8989:
                Console.WriteLine("Configure puerto 8989");
                break;
            case Propiedades.Puerto_8990:
                Console.WriteLine("Configure puerto 8990");
                break;
            default:
                Console.WriteLine("Unknown puerto");
                break;
        }
        
    }

    private static string Encrypt(string plainText)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = Key;
            aes.IV = IV;

            using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
            {
                using (var ms = new MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        using (var sw = new StreamWriter(cs))
                        {
                            sw.Write(plainText);
                        }
                        return Convert.ToBase64String(ms.ToArray());
                    }
                }
            }
        }
    }

    private static string Decrypt(string encryptedText)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = Key;
            aes.IV = IV;

            using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
            {
                using (var ms = new MemoryStream(Convert.FromBase64String(encryptedText)))
                {
                    using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        using (var sr = new StreamReader(cs))
                        {
                            return sr.ReadToEnd();
                        }
                    }
                }
            }
        }

    }
}
