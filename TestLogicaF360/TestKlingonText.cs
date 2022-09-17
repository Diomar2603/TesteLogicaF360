using LogicaF360.Entity;
using Xunit;


namespace TestLogicaF360
{
    public class TestKlingonText
    {
        //Texto com 21 palavras,
        const string TextoExemplo = "vwv rhjs vqgvcq pjdvb gjpsmc jsm zhctgvl jwgbbs mccxbmj mbspg cdhsspgx twndc pmpr bzqvnxs wnfwhcrp czj txvghq ltdtqrd plqnjsk rbsx ftc";

        [Fact]
        public void Teste_Validar_Numero_Palavras_VinteEUmInt()
        {
            int numeroPalavras;
            int valorEsperado = 21;

            KlingonText textoKlingon = new KlingonText(TextoExemplo);

            numeroPalavras = textoKlingon.GetQtdPalavras();
            Assert.Equal(valorEsperado, numeroPalavras);
        }

        [Fact]
        public void Teste_Numero_Proposicoes()
        {
            int numeroPoposicoes;
            int valorEsperado = 4;

            KlingonText textoKlingon = new KlingonText(TextoExemplo);
            numeroPoposicoes = textoKlingon.GetQtdProposicoes();

            Assert.Equal(valorEsperado, numeroPoposicoes);
        }
    }
}