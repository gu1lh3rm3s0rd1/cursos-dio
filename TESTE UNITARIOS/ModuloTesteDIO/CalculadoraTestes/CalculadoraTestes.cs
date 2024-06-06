using Calculadora.Services;

namespace calculadoratestes;

//craindo a classe de testes
public class CalculadoraTestes
{

    private CalculadoraImp _calc;

    public CalculadoraTestes()
    {
        _calc = new CalculadoraImp();
    }

    // implementando o teste unitario
    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        //ARRANGE - MONTA O CENARIO
        int num1 = 5;
        int num2 = 10;

        //ACT - EXECUTA A AÇAO
        int resultado = _calc.Somar(num1, num2);

        //ASSERT - VALIDAÇAO DO RETORNO
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveSomar10Com10ERetornar20()
    {
        //ARRANGE - MONTA O CENARIO
        int num1 = 10;
        int num2 = 10;

        //ACT - EXECUTA A AÇAO
        int resultado = _calc.Somar(num1, num2);

        //ASSERT - VALIDAÇAO DO RETORNO
        Assert.Equal(20, resultado);
    }

    [Fact]
    public void DeveVerificarSe4EhParERetornarVerdadeiro()
    {
        //ARRANGE - MONTA O CENARIO
        int numero = 4;

        //ACT - EXECUTA A AÇAO
        bool resultado = _calc.EhPar(numero);

        //ASSERT - VALIDAÇAO DO RETORNO
        // bool - treu ou false
        Assert.True(resultado);
    }
}