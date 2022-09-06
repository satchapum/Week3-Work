namespace Test1._1_1._2;

public class UnitTest1
{
    [Fact]
    public void TestConvertStringToDouble() {
        double number = Program.ConvertStringToDouble("1688.75");

        Assert.Equal(number, 1688.75);
    }

    [Fact]
    public void TestCalculate() {
        double input = 1688.75;
        int[] MoneyChange = new int[11];
        CoinChange.Calculate(ref MoneyChange, input);

        Assert.Equal(MoneyChange, new int[]{1,1,1,1,1,1,1,1,1,1,1});
    }

}