using Ant_3_Arena.ValueObject;

namespace Ant_3_Arena.Strategies
{
    public abstract class BaseMovement
    {
        protected void MoveRight(Position2D position, Velocity2D velocity)
        {
            position.X += velocity.HorizontalVelocity;
        }

        protected void MoveLeft(Position2D position, Velocity2D velocity)
        {
            position.X -= velocity.HorizontalVelocity;
        }

        protected void MoveUp(Position2D position, Velocity2D velocity)
        {
            position.Y -= velocity.VerticalVelocity;
        }

        protected void MoveDown(Position2D position, Velocity2D velocity)
        {
            position.Y += velocity.VerticalVelocity;
        }
    }
}
