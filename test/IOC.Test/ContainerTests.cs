using FluentAssertions;
using Xunit;

namespace IOC.Test
{
    public class ContainerTests
    {
        [Fact]
        public void SanityCheck() => true.Should().BeTrue();
    }
}