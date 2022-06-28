namespace Calculadora.Teste
{
    public class OperacoesTeste
    {
        [Fact]
        public void Soma()
        {
            Assert.Equal(20, Calculadora.Soma(10, 10));
        }

        [Fact]
        public void Subtrai()
        {
            Assert.Equal(0, Calculadora.Subtrai(10, 10));
        }

        [Fact]
        public void Multiplica()
        {
            Assert.Equal(100, Calculadora.Multiplica(10, 10));
        }

        [Fact]
        public void Divide()
        {
            Assert.Equal(1, Calculadora.Divide(10, 10));
        }
    }
}