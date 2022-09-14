using LogicaF360.Services;


internal class Program
{
    private static void Main(string[] args)
    {

        var downloadService = new DownloadService();

        string txtEscolhido;
        do
        {
            Console.Clear();
            Console.WriteLine("Por favor, escolha o texto (A ou B): ");
            txtEscolhido = Console.ReadLine().Trim().ToUpper();
        } while (!txtEscolhido.Equals("A") && !txtEscolhido.Equals("B"));

        downloadService.BaixarTextos(txtEscolhido);

    }
}