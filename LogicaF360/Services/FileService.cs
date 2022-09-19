using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaF360.Services
{
    internal class FileService
    {
        private static string PastaTextosOrd = Directory.GetCurrentDirectory().Split("\\LogicaF360\\").GetValue(0)
                          + "\\LogicaF360\\Resources\\TextoKlingonOrdenado";

        public void CriarArquivoTextoKlingon(string texto, string textoEscolhido)
        {
            string path = PastaTextosOrd + $"\\Texto{textoEscolhido}Ordenado.txt"; 

            if (File.Exists(path))
            {
                File.Delete(path);
            }


            File.WriteAllText(path, texto);
        }
    }
}
