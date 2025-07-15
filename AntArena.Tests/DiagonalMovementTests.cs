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
    [InlineData(LOWER_THAN_ZERO, LOWER_THAN_ZERO, DirectionEnum.RightDown)]
    [InlineData(LOWER_THAN_ZERO, ZERO, DirectionEnum.RightUp)]
    [InlineData(ZERO, LOWER_THAN_ZERO, DirectionEnum.LeftDown)]
    public void Move_WhenDirectionLeftUp_ShouldMoveToTarget(int x, int y, DirectionEnum target)
    {
        // Arrange
        var strategy = new DiagonalMovementStrategy();
        var position = new Position2D() { X = x, Y = y };
        var velocity = new Velocity2D();

        // Act
        var response = strategy.Move(new(), DirectionEnum.LeftUp, position, velocity);

        // Assert
        response.Should().Be(target);
    }

    [Theory]
    [InlineData(LOWER_THAN_ZERO, BIGGERT_THAN_HEIGHT, DirectionEnum.RightUp)]
    [InlineData(LOWER_THAN_ZERO, ZERO, DirectionEnum.RightDown)]
    [InlineData(ZERO, BIGGERT_THAN_HEIGHT, DirectionEnum.LeftUp)]
    public void Move_WhenDirectionLeftDown_ShouldMoveToTarget(int x, int y, DirectionEnum target)
    {
        // Arrange
        var strategy = new DiagonalMovementStrategy();
        var position = new Position2D() { X = x, Y = y };
        var velocity = new Velocity2D();

        // Act
        var response = strategy.Move(new() { Height = HEIGHT }, DirectionEnum.LeftDown, position, velocity);

        // Assert
        response.Should().Be(target);
    }

    [Theory]
    [InlineData(BIGGERT_THAN_WIDTH, LOWER_THAN_ZERO, DirectionEnum.LeftDown)]
    [InlineData(BIGGERT_THAN_WIDTH, ZERO, DirectionEnum.LeftUp)]
    [InlineData(ZERO, LOWER_THAN_ZERO, DirectionEnum.RightDown)]
    public void Move_WhenDirectionRightUp_ShouldMoveToTarget(int x, int y, DirectionEnum target)
    {
        // Arrange
        var strategy = new DiagonalMovementStrategy();
        var position = new Position2D() { X = x, Y = y };
        var velocity = new Velocity2D();

        // Act
        var response = strategy.Move(new() { Width = WIDTH }, DirectionEnum.RightUp, position, velocity);

        // Assert
        response.Should().Be(target);
    }

    [Theory]
    [InlineData(BIGGERT_THAN_WIDTH, BIGGERT_THAN_HEIGHT, DirectionEnum.LeftUp)]
    [InlineData(BIGGERT_THAN_WIDTH, ZERO, DirectionEnum.LeftDown)]
    [InlineData(ZERO, BIGGERT_THAN_HEIGHT, DirectionEnum.RightUp)]
    public void Move_WhenDirectionRightDown_ShouldMoveToTarget(int x, int y, DirectionEnum target)
    {
        // Arrange
        var strategy = new DiagonalMovementStrategy();
        var position = new Position2D() { X = x, Y = y };
        var velocity = new Velocity2D();

        // Act
        var response = strategy.Move(new() { Width = WIDTH, Height = HEIGHT }, DirectionEnum.RightDown, position, velocity);

        // Assert
        response.Should().Be(target);
    }
}
