using Ant_3_Arena.Enums;
using Ant_3_Arena.ValueObject;
using System.Drawing;

namespace Ant_3_Arena.Strategies
{
    public class SquareMovementStrategy : BaseMovement, IMovementStrategy
    {
        public const int PADDING = 100;
        public SquareDirectionEnum Direction { get; private set; }

        public SquareMovementStrategy(SquareDirectionEnum direction)
        {
            Direction = direction;
        }

        public void Move(Size borders, Position2D position, Velocity2D velocity)
        {
            switch (Direction)
            {
                case SquareDirectionEnum.Left:
                    MoveLeft(position, velocity);

                    if (position.X < PADDING)
                        Direction = SquareDirectionEnum.Down;
                    break;
                case SquareDirectionEnum.Down:
                    MoveDown(position, velocity);

                    if (position.Y > (borders.Height - PADDING))
                        Direction = SquareDirectionEnum.Right;
                    break;
                case SquareDirectionEnum.Right:
                    MoveRight(position, velocity);

                    if (position.X > (borders.Width - PADDING))
                        Direction = SquareDirectionEnum.Up;
                    break;
                case SquareDirectionEnum.Up:
                    MoveUp(position, velocity);

                    if (position.Y < PADDING)
                        Direction = SquareDirectionEnum.Left;
                    break;
            }
        }
    }
}
