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

        [Fact]
        public void OrdenarVocabulario_DeveRetornarAStringCorreta()
        {
            string textoOrdenado;
            string textoEsperado = "klqnjsok bzqvnxs wnfwhcrp rbsx rhmjkijs ftc jwgbbs jsm mbspg mccxbmj ltdtqrd vwv vqgvcq twndc txvghq cdhsspgx czj gjpsmc zhctgvl pjdvb pmpr";
            KlingonText textoKlingon = new KlingonText(TextoExemplo);

            textoOrdenado = textoKlingon.OrdenarVocabulario();

            Assert.Equal(textoEsperado, textoOrdenado);
        }

        [Theory]
        [InlineData(4852,0)]
        [InlineData(24892876263,1)]
        [InlineData(15302492, 2)]
        [InlineData(258198, 3)]
        [InlineData(49759396, 4)]
        [InlineData(4389, 5)]
        public void ConverterKlingonNumero_DeveRetornarOValorCorreto(double valorEsperado, int index)
        {
            double valorPalavra;
            KlingonText textoKlingon = new KlingonText(TextoExemplo);

            List<string> palavras = TextoExemplo.Split(" ").ToList();

            valorPalavra = textoKlingon.ConverterKlingonNumero(palavras[index]);

            Assert.Equal(valorEsperado, valorPalavra);
        }

        [Fact]
        public void GetNumerosBonitos_DeveRetornarQuantidadeCorreta()
        {
            int qtdNumerosBonitos;
            int valorEsperado = 2;
            KlingonText textoKlingon = new KlingonText(TextoExemplo);

            qtdNumerosBonitos = textoKlingon.GetNumerosBonitos();

            Assert.Equal(valorEsperado, qtdNumerosBonitos);
        }




    }
}