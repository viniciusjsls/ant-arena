using Ant_3_Arena.Enums;
using Ant_3_Arena.Strategies;
using Ant_3_Arena.ValueObject;
using System.Drawing;

namespace Ant_3_Arena.Ants
{
    public class Ant
    {
        public DirectionEnum Direction { get; private set; }
        public Position2D Position { get; private set; }
        public Velocity2D Velocity { get; private set; }

        private readonly IMovementStrategy Movement;

        public Ant(
            DirectionEnum direction,
            int horizontalVelocity,
            int verticalVelocity,
            IMovementStrategy movementStrategy)
        {
            Direction = direction;
            Velocity = new Velocity2D() { HorizontalVelocity = horizontalVelocity, VerticalVelocity = verticalVelocity };
            Movement = movementStrategy;
        }

        public void Move(Size borders)
        {
            Direction = Movement.Move(borders, Direction, Position, Velocity);
        }
    }
}
