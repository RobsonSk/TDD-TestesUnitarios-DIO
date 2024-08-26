using TDD;
using TDD.Calc;

namespace test_TDD;

public class UnitTest1
{
    public Calc classConstructor()
    {
        string date = DateTime.Now.ToString();
        Calc calc = new Calc(date);

        return calc;
    }
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void TestSum(int val1, int val2, int result)
    {
        Calc calc = classConstructor();

        int resultCalc = calc.Sum(val1, val2);

        Assert.Equal(result, resultCalc);
    }
    [Theory]
    [InlineData(2, 1, 1)]
    [InlineData(5, 4, 1)]
    public void TestSub(int val1, int val2, int result)
    {
        Calc calc = classConstructor();

        int resultCalc = calc.Sub(val1, val2);

        Assert.Equal(result, resultCalc);
    }
    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(4, 5, 20)]
    public void TestMult(int val1, int val2, int result)
    {
        Calc calc = classConstructor();

        int resultCalc = calc.Mult(val1, val2);

        Assert.Equal(result, resultCalc);
    }
    [Theory]
    [InlineData(6, 2, 3)]
    [InlineData(5, 5, 1)]
    public void TestDiv(int val1, int val2, int result)
    {
        Calc calc = classConstructor();

        int resultCalc = calc.Div(val1, val2);

        Assert.Equal(result, resultCalc);
    }
    [Fact]
    public void TestDiv0()
    {
        Calc calc = classConstructor();

        Assert.Throws<DivideByZeroException>(() => calc.Div(10, 0));
    

    }

    [Fact]
    public void TestHistory()
    {
        Calc calc = classConstructor();
        calc.Sum(1, 2);
        calc.Sum(3, 4);
        calc.Sum(5, 6);

        Assert.NotEmpty(calc.History());
        Assert.Equal(3, calc.History().Count());
    }

}