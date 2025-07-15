using Ant_3_Arena.Enums;
using Ant_3_Arena.ValueObject;
using System;
using System.Drawing;

namespace Ant_3_Arena.Strategies
{
    public class DiagonalMovementStrategy : BaseMovement, IMovementStrategy
    {
        public DirectionEnum Move(Size borders, DirectionEnum direction, Position2D position, Velocity2D velocity)
        {
            switch (direction)
            {
                case DirectionEnum.LeftUp:
                    MoveLeft(position, velocity);
                    MoveUp(position, velocity);

                    if (position.X < 0 && position.Y < 0)
                        return DirectionEnum.RightDown;
                    else if (position.X < 0)
                        return DirectionEnum.RightUp;
                    else if (position.Y < 0)
                        return DirectionEnum.LeftDown;
                    break;
                case DirectionEnum.LeftDown:
                    MoveLeft(position, velocity);
                    MoveDown(position, velocity);

                    if (position.X < 0 && position.Y > borders.Height)
                        return DirectionEnum.RightUp;
                    else if (position.X < 0)
                        return DirectionEnum.RightDown;
                    else if (position.Y > borders.Height)
                        return DirectionEnum.LeftUp;
                    break;
                case DirectionEnum.RightUp:
                    MoveRight(position, velocity);
                    MoveUp(position, velocity);

                    if (position.X > borders.Width && position.Y < 0)
                        return DirectionEnum.LeftDown;
                    else if (position.X > borders.Width)
                        return DirectionEnum.LeftUp;
                    else if (position.Y < 0)
                        return DirectionEnum.RightDown;
                    break;
                case DirectionEnum.RightDown:
                    MoveRight(position, velocity);
                    MoveDown(position, velocity);

                    if (position.X > borders.Width && position.Y > borders.Height)
                        return DirectionEnum.LeftUp;
                    else if (position.X > borders.Width)
                        return DirectionEnum.LeftDown;
                    else if (position.Y > borders.Height)
                        return DirectionEnum.RightUp;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(direction));
            }

            return direction;
        }
    }
}
