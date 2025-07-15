using Ant_3_Arena.Enums;
using Ant_3_Arena.Strategies;
using Ant_3_Arena.ValueObject;
using FluentAssertions;

namespace AntArena.Tests;

public class DiagonalMovementTests
{
    private const int VELOCITY = 51;
    private const int SCREEN = 200;
    private const int MIDDLE = 100;

    [Theory]
    [InlineData(VELOCITY, VELOCITY, DiagonalDirectionEnum.RightDown)]
    [InlineData(VELOCITY, 0, DiagonalDirectionEnum.RightUp)]
    [InlineData(0, VELOCITY, DiagonalDirectionEnum.LeftDown)]
    public void Move_WhenDirectionLeftUp_ShouldMoveToTarget(int h, int v, DiagonalDirectionEnum target)
    {
        // Arrange
        var strategy = new DiagonalMovementStrategy(DiagonalDirectionEnum.LeftUp);
        var position = new Position2D() { X = MIDDLE, Y = MIDDLE };
        var velocity = new Velocity2D() { HorizontalVelocity = h, VerticalVelocity = v };

        // Act
        strategy.Move(new() { Height = SCREEN, Width = SCREEN }, position, velocity);
        strategy.Move(new() { Height = SCREEN, Width = SCREEN }, position, velocity);

        // Assert
        strategy.Direction.Should().Be(target);
    }

    [Theory]
    [InlineData(VELOCITY, VELOCITY, DiagonalDirectionEnum.RightUp)]
    [InlineData(VELOCITY, 0, DiagonalDirectionEnum.RightDown)]
    [InlineData(0, VELOCITY, DiagonalDirectionEnum.LeftUp)]
    public void Move_WhenDirectionLeftDown_ShouldMoveToTarget(int h, int v, DiagonalDirectionEnum target)
    {
        // Arrange
        var strategy = new DiagonalMovementStrategy(DiagonalDirectionEnum.LeftDown);
        var position = new Position2D() { X = MIDDLE, Y = MIDDLE };
        var velocity = new Velocity2D() { HorizontalVelocity = h, VerticalVelocity = v };

        // Act
        strategy.Move(new() { Height = SCREEN, Width = SCREEN }, position, velocity);
        strategy.Move(new() { Height = SCREEN, Width = SCREEN }, position, velocity);

        // Assert
        strategy.Direction.Should().Be(target);
    }

    [Theory]
    [InlineData(VELOCITY, VELOCITY, DiagonalDirectionEnum.LeftDown)]
    [InlineData(VELOCITY, 0, DiagonalDirectionEnum.LeftUp)]
    [InlineData(0, VELOCITY, DiagonalDirectionEnum.RightDown)]
    public void Move_WhenDirectionRightUp_ShouldMoveToTarget(int h, int v, DiagonalDirectionEnum target)
    {
        // Arrange
        var strategy = new DiagonalMovementStrategy(DiagonalDirectionEnum.RightUp);
        var position = new Position2D() { X = MIDDLE, Y = MIDDLE };
        var velocity = new Velocity2D() { HorizontalVelocity = h, VerticalVelocity = v };

        // Act
        strategy.Move(new() { Height = SCREEN, Width = SCREEN }, position, velocity);
        strategy.Move(new() { Height = SCREEN, Width = SCREEN }, position, velocity);

        // Assert
        strategy.Direction.Should().Be(target);
    }

    [Theory]
    [InlineData(VELOCITY, VELOCITY, DiagonalDirectionEnum.LeftUp)]
    [InlineData(VELOCITY, 0, DiagonalDirectionEnum.LeftDown)]
    [InlineData(0, VELOCITY, DiagonalDirectionEnum.RightUp)]
    public void Move_WhenDirectionRightDown_ShouldMoveToTarget(int h, int v, DiagonalDirectionEnum target)
    {
        // Arrange
        var strategy = new DiagonalMovementStrategy(DiagonalDirectionEnum.RightDown);
        var position = new Position2D() { X = MIDDLE, Y = MIDDLE };
        var velocity = new Velocity2D() { HorizontalVelocity = h, VerticalVelocity = v };

        // Act
        strategy.Move(new() { Height = SCREEN, Width = SCREEN }, position, velocity);
        strategy.Move(new() { Height = SCREEN, Width = SCREEN }, position, velocity);

        // Assert
        strategy.Direction.Should().Be(target);
    }
}
