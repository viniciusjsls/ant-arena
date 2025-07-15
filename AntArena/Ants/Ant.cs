using Ant_3_Arena.Enums;
using Ant_3_Arena.Strategies;
using Ant_3_Arena.ValueObject;
using System.Drawing;

namespace Ant_3_Arena.Ants
{
    public class Ant
    {
        public Position2D Position { get; private set; }
        public Velocity2D Velocity { get; private set; }

        private readonly IMovementStrategy Movement;

        public Ant(
            int horizontalVelocity,
            int verticalVelocity,
            IMovementStrategy movementStrategy)
        {
            Velocity = new Velocity2D() { HorizontalVelocity = horizontalVelocity, VerticalVelocity = verticalVelocity };
            Movement = movementStrategy;
        }

        public void Move(Size borders)
        {
            Movement.Move(borders, Position, Velocity);
        }
    }
}
