

using System.Net.Http.Headers;

namespace LogicaF360.Entity
{
    public class KlingonText
    {

        private List<string> Palavras { get; set; }

        private List<string> PalavrasTraduzidas { get; set; }

        private List<char> LetrasFoo { get; } = new List<char>("slfwk".ToCharArray());

        private List<char> AlfabetoKlingon { get; } = new List<char>("kbwrqdnfxjmlvhtcgzps".ToCharArray());

        private Dictionary<char, char> ReferenciaAlfabeto = new Dictionary<char, char>(){
                {'k','a'},{'b','b'},{'w','c'},{'r','d'},{'q','e'},
                {'d','f'},{'n','g'},{'f','h'},{'x','i'},{'j','j'},
                {'m','k'},{'l','l'},{'v','m'},{'h','n'},{'t','o'},
                {'c','p'},{'g','q'},{'z','r'},{'p','s'},{'s','t'}
            };

    public KlingonText(string texto)
        {
            Palavras = texto.Replace("\n","").Split(' ').ToList();
        }

        public int GetQtdPalavras()
        {
            return Palavras.Count;
        }
        public int GetQtdProposicoes()
        {
            return Palavras.Count(palavra => palavra.Length.Equals(3) && 
                             !palavra.Contains('d') &&
                             !LetrasFoo.Any(letra => palavra.EndsWith(letra.ToString())));
        }

        public int GetQtdVerbos()
        {

            return Palavras.Count(palavra => palavra.Length >= 8 &&
                               LetrasFoo.Any(letra => palavra.EndsWith(letra.ToString())));
        }

        public int GetQtdVerbosPrimeiraPessoa()
        {

            return Palavras.Count(palavra => palavra.Length >= 8 &&
                               LetrasFoo.Any(letra => palavra.EndsWith(letra.ToString())) &&
                               !LetrasFoo.Any(letra => palavra.StartsWith(letra.ToString())));
        }

        public List<string> ListarVocabulario()
        {
            List<string> vocabulario = new List<string>(); 

            vocabulario = Palavras.Distinct().ToList();


            return vocabulario;
        }

        public string OrdenarVocabulario()
        {

            List<string> vocabulario = ListarVocabulario();
            List<string> palavrasTraduzidas = new List<string>();
            List<string> vocabularioOrdenado = new List<string>();
            Dictionary<string, string> vocabularioTraduzido = new Dictionary<string, string>();

            foreach (string palavra in vocabulario)
            {
                string palavraTraduzida = "";

                foreach (char letra in palavra)
                {
                    palavraTraduzida += ReferenciaAlfabeto.GetValueOrDefault(letra);
                }

                palavrasTraduzidas.Add(palavraTraduzida);
                vocabularioTraduzido.Add(palavraTraduzida, palavra);
            }

            palavrasTraduzidas.Sort();

            foreach (string palavra in palavrasTraduzidas)
            {
                vocabularioOrdenado.Add(vocabularioTraduzido.GetValueOrDefault(palavra));
            }



            return string.Join(" ", vocabularioOrdenado);
        }

        public int GetNumerosBonitos()
        {
            int qtdNumerosBonitos = 0;
            double numPalavra;

            foreach (string palavra in Palavras)
            {
                numPalavra = ConverterKlingonNumero(palavra);

                if (numPalavra >= 440566 && numPalavra % 3 == 0)
                {
                    qtdNumerosBonitos++;
                }
            }

            return qtdNumerosBonitos;
        }

        public double ConverterKlingonNumero(string palavra)
        {
            double valorPalavra = 0;

            for (int i = 0; i < palavra.Length; i++)
            {
                valorPalavra += AlfabetoKlingon.IndexOf(palavra[i]) * Math.Pow(20, i);
            }

            return valorPalavra;
        }


    }
}
