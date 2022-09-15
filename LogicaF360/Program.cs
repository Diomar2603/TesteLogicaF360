using LogicaF360.Entity;
using LogicaF360.Services;


internal class Program
{
    private static void Main(string[] args)
    {

        var downloadService = new DownloadService();


        string continuar;
        do
        {

            string txtEscolhido;
            do
            {
                Console.Clear();
                Console.WriteLine("Por favor, escolha o texto (A ou B): ");
                txtEscolhido = Console.ReadLine().Trim().ToUpper();
            } while (!txtEscolhido.Equals("A") && !txtEscolhido.Equals("B"));
            
            string caminho = downloadService.BaixarTextos(txtEscolhido);

            var path = Path.GetFullPath(caminho);

            try
            {
                using(StreamReader sr = new StreamReader(path))
                {
                    string texto = sr.ReadToEnd();
                    if (!string.IsNullOrEmpty(texto))
                    {
                        KlingonText txtKlingon = new KlingonText(texto);

                        Console.WriteLine("\n"+"O texto " + txtEscolhido + " contem "+
                              txtKlingon.GetQtdPalavras() + " palavras.");
                        Console.WriteLine("O texto " + txtEscolhido + " contem " +
                              txtKlingon.GetQtdProposicoes()+ " proposições.");

                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro ao ler o texto: " + e.Message 
                                  +"\n" + e.InnerException);
            }

            Console.WriteLine("\n" + "Deseja continuar ('N' para sair ou pressione 'Enter' pra continuar)?");
            continuar = Console.ReadLine().Trim().ToUpper();
        } while (!continuar.Equals("N"));

    }
}