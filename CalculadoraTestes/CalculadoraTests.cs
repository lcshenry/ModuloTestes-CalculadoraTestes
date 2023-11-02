namespace CalculadoraTestes;
using Calculadora.Services;
public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests(){
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5com10ERetornar15()
    {
      //Arrange
        int num1 = 10;
        int num2 = 5;

      //Act
        int resultadoSomar = _calc.Somar(num1, num2);

      //Assert
        Assert.Equal(15, resultadoSomar);

    }
        [Fact]
    public void DeveSomar10com10ERetornar20()
    {
      //Arrange
        int num1 = 10;
        int num2 = 10;

      //Act
        int resultadoSomar = _calc.Somar(num1, num2);

      //Assert
        Assert.Equal(20, resultadoSomar);

    }
     [Fact]
    public void DeveSubtrair5com10ERetornar5()
    {
      //Arrange
        int num1 = 10;
        int num2 = 5;

      //Act
        int resultadoSubtrair = _calc.Subtrair(num1, num2);

      //Assert
        Assert.Equal(5, resultadoSubtrair);

    }
     [Fact]
    public void DeveMultiplicar5com10ERetornar50()
    {
      //Arrange
        int num1 = 10;
        int num2 = 5;

      //Act
        int resultadoMultiplicar = _calc.Multiplicar(num1, num2);

      //Assert
        Assert.Equal(50, resultadoMultiplicar);

    }
     [Fact]
    public void DeveDividir5com10ERetornar2()
    {
      //Arrange
        int num1 = 10;
        int num2 = 5;

      //Act
        int resultadoDividir = _calc.Dividir(num1, num2);

      //Assert
        Assert.Equal(2, resultadoDividir);

    }
}