using BlocoDeNotas.Entidades;
using System;
using System.IO;

namespace BlocoDeNotas.Servicos
{
    class ServicoArquivo
    {
        public static void Escrever(Arquivo arquivo)
        {
            try
            {
                using (FileStream fs = new FileStream(arquivo.Caminho, FileMode.Create))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.Write(arquivo.Conteudo);
                    }
                }
                arquivo.Salvo = true;
            }
            catch (IOException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string Ler(Arquivo arquivo)
        {
            try
            {
                using (StreamReader sr = File.OpenText(arquivo.Caminho))
                {
                    arquivo.Salvo = true;
                    arquivo.Conteudo = "";
                    while (!sr.EndOfStream)
                    {
                        arquivo.Conteudo += sr.ReadLine() + "\n";
                    }
                }
                return arquivo.Conteudo;
            }
            catch (IOException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool VerificaAlteracaoNoTexto(string conteudoNovo, string conteudoVelho)
        {
            if (conteudoNovo != conteudoVelho)
            {
                return true;
            }
            return false;
        }
    }
}
