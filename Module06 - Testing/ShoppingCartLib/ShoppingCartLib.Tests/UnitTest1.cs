using FluentAssertions;

namespace ShoppingCartLib.Tests;

public class UnitTest1
{
    [Fact]
    public void ANewCartShouldBeEmpty()
    {
        var sut = new ShoppingCart();
        sut.Get().Should().BeEquivalentTo([]);
    }

    [Fact]
    public void AddAProduct()
    {
        var sut = new ShoppingCart();
        sut.Add("Docker course");
        sut.Get().Should().BeEquivalentTo(["Docker course"]);
    }
}