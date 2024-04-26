﻿namespace Alura.Adopet.Console
{
    [AttributeUsage(AttributeTargets.Class)]
    public class DocComando: System.Attribute
    {
        public DocComando(string instrucao, string documentacao)
        {
            Instrucao = instrucao;
            Documentacao = documentacao;
        }

        public string Instrucao { get; }
        public string Documentacao { get; }
    }
}
