using Ant_3_Arena.Ants;
using Ant_3_Arena.Constants;
using Ant_3_Arena.Factories;
using Ant_3_Arena.Strategies;
using FluentAssertions;
using System.Drawing;

namespace AntArena.Tests
{
    public class AntTests
    {
        private readonly IAntFactory redFactory = new AntRedFactory();
        private readonly IAntFactory yellowFactory = new AntYellowFactory();
        private readonly IAntFactory blackFactory = new AntBlackFactory();

        [Fact]
        public void Ant_WhenCreating_ShouldMatchColor()
        {
            // Arrange / Act
            var redAnt = redFactory.Create(new());
            var yellowAnt = yellowFactory.Create(new());
            var blackAnt = blackFactory.Create(new());

            // Assert
            yellowAnt.AntImage.GetPixel(yellowAnt.AntImage.Width / 2, yellowAnt.AntImage.Height / 2).Should().Be(ColorTranslator.FromHtml(ColorConstant.YELLOW));
            redAnt.AntImage.GetPixel(redAnt.AntImage.Width / 2, redAnt.AntImage.Height / 2).Should().Be(ColorTranslator.FromHtml(ColorConstant.RED));
            blackAnt.AntImage.GetPixel(yellowAnt.AntImage.Width / 2, blackAnt.AntImage.Height / 2).Should().Be(ColorTranslator.FromHtml(ColorConstant.BLACK));
        }
    }
}
