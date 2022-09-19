using LogicaF360.Entity;
using Xunit;


namespace TestLogicaF360
{
    public class TestKlingonText
    {
        //Texto com 21 palavras,
        const string TextoExemplo = "vwv rhmjkijs vqgvcq pjdvb gjpsmc jsm zhctgvl jwgbbs mccxbmj mbspg cdhsspgx twndc pmpr bzqvnxs wnfwhcrp czj txvghq ltdtqrd klqnjsok rbsx ftc";
        


        [Fact]
        public void GetQtdPalavras_DeveRetornarOValorCorreto()
        {
            int numeroPalavras;
            int valorEsperado = 21;
            KlingonText textoKlingon = new KlingonText(TextoExemplo);

            numeroPalavras = textoKlingon.GetQtdPalavras();

            Assert.Equal(valorEsperado, numeroPalavras);
        }

        [Fact]
        public void GetQtdProposicoes_DeveRetornarOValorCorreto()
        {
            int numeroPoposicoes;
            int valorEsperado = 4;
            KlingonText textoKlingon = new KlingonText(TextoExemplo);

            numeroPoposicoes = textoKlingon.GetQtdProposicoes();

            Assert.Equal(valorEsperado, numeroPoposicoes);
        }

        [Fact]
        public void GetQtdVerbos_DeveRetornarOValorCorreto()
        {
            int numeroVerbos;
            int valorEsperado = 2;
            KlingonText textoKlingon = new KlingonText(TextoExemplo);

            numeroVerbos = textoKlingon.GetQtdVerbos();

            Assert.Equal(valorEsperado, numeroVerbos);
        }

        [Fact]
        public void GetQtdVerbosPrimeiraPessoa_DeveRetornarOValorCorreto()
        {
            int numeroVerbosPrimeiraPessoa;
            int valorEsperado = 1;
            KlingonText textoKlingon = new KlingonText(TextoExemplo);

            numeroVerbosPrimeiraPessoa = textoKlingon.GetQtdVerbosPrimeiraPessoa();

            Assert.Equal(valorEsperado, numeroVerbosPrimeiraPessoa);
        }




    }
}