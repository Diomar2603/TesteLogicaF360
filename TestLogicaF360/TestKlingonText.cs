using LogicaF360.Entity;
using Xunit;


namespace TestLogicaF360
{
    public class TestKlingonText
    {
        //Texto com 21 palavras,
        const string TextoExemplo = "vwv rhmjkijs vqgvcq pjdvb gjpsmc jsm zhctgvl jwgbbs mccxbmj mbspg cdhsspgx twndc pmpr bzqvnxs wnfwhcrp czj txvghq ltdtqrd klqnjsok rbsx ftc";
        KlingonText textoKlingon = new KlingonText(TextoExemplo);


        [Fact]
        public void Teste_Numero_Palavras_VinteEUmInt()
        {
            int numeroPalavras;
            int valorEsperado = 21;

            numeroPalavras = textoKlingon.GetQtdPalavras();

            Assert.Equal(valorEsperado, numeroPalavras);
        }

        [Fact]
        public void Teste_Numero_Proposicoes()
        {
            int numeroPoposicoes;
            int valorEsperado = 4;

            numeroPoposicoes = textoKlingon.GetQtdProposicoes();

            Assert.Equal(valorEsperado, numeroPoposicoes);
        }

        [Fact]
        public void Teste_Numero_Verbos_DoisInt()
        {
            int numeroVerbos;
            int valorEsperado = 2;

            numeroVerbos = textoKlingon.GetQtdVerbos();

            Assert.Equal(valorEsperado, numeroVerbos);
        }

        [Fact]
        public void Teste_Numero_Verbos_Primeira_Pessoa_DoisInt()
        {
            int numeroVerbosPrimeiraPessoa;
            int valorEsperado = 3;

            numeroVerbosPrimeiraPessoa = textoKlingon.GetQtdVerbosPrimeiraPessoa();

            Assert.Equal(valorEsperado, numeroVerbosPrimeiraPessoa);
        }


    }
}