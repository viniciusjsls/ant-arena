using Ant_3_Arena.Ants;
using Ant_3_Arena.Constants;
using FluentAssertions;
using System.Drawing;

namespace AntArena.Tests
{
    public class AntTests
    {
        [Fact]
        public void Ant_WhenCreating_ShouldMatchColor()
        {
            // Arrange / Act
            var yellowAnt = new AntYellow(new());
            var redAnt = new AntRed(new());
            var blackAnt = new AntBlack(new());

            // Assert
            yellowAnt.AntImage.GetPixel(yellowAnt.AntImage.Width / 2, yellowAnt.AntImage.Height / 2).Should().Be(ColorTranslator.FromHtml(ColorConstant.YELLOW));
            redAnt.AntImage.GetPixel(redAnt.AntImage.Width / 2, redAnt.AntImage.Height / 2).Should().Be(ColorTranslator.FromHtml(ColorConstant.RED));
            blackAnt.AntImage.GetPixel(yellowAnt.AntImage.Width / 2, blackAnt.AntImage.Height / 2).Should().Be(ColorTranslator.FromHtml(ColorConstant.BLACK));
        }
    }
}
