using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LogicaF360.Services
{
    internal class DownloadService
    {

        //Links fixos dos textos
        private const string LinkTextoA = "https://raw.githubusercontent.com/f360-dev/provas/master/klingon-textoA.txt";
        private const string LinkTextoB = "https://raw.githubusercontent.com/f360-dev/provas/master/klingon-textoB.txt";

        //Caminho das pastas
        private static string PastaTextos = Directory.GetCurrentDirectory().Split("\\LogicaF360\\").GetValue(0)
                          + "\\LogicaF360\\Resources\\KlingonTexts";

        

        public string BaixarTextos(string txtEscolhido)
        {

            var caminhoTexto = Path.Combine(PastaTextos, "klingon-texto" + txtEscolhido + ".txt");

            if (!File.Exists(caminhoTexto))
            {
                Console.WriteLine("\n"+"O Texto não se encontra na maquina, iremos fazer o Dowload pra você ;)");
                try
                {
                    using (WebClient client = new WebClient())
                    {
                        switch (txtEscolhido)
                        {
                            case "A":
                                client.DownloadFile(new Uri(LinkTextoA), caminhoTexto);
                                break;

                            case "B":
                                client.DownloadFile(new Uri(LinkTextoB), caminhoTexto);
                                break;
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("\n"+"Erro disparado ao tentar Baixar texto: " + e.Message
                        + "\n" + e.InnerException);
                }
                return caminhoTexto;
            }
            else
            {
                Console.WriteLine("\n" + "O Texto já se encontra na maquina");
                return caminhoTexto;
            }
        }
    }
}
