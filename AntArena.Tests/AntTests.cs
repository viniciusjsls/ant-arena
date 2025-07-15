using Ant_3_Arena.Ants;
using Ant_3_Arena.Constants;
using Ant_3_Arena.Factories;
using FluentAssertions;
using System.Drawing;

namespace AntArena.Tests
{
    public class AntTests
    {
        private readonly IAntFactory redFactory = new AntRedFactory();
        private readonly IAntFactory yellowFactory = new AntYellowFactory();
        private readonly IAntFactory blackFactory = new AntBlackFactory();
        private readonly IAntFactory whiteFactory = new AntWhiteFactory();

        [Fact]
        public void RedwAnt_WhenCreating_ShouldMatchColor()
        {
            // Arrange
            var factory = new AntRedFactory();

            // Act
            var ant = factory.Create(new());

            // Assert
            AssertAnt(ant, ColorConstant.RED);
        }

        [Fact]
        public void YellowAnt_WhenCreating_ShouldMatchColor()
        {
            // Arrange
            var factory = new AntYellowFactory();

            // Act
            var ant = factory.Create(new());

            // Assert
            AssertAnt(ant, ColorConstant.YELLOW);
        }

        [Fact]
        public void BlackAnt_WhenCreating_ShouldMatchColor()
        {
            // Arrange
            var factory = new AntBlackFactory();

            // Act
            var ant = factory.Create(new());

            // Assert
            AssertAnt(ant, ColorConstant.BLACK);
        }

        [Fact]
        public void WhiteAnt_WhenCreating_ShouldMatchColor()
        {
            // Arrange
            var factory = new AntWhiteFactory();

            // Act
            var ant = factory.Create(new());

            // Assert
            AssertAnt(ant, ColorConstant.WHITE);
        }

        private void AssertAnt(Ant ant, string color)
        {
            ant.AntImage.GetPixel(ant.AntImage.Width / 2, ant.AntImage.Height / 2).Should().Be(ColorTranslator.FromHtml(color));
        }
    }
}
