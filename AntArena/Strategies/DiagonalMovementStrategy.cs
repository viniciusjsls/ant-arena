using Ant_3_Arena.Enums;
using Ant_3_Arena.ValueObject;
using System;
using System.Drawing;

namespace Ant_3_Arena.Strategies
{
    public class DiagonalMovementStrategy : BaseMovement, IMovementStrategy
    {
        public DiagonalDirectionEnum Direction { get; private set; }

        public DiagonalMovementStrategy(DiagonalDirectionEnum direction)
        {
            Direction = direction;
        }

        public void Move(Size borders, Position2D position, Velocity2D velocity)
        {
            switch (Direction)
            {
                case DiagonalDirectionEnum.LeftUp:
                    MoveLeft(position, velocity);
                    MoveUp(position, velocity);

                    if (position.X < 0 && position.Y < 0)
                        Direction = DiagonalDirectionEnum.RightDown;
                    else if (position.X < 0)
                        Direction = DiagonalDirectionEnum.RightUp;
                    else if (position.Y < 0)
                        Direction = DiagonalDirectionEnum.LeftDown;
                    break;
                case DiagonalDirectionEnum.LeftDown:
                    MoveLeft(position, velocity);
                    MoveDown(position, velocity);

                    if (position.X < 0 && position.Y > borders.Height)
                        Direction = DiagonalDirectionEnum.RightUp;
                    else if (position.X < 0)
                        Direction = DiagonalDirectionEnum.RightDown;
                    else if (position.Y > borders.Height)
                        Direction = DiagonalDirectionEnum.LeftUp;
                    break;
                case DiagonalDirectionEnum.RightUp:
                    MoveRight(position, velocity);
                    MoveUp(position, velocity);

                    if (position.X > borders.Width && position.Y < 0)
                        Direction = DiagonalDirectionEnum.LeftDown;
                    else if (position.X > borders.Width)
                        Direction = DiagonalDirectionEnum.LeftUp;
                    else if (position.Y < 0)
                        Direction = DiagonalDirectionEnum.RightDown;
                    break;
                case DiagonalDirectionEnum.RightDown:
                    MoveRight(position, velocity);
                    MoveDown(position, velocity);

                    if (position.X > borders.Width && position.Y > borders.Height)
                        Direction = DiagonalDirectionEnum.LeftUp;
                    else if (position.X > borders.Width)
                        Direction = DiagonalDirectionEnum.LeftDown;
                    else if (position.Y > borders.Height)
                        Direction = DiagonalDirectionEnum.RightUp;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(Direction));
            }
        }
    }
}
