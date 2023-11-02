namespace CalculadoraTestes;
using Calculadora.Services;
using Xunit;
using System;
public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests(){
        _calc = new CalculadoraImp();
    }

    [Theory]
    [InlineData(1,2,3)]
    [InlineData(4,5,9)]
    public void CalculadoraTestSomar(int num1, int num2, int resultado)
    {
      int resultadoCalculadora = _calc.Somar(num1, num2);
      Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(2,1,1)]
    [InlineData(5,4,1)]
    public void CalculadoraTestSubtrair(int num1, int num2, int resultado)
    {
      int resultadoCalculadora = _calc.Subtrair(num1, num2);
      Assert.Equal(resultado, resultadoCalculadora);
    }

    
    [Theory]
    [InlineData(2,2,4)]
    [InlineData(10,5,50)]
    public void CalculadoraTestMultiplicar(int num1, int num2, int resultado)
    {
      int resultadoCalculadora = _calc.Multiplicar(num1, num2);
      Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(6,2,3)]
    [InlineData(10,2,5)]
    public void CalculadoraTestDividir(int num1, int num2, int resultado)
    {
      int resultadoCalculadora = _calc.Dividir(num1, num2);
      Assert.Equal(resultado, resultadoCalculadora);
    }
    [Fact]
    public void TestarDivPorZero(){
      Assert.Throws<DivideByZeroException>( () => _calc.Dividir(3,0));
    }

    [Fact]
    public void TestarHistorico()
    {
      _calc.Somar(1,2);
      _calc.Somar(2,8);
      _calc.Somar(3,7);
      _calc.Somar(4,1);

      var lista = _calc.Historico();

      Assert.NotEmpty(_calc.Historico());
      Assert.Equal(3, lista.Count);
    }
}