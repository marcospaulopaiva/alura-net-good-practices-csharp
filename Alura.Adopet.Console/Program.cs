using Alura.Adopet.Console.Comandos;

Console.ForegroundColor = ConsoleColor.Green;

Dictionary<string, IComando> comandosDoSistema = new()
{
    {"import", new Import()},
    {"help", new Help()},
    {"show", new Show()},
    {"list", new List()},
};

try
{
    string comando = args[0].Trim();

    if (comandosDoSistema.ContainsKey(comando))
    {
        IComando? comandosASerExecutado = comandosDoSistema[comando];
        await comandosASerExecutado.ExecutarAsync(args);
    }
    else
    {
        Console.WriteLine("Comando inválido!");
    }

}
catch (Exception ex)
{
    // mostra a exceção em vermelho
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Aconteceu um exceção: {ex.Message}");
}
finally
{
    Console.ForegroundColor = ConsoleColor.White;
}