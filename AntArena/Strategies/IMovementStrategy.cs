using Ant_3_Arena.Ants;
using Ant_3_Arena.Enums;
using Ant_3_Arena.ValueObject;
using System.Drawing;

namespace Ant_3_Arena.Strategies
{
    public interface IMovementStrategy
    {
        void Move(Size borders, Position2D position, Velocity2D velocity);
    }
}
