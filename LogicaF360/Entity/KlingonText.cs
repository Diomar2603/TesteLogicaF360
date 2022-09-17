

namespace LogicaF360.Entity
{
    public class KlingonText
    {

        private List<string> Palavras { get; set; }

        private List<char> LetrasFoo { get; } = new List<char>() { 's', 'l', 'f', 'w', 'k' };

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
                             !LetrasFoo.Any(letras => palavra.EndsWith(letras.ToString())));
        }

    }
}
