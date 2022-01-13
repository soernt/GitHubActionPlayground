using Xunit;

namespace MyPackage.Tests;

public class UnitTest1
{
    [Theory]
    [InlineData("fred")]
    [InlineData("wilma")]
    [InlineData("betty")]
    [InlineData("barny")]
    public void Test1(string testData)
    {
        // Arrange
        var classUnderTest = new ThePackageClass();
        
        // Act
        var result = classUnderTest.DoReturnThis(testData);

        // Assert
        Assert.Equal(result, testData);
    }
}