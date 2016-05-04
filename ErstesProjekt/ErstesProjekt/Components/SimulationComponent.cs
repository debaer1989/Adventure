using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace ErstesProjekt
{
    public class SimulationComponent : GameComponent
    {
        private Game1 game;
        public Vector2 Position
        {
            get;
            private set;
        }
        public SimulationComponent(Game1 game) : base(game)
        {
            this.game = game;
        }

        public override void Update(GameTime gameTime)
        {

            Position += game.Input.Direction;
            base.Update(gameTime);
        }

        
    }
}
