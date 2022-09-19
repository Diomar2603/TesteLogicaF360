using LogicaF360.Entity;
using LogicaF360.Services;


internal class Program
{
    private static void Main(string[] args)
    {

        var downloadService = new DownloadService();
        var fileService = new  FileService();


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
                        Console.WriteLine("O texto " + txtEscolhido + " contem " +
                              txtKlingon.GetQtdVerbos() + " verbos.");
                        Console.WriteLine("O texto " + txtEscolhido + " contem " +
                              txtKlingon.GetQtdVerbosPrimeiraPessoa() + " verbos em primeira pessoa.");
                        Console.WriteLine("O texto com o vocabulario ordenado foi adicionado a pasta \"TextoKlingonOrdenado\" .");
                        Console.WriteLine("O texto " + txtEscolhido + " contem " +
                              txtKlingon.GetNumerosBonitos() + " números bonitos.");
                        fileService.CriarArquivoTextoKlingon(txtKlingon.OrdenarVocabulario(), txtEscolhido);
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