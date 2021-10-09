using Core;
using FluentAssertions;
using Xunit;

namespace Tests
{
    public class Tests
    {

        [Theory]
        [InlineData("{}")]
        [InlineData("()")]
        [InlineData("[]")]
        public void When_Single_Pairs_Do_They_Balance(string testString)
        {
            // ARRANGE
            var bracketChecker = new BalancedBracketsChecker();

            // ACT
            var result = bracketChecker.Test(testString);

            // ASSERT
            result.Should().BeTrue();
        }

        [Theory]
        [InlineData("{]")]
        [InlineData("[)")]
        [InlineData("[}")]
        public void When_No_Single_Pairs_Do_They_Not_Balance(string testString)
        {
            // ARRANGE
            var bracketChecker = new BalancedBracketsChecker();

            // ACT
            var result = bracketChecker.Test(testString);

            // ASSERT
            result.Should().BeFalse();
        }
    }
}
