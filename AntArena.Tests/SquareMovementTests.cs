using Ant_3_Arena.Enums;
using Ant_3_Arena.Strategies;
using Ant_3_Arena.ValueObject;
using FluentAssertions;

namespace AntArena.Tests
{
    public class SquareMovementTests
    {
        private const int SCREEN = 800;
        private const int VELOCITY = 351;

        [Fact]
        public void Move_WhenDirectionLeft_ShouldMoveToTarget()
        {
            // Arrange
            var strategy = new SquareMovementStrategy(SquareDirectionEnum.Left);
            var position = new Position2D() { X = SCREEN, Y = 0 };
            var velocity = new Velocity2D() { HorizontalVelocity = VELOCITY };

            // Act
            strategy.Move(new(), position, velocity);
            strategy.Move(new(), position, velocity);

            // Assert
            strategy.Direction.Should().Be(SquareDirectionEnum.Down);
        }

        [Fact]
        public void Move_WhenDirectionDown_ShouldMoveToTarget()
        {
            // Arrange
            var strategy = new SquareMovementStrategy(SquareDirectionEnum.Down);
            var position = new Position2D() { X = 0, Y = 0 };
            var velocity = new Velocity2D() { VerticalVelocity = VELOCITY };

            // Act
            strategy.Move(new() { Height = SCREEN }, position, velocity);
            strategy.Move(new() { Height = SCREEN }, position, velocity);

            // Assert
            strategy.Direction.Should().Be(SquareDirectionEnum.Right);
        }

        [Fact]
        public void Move_WhenDirectionRight_ShouldMoveToTarget()
        {
            // Arrange
            var strategy = new SquareMovementStrategy(SquareDirectionEnum.Right);
            var position = new Position2D() { X = 0, Y = 0 };
            var velocity = new Velocity2D() { HorizontalVelocity = VELOCITY };

            // Act
            strategy.Move(new() { Width = SCREEN }, position, velocity);
            strategy.Move(new() { Width = SCREEN }, position, velocity);

            // Assert
            strategy.Direction.Should().Be(SquareDirectionEnum.Up);
        }

        [Fact]
        public void Move_WhenDirectionUp_ShouldMoveToTarget()
        {
            // Arrange
            var strategy = new SquareMovementStrategy(SquareDirectionEnum.Up);
            var position = new Position2D() { X = 0, Y = SCREEN };
            var velocity = new Velocity2D() { VerticalVelocity = VELOCITY };

            // Act
            strategy.Move(new() { Height = SCREEN }, position, velocity);
            strategy.Move(new() { Height = SCREEN }, position, velocity);

            // Assert
            strategy.Direction.Should().Be(SquareDirectionEnum.Left);
        }
    }
}
