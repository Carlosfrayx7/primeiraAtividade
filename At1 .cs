public class Program
{
    public static void Main(string[] args)
    {
        var linha = "[[]{{}]";
        var resultado = isValid(linha);
        Console.WriteLine(resultado.ToString());
    }

    public static bool isValid(string linha)
    {
        var tamanhoAnterior = 0;
        while (true)
        {
            if (linha.Length == 0)
                return true;

            linha = linha.Replace("[]", "");
            linha = linha.Replace("{}", "");
            linha = linha.Replace("()", "");

            if (tamanhoAnterior == linha.Length)
                return false;

            tamanhoAnterior = linha.Length;
        }
    }
}