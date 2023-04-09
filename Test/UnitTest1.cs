namespace Test;

public class UnitTest1
{
    [Fact]
    public void TestAnswer()
    {
        Assert.Equal(42, Stuff.Answer);
    }
}