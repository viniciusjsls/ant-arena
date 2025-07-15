using Ant_3_Arena.Ants;
using Ant_3_Arena.Enums;
using Ant_3_Arena.ValueObject;
using System.Drawing;

namespace Ant_3_Arena.Strategies
{
    public interface IMovementStrategy
    {
        DirectionEnum Move(Size borders, DirectionEnum direction, Position2D position, Velocity2D velocity);
    }
}
