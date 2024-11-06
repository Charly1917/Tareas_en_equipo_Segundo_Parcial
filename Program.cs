using System;
using System.ComponentModel;
using System.Reflection;

public class HelloWorld
{
    public enum Socket
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

    public static void Main(string[] args)
    {
        foreach (Socket value in Enum.GetValues(typeof(Socket)))
        {
            MemberInfo[] memberInfo = typeof(Socket).GetMember(value.ToString());
            DescriptionAttribute descriptionAttribute = memberInfo[0].GetCustomAttribute<DescriptionAttribute>();
            string description = descriptionAttribute != null ? descriptionAttribute.Description : "No description";

            Console.WriteLine($"{value}: {description}");
            HandlePortConfiguration(value);
        }
    }

    private static void HandlePortConfiguration(Socket port)
    {
       
        switch ((Socket)port)
        {
            case Socket.Puerto_8980:
                Console.WriteLine("Configure puerto 8980");
                break;
            case Socket.Puerto_8981:
                Console.WriteLine("Configure puerto 8981");
                break;
            case Socket.Puerto_8982:
                Console.WriteLine("Configure puerto 8982");
                break;
            case Socket.Puerto_8983:
                Console.WriteLine("Configure puerto 8983");
                break;
            case Socket.Puerto_8984:
                Console.WriteLine("Configure puerto 8984");
                break;
            case Socket.Puerto_8985:
                Console.WriteLine("Configure puerto 8985");
                break;
            case Socket.Puerto_8986:
                Console.WriteLine("Configure puerto 8986");
                break;
            case Socket.Puerto_8987:
                Console.WriteLine("Configure puerto 8987");
                break;
            case Socket.Puerto_8988:
                Console.WriteLine("Configure puerto 8988");
                break;
            case Socket.Puerto_8989:
                Console.WriteLine("Configure puerto 8989");
                break;
            case Socket.Puerto_8990:
                Console.WriteLine("Configure puerto 8990");
                break;
            default:
                Console.WriteLine("Unknown puerto");
                break;
        }
        Console.ReadLine();
    }
}
