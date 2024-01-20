using System;
using System.Text;

public class Program { 
    static void Main() {

        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Bem-vindo ao gerador de senhas automático!");
        Console.WriteLine("------------------------------------------");

        Console.WriteLine("Informe o comprimento da senha desejada:");
            int length = Convert.ToInt32(Console.ReadLine());

        string SenhaGerada = GerarSenha(length);
        Console.WriteLine($"Senha gerada: {SenhaGerada}");

    }

    static string GerarSenha(int length) {
        const string caracteresPermitidos = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_+";

        StringBuilder senha = new StringBuilder();
        Random random = new Random();

        for(int i = 0; i < length; i++)
        {
            int index = random.Next(caracteresPermitidos.Length);
            senha.Append(caracteresPermitidos[index]);
        }
        return senha.ToString();
    }
}