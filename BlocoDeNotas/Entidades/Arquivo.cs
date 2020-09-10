namespace BlocoDeNotas.Entidades
{
    class Arquivo
    {
        public bool Salvo { get; set; }
        public string Conteudo { get; set; }
        public string Caminho { get; set; }

        public Arquivo()
        {
            Salvo = false;
        }
    }
}
