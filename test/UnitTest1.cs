namespace test;

public class UnitTest1
{
    [Fact]
    public void  CheckStingToLong()
    {
        long number = Program.StringtoLong("50");
        Assert.Equal(number,50);
    }
    [Fact]
    public void IncorectConvertStringtoLong()
    {
        Assert.Throws<Exception>(()=>Program.StringtoLong("OAtt"));
    }
    [Fact]
    public void CheckStringToDouble()
    {
        double number = Program.StringtoDouble("70");
        Assert.Equal(number,70);
    }
    [Fact]
    public void IncorectConvertStingToDouble()
    {
        Assert.Throws<Exception>(()=>Program.StringtoDouble("APisit"));
    }
    [Fact]
    public void CheckBoolThousandTrue()
    {
        int money = 1000;
        Assert.True(Calculator.Thousand_Check(money));
        
    }
    [Fact]
     public void CheckBoolFiveHundredFalse()
    {
        int money = 1000;
        Assert.False(Calculator.FiveHundred_Check(money));
    }
    [Fact]
     public void CheckBoolHundredTrue()
    {
        int money = 250;
        Assert.True(Calculator.Hundred_Check(money));
    }
    [Fact]
     public void CheckBoolFiftyFalse()
    {
        int money = 30;
        Assert.False(Calculator.Fifty_Check(money));
    }
     [Fact]
     public void CheckBoolTwentyTrue()
    {
        int money = 30;
        Assert.True(Calculator.Twenty_Check(money));
    }
    [Fact]
     public void CheckBoolTenfalse()
    {
        int money = 30;
        Assert.False(Calculator.Ten_Check(money));
    }
    [Fact]
     public void CheckBoolFivetrue()
    {
        int money = 5;
        Assert.True(Calculator.Five_Check(money));
    }

    [Fact]
     public void CheckBoolTwotrue()
    {
        int money = 2;
        Assert.True(Calculator.Two_Check(money));
    }
    [Fact]
     public void CheckBoolOnefalse()
    {
        int money = 40;
        Assert.False(Calculator.One_Check(money));
    }
    [Fact]
     public void PointFive_CheckTrue()
    {
        double money = 0.65;
        Assert.True(Calculator.PointFive_Check(money));
    }
    [Fact]
     public void PointTwoFive_CheckFalse()
    {
        double money = 0.8;
        Assert.False(Calculator.PointTwoFive_Check(money));
    }
    










}