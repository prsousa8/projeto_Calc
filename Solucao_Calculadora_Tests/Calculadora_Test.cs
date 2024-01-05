using Solucao_Calculadora.Models;
namespace Solucao_Calculadora_Tests;

public class UnitTest1
{
    [Fact]
    public void TestSomar()
    {
        Calculadora calc = new Calculadora();
        int num1 = 4;
        int num2 = 4;
        int resultado = calc.Somar(num1,num2);
        Assert.Equal(8,resultado);
    }

    [Fact]
    public void TestSubtrair()
    {
        Calculadora calc = new Calculadora();
        int num1 = 4;
        int num2 = 9;
        int resultado = calc.Subtrair(num1,num2);
        Assert.Equal(-5,resultado);
    }

    [Fact]
    public void TestMultiplicar()
    {
        Calculadora calc = new Calculadora();
        int num1 = 4;
        int num2 = 4;
        int resultado = calc.Multiplicar(num1,num2);
        Assert.Equal(16,resultado);
    }
    [Fact]
    public void TestDividir()
    {
        Calculadora calc = new Calculadora();
        double num1 = 4;
        double num2 = 4;
        double resultado = calc.Dividir(num1,num2);
        Assert.Equal(1,resultado);
    }

    [Fact]
    public void TestRaizQuadrada()
    {
        Calculadora calc = new Calculadora();
        double num1 = 4;
        double resultado = calc.RaizQuadrada(num1);
        Assert.Equal(2,resultado);
    }
}