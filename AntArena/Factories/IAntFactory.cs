using Ant_3_Arena.Ants;
using System.Drawing;

namespace Ant_3_Arena.Factories
{
    public interface IAntFactory
    {
        Ant Create(Size borders);
    }
}
