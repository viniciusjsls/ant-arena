using Ant_3_Arena.Ants;
using Ant_3_Arena.Enums;
using FluentAssertions;

namespace AntArena.Tests;

public class DiagonalMovementTests
{
    private const int WIDTH = 100;
    private const int HEIGHT = 200;
    private const int BIGGERT_THAN_WIDTH = 110;
    private const int BIGGERT_THAN_HEIGHT = 220;
    private const int BIGGER_THAN_ZERO = 10;
    private const int LOWER_THAN_ZERO = -10;
    private const int ZERO = 0;

    [Theory]
    [InlineData(LOWER_THAN_ZERO, LOWER_THAN_ZERO, DirectionEnum.RightDown)]
    [InlineData(LOWER_THAN_ZERO, ZERO, DirectionEnum.RightUp)]
    [InlineData(ZERO, LOWER_THAN_ZERO, DirectionEnum.LeftDown)]
    public void Move_WhenDirectionLeftUp_ShouldMoveToTarget(int x, int y, DirectionEnum target)
    {
        // Arrange
        var ant = new AntYellow(new());
        ant.X = x;
        ant.Y = y;

        // Act
        ant.Move(new());

        // Assert
        ant.Direction.Should().Be(target);
    }

    [Theory]
    [InlineData(LOWER_THAN_ZERO, BIGGERT_THAN_WIDTH, DirectionEnum.RightUp)]
    [InlineData(LOWER_THAN_ZERO, ZERO, DirectionEnum.RightDown)]
    [InlineData(BIGGER_THAN_ZERO, BIGGERT_THAN_WIDTH, DirectionEnum.LeftUp)]
    public void Move_WhenDirectionLeftDown_ShouldMoveToTarget(int x, int y, DirectionEnum target)
    {
        // Arrange
        var ant = new AntYellow(new());
        ant.Direction = DirectionEnum.LeftDown;
        ant.X = x;
        ant.Y = y;

        // Act
        ant.Move(new() { Height = 100 });

        // Assert
        ant.Direction.Should().Be(target);
    }

    [Theory]
    [InlineData(BIGGERT_THAN_WIDTH, LOWER_THAN_ZERO, DirectionEnum.LeftDown)]
    [InlineData(BIGGERT_THAN_WIDTH, BIGGER_THAN_ZERO, DirectionEnum.LeftUp)]
    [InlineData(ZERO, LOWER_THAN_ZERO, DirectionEnum.RightDown)]
    public void Move_WhenDirectionRightUp_ShouldMoveToTarget(int x, int y, DirectionEnum target)
    {
        // Arrange
        var ant = new AntYellow(new());
        ant.Direction = DirectionEnum.RightUp;
        ant.X = x;
        ant.Y = y;

        // Act
        ant.Move(new() { Width = 100 });

        // Assert
        ant.Direction.Should().Be(target);
    }

    [Theory]
    [InlineData(BIGGERT_THAN_WIDTH, BIGGERT_THAN_HEIGHT, DirectionEnum.LeftUp)]
    [InlineData(BIGGERT_THAN_WIDTH, ZERO, DirectionEnum.LeftDown)]
    [InlineData(ZERO, LOWER_THAN_ZERO, DirectionEnum.RightDown)]
    public void Move_WhenDirectionRightDown_ShouldMoveToTarget(int x, int y, DirectionEnum target)
    {
        // Arrange
        var ant = new AntYellow(new());
        ant.Direction = DirectionEnum.RightDown;
        ant.X = x;
        ant.Y = y;

        // Act
        ant.Move(new() { Width = WIDTH, Height = HEIGHT });

        // Assert
        ant.Direction.Should().Be(target);
    }
}
