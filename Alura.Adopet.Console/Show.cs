﻿namespace Alura.Adopet.Console
{
    [DocComando(instrucao: "show",
        documentacao: "adopet show <ARQUIVO> comando que exibe no terminal o conteúdo do arquivo importado.")]
    public class Show
    {
        public void ExibirConteudoArquivo(string caminhoDoArquivoASerExibido)
        {
            var leitor = new LeitorDeArquivo();
            var listaDePets = leitor.RealizaLeitura(caminhoDoArquivoASerExibido);
            foreach (var pet in listaDePets)
            {
                System.Console.WriteLine(pet);
            }
        }
    }
}
