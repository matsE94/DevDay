using FluentAssertions;
using Xunit;

namespace CQRS.Test
{
    public class ExecutorTests
    {
        [Fact]
        public void SanityCheck() => true.Should().BeTrue();
    }
}