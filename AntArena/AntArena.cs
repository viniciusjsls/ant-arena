using Ant_3_Arena.Ants;
using Ant_3_Arena.Factories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ant_3_Arena
{
	public partial class AntArena : Form
	{
		private readonly ICollection<Ant> Ants;

		public AntArena()
		{
			InitializeComponent();
			this.WindowState = FormWindowState.Maximized;
			this.BackgroundImage = Properties.Resources.bg;

			IAntFactory redFactory = new AntYellowFactory();
            IAntFactory yellowFactory = new AntRedFactory();
            IAntFactory blackFactory = new AntBlackFactory();

			var createdAnts = new List<Ant>();
			
			createdAnts.AddRange(redFactory.CreateMany(ClientSize, 3));
            createdAnts.AddRange(yellowFactory.CreateMany(ClientSize, 3));
            createdAnts.AddRange(blackFactory.CreateMany(ClientSize, 3));

			Ants = createdAnts;
        }

		private void AntArena_Paint(object sender, PaintEventArgs e)
		{
			foreach (Ant ant in Ants)
			{
                e.Graphics.DrawImage(ant.AntImage, ant.Position.X, ant.Position.Y, 32, 36);
            }
        }

		private void timer1_Tick(object sender, EventArgs e)
		{
            foreach (Ant ant in Ants)
            {
                ant.Move(ClientSize);
            }
			
			Invalidate();
		}

		private void AntArena_Load(object sender, EventArgs e)
		{
			this.DoubleBuffered = true;
		}
	}
}