using Ant_3_Arena.Enums;
using Ant_3_Arena.Strategies;
using Ant_3_Arena.ValueObject;
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
    [InlineData(LOWER_THAN_ZERO, LOWER_THAN_ZERO, DiagonalDirectionEnum.RightDown)]
    [InlineData(LOWER_THAN_ZERO, ZERO, DiagonalDirectionEnum.RightUp)]
    [InlineData(ZERO, LOWER_THAN_ZERO, DiagonalDirectionEnum.LeftDown)]
    public void Move_WhenDirectionLeftUp_ShouldMoveToTarget(int x, int y, DiagonalDirectionEnum target)
    {
        // Arrange
        var strategy = new DiagonalMovementStrategy(DiagonalDirectionEnum.LeftUp);
        var position = new Position2D() { X = x, Y = y };
        var velocity = new Velocity2D();

        // Act
        strategy.Move(new(), position, velocity);

        // Assert
        strategy.Direction.Should().Be(target);
    }

    [Theory]
    [InlineData(LOWER_THAN_ZERO, BIGGERT_THAN_HEIGHT, DiagonalDirectionEnum.RightUp)]
    [InlineData(LOWER_THAN_ZERO, ZERO, DiagonalDirectionEnum.RightDown)]
    [InlineData(ZERO, BIGGERT_THAN_HEIGHT, DiagonalDirectionEnum.LeftUp)]
    public void Move_WhenDirectionLeftDown_ShouldMoveToTarget(int x, int y, DiagonalDirectionEnum target)
    {
        // Arrange
        var strategy = new DiagonalMovementStrategy(DiagonalDirectionEnum.LeftDown);
        var position = new Position2D() { X = x, Y = y };
        var velocity = new Velocity2D();

        // Act
        strategy.Move(new() { Height = HEIGHT }, position, velocity);

        // Assert
        strategy.Direction.Should().Be(target);
    }

    [Theory]
    [InlineData(BIGGERT_THAN_WIDTH, LOWER_THAN_ZERO, DiagonalDirectionEnum.LeftDown)]
    [InlineData(BIGGERT_THAN_WIDTH, ZERO, DiagonalDirectionEnum.LeftUp)]
    [InlineData(ZERO, LOWER_THAN_ZERO, DiagonalDirectionEnum.RightDown)]
    public void Move_WhenDirectionRightUp_ShouldMoveToTarget(int x, int y, DiagonalDirectionEnum target)
    {
        // Arrange
        var strategy = new DiagonalMovementStrategy(DiagonalDirectionEnum.RightUp);
        var position = new Position2D() { X = x, Y = y };
        var velocity = new Velocity2D();

        // Act
        strategy.Move(new() { Width = WIDTH }, position, velocity);

        // Assert
        strategy.Direction.Should().Be(target);
    }

    [Theory]
    [InlineData(BIGGERT_THAN_WIDTH, BIGGERT_THAN_HEIGHT, DiagonalDirectionEnum.LeftUp)]
    [InlineData(BIGGERT_THAN_WIDTH, ZERO, DiagonalDirectionEnum.LeftDown)]
    [InlineData(ZERO, BIGGERT_THAN_HEIGHT, DiagonalDirectionEnum.RightUp)]
    public void Move_WhenDirectionRightDown_ShouldMoveToTarget(int x, int y, DiagonalDirectionEnum target)
    {
        // Arrange
        var strategy = new DiagonalMovementStrategy(DiagonalDirectionEnum.RightDown);
        var position = new Position2D() { X = x, Y = y };
        var velocity = new Velocity2D();

        // Act
        strategy.Move(new() { Width = WIDTH, Height = HEIGHT }, position, velocity);

        // Assert
        strategy.Direction.Should().Be(target);
    }
}
