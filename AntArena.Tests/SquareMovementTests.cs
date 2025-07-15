using Ant_3_Arena.Enums;
using Ant_3_Arena.Strategies;
using Ant_3_Arena.ValueObject;
using FluentAssertions;

namespace AntArena.Tests
{
    public class SquareMovementTests
    {
        [Fact]
        public void Move_WhenDirectionLeft_ShouldMoveToTarget()
        {
            // Arrange
            int screenWidth = 800;
            var strategy = new SquareMovementStrategy(SquareDirectionEnum.Left);
            var position = new Position2D() { X = screenWidth, Y = 0 };
            var velocity = new Velocity2D() { HorizontalVelocity = 351 };

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
            int screenHeight = 800;
            var strategy = new SquareMovementStrategy(SquareDirectionEnum.Down);
            var position = new Position2D() { X = 0, Y = 0 };
            var velocity = new Velocity2D() { VerticalVelocity = 351 };

            // Act
            strategy.Move(new() { Height = screenHeight }, position, velocity);
            strategy.Move(new() { Height = screenHeight }, position, velocity);

            // Assert
            strategy.Direction.Should().Be(SquareDirectionEnum.Right);
        }

        [Fact]
        public void Move_WhenDirectionRight_ShouldMoveToTarget()
        {
            // Arrange
            int screenWidth = 800;
            var strategy = new SquareMovementStrategy(SquareDirectionEnum.Right);
            var position = new Position2D() { X = 0, Y = 0 };
            var velocity = new Velocity2D() { HorizontalVelocity = 351 };

            // Act
            strategy.Move(new() { Width = screenWidth }, position, velocity);
            strategy.Move(new() { Width = screenWidth }, position, velocity);

            // Assert
            strategy.Direction.Should().Be(SquareDirectionEnum.Up);
        }

        [Fact]
        public void Move_WhenDirectionUp_ShouldMoveToTarget()
        {
            // Arrange
            int screenHeight = 800;
            var strategy = new SquareMovementStrategy(SquareDirectionEnum.Up);
            var position = new Position2D() { X = 0, Y = screenHeight };
            var velocity = new Velocity2D() { VerticalVelocity = 351 };

            // Act
            strategy.Move(new() { Height = screenHeight }, position, velocity);
            strategy.Move(new() { Height = screenHeight }, position, velocity);

            // Assert
            strategy.Direction.Should().Be(SquareDirectionEnum.Left);
        }
    }
}
