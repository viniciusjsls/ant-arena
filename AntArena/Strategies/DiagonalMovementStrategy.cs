using Ant_3_Arena.Enums;
using Ant_3_Arena.ValueObject;
using System;
using System.Drawing;

namespace Ant_3_Arena.Strategies
{
    public class DiagonalMovementStrategy : BaseMovement, IMovementStrategy
    {
        public DiagonalDirectionEnum Direction { get; private set; }
        private int UpperLimit { get; set; }

        public DiagonalMovementStrategy(DiagonalDirectionEnum direction, int upperLimit = 0)
        {
            Direction = direction;
            UpperLimit = upperLimit;
        }

        public void Move(Size borders, Position2D position, Velocity2D velocity)
        {
            switch (Direction)
            {
                case DiagonalDirectionEnum.LeftUp:
                    MoveLeft(position, velocity);
                    MoveUp(position, velocity);

                    if (position.X < 0 && position.Y < UpperLimit)
                        Direction = DiagonalDirectionEnum.RightDown;
                    else if (position.X < 0)
                        Direction = DiagonalDirectionEnum.RightUp;
                    else if (position.Y < UpperLimit)
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

                    if (position.X > borders.Width && position.Y < UpperLimit)
                        Direction = DiagonalDirectionEnum.LeftDown;
                    else if (position.X > borders.Width)
                        Direction = DiagonalDirectionEnum.LeftUp;
                    else if (position.Y < UpperLimit)
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
