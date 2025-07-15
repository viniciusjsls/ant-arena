using Ant_3_Arena.Ants;
using Ant_3_Arena.Constants;
using Ant_3_Arena.Enums;
using Ant_3_Arena.Strategies;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Ant_3_Arena.Factories
{
    // extension method to make it easier
    public static class AntFactoryHelper
    {
        public static IEnumerable<Ant> CreateMany(this IAntFactory factory, Size borders, int amount)
        {
            return Enumerable.Range(0, amount).Select(x => factory.Create(borders));
        }
    }

    // factories
    public class AntRedFactory : IAntFactory
    {
        public Ant Create(Size borders)
        {
            return new Ant(borders, ColorConstant.RED, 6, 6, new DiagonalMovementStrategy(DiagonalDirectionEnum.LeftUp));
        }
    }

    public class AntYellowFactory : IAntFactory
    {
        public Ant Create(Size borders)
        {
            return new Ant(borders, ColorConstant.YELLOW, 4, 4, new DiagonalMovementStrategy(DiagonalDirectionEnum.RightDown));
        }
    }

    public class AntBlackFactory : IAntFactory
    {
        public Ant Create(Size borders)
        {
            return new Ant(borders, ColorConstant.BLACK, 2, 6, new DiagonalMovementStrategy(DiagonalDirectionEnum.RightUp, 500));
        }
    }
}
