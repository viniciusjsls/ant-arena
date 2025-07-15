using Ant_3_Arena.Constants;
using Ant_3_Arena.Strategies;
using Ant_3_Arena.ValueObject;
using System;
using System.Drawing;

namespace Ant_3_Arena.Ants
{
    public class Ant
    {
        public Position2D Position { get; private set; }
        public Velocity2D Velocity { get; private set; }

        private readonly IMovementStrategy Movement;
        private readonly Bitmap antImage;

        public Bitmap AntImage { get { return antImage; } }

        public Ant(
            Size borders,
            string color,
            int horizontalVelocity,
            int verticalVelocity,
            IMovementStrategy movementStrategy)
        {
            Velocity = new Velocity2D() { HorizontalVelocity = horizontalVelocity, VerticalVelocity = verticalVelocity };
            Movement = movementStrategy;

            Position = GetRandomStartupPosition(borders);
            antImage = GetColoredAnt(color);
        }

        private Position2D GetRandomStartupPosition(Size borders)
        {
            Random random = new Random();
            return new Position2D() { X = random.Next(0, borders.Width), Y = random.Next(0, borders.Height) };
        }

        private Bitmap GetColoredAnt(string color)
        {
            Color white = ColorTranslator.FromHtml(ColorConstant.WHITE);
            Color newColor = ColorTranslator.FromHtml(color);

            Bitmap bmp = new Bitmap(Properties.Resources.Ant);
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color gotColor = bmp.GetPixel(x, y);
                    if (gotColor == white)
                        bmp.SetPixel(x, y, newColor);
                }
            }

            return bmp;
        }

        public void Move(Size borders)
        {
            Movement.Move(borders, Position, Velocity);
        }
    }
}
